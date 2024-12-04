using Npgsql;
using System;
using System.Windows.Forms;

namespace App_GJI_prac
{
    public partial class AddOrEditForm : Form
    {
        private bool isEditMode;
        private int? reportId;
        private string connectionString = "Host=localhost;Port=5432;Database=DataBaseGJI;Username=user;Password=pass";

        public AddOrEditForm(string formTitle, string contractNumber = "", string registrationDate = "",
            string complaintDate = "", string senderName = "", string taskStatus = "", string resolutionDate = null)
        {
            InitializeComponent();
            this.Text = formTitle;

            isEditMode = formTitle.Equals("Редактирование жалобы");


            reportsBox.Text = contractNumber;
            dateReg.Text = registrationDate;
            dataSender.Text = complaintDate;
            FIOBox.Text = senderName;
            dateRelease.Text = resolutionDate;


            LoadTaskStatuses();

            if (!string.IsNullOrEmpty(taskStatus))
            {
                typeBox.SelectedItem = taskStatus;
            }
        }

        private void LoadTaskStatuses()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT TaskStatus FROM Report";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            typeBox.Items.Clear();
                            while (reader.Read())
                            {
                                typeBox.Items.Add(reader["TaskStatus"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов задач: {ex.Message}");
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(reportsBox.Text))
            {
                MessageBox.Show("Введите номер договора.");
                return false;
            }

            if (!DateTime.TryParseExact(dateReg.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Введите корректную дату регистрации.");
                return false;
            }

            if (!DateTime.TryParseExact(dataSender.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Введите корректную дату написания жалобы.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(FIOBox.Text))
            {
                MessageBox.Show("Введите ФИО отправителя.");
                return false;
            }

            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите состояние задачи.");
                return false;
            }

            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    if (isEditMode)
                    {

                        string deleteQuery = "DELETE FROM Report WHERE ContractNumber = @contractNumber";
                        using (NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("contractNumber", reportsBox.Text);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }

                    string insertQuery = @"
                INSERT INTO Report
                (ContractNumber, RegistrationDate, ComplaintDate, SenderName, TaskStatus, ResolutionDate)
                VALUES 
                (@contractNumber, @registrationDate, @complaintDate, @senderName, @taskStatus, @resolutionDate)";

                    using (NpgsqlCommand insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("contractNumber", reportsBox.Text);
                        insertCmd.Parameters.AddWithValue("registrationDate", DateTime.ParseExact(dateReg.Text, "dd.MM.yyyy", null));
                        insertCmd.Parameters.AddWithValue("complaintDate", DateTime.ParseExact(dataSender.Text, "dd.MM.yyyy", null));
                        insertCmd.Parameters.AddWithValue("senderName", FIOBox.Text);
                        insertCmd.Parameters.AddWithValue("taskStatus", typeBox.SelectedItem.ToString());
                        insertCmd.Parameters.AddWithValue("resolutionDate", string.IsNullOrWhiteSpace(dateRelease.Text)
                            ? DBNull.Value
                            : (object)DateTime.ParseExact(dateRelease.Text, "dd.MM.yyyy", null));

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные успешно сохранены!");
                this.DialogResult = DialogResult.OK;

                FormReports.Instance.Show();
                FormReports.Instance.LoadData();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void AddOrEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormReports.Instance.Show();
            FormReports.Instance.LoadData();
            this.Hide();

        }
    }
}
