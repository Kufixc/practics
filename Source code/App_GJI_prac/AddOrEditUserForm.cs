using Npgsql;
using System;
using System.Windows.Forms;

namespace App_GJI_prac
{
    public partial class AddOrEditUserForm : Form
    {
        private bool isEditMode;
        private string originalUserName;
        private string connectionString = "Host=localhost;Port=5432;Database=DataBaseGJI;Username=user;Password=pass";

        public AddOrEditUserForm(string formTitle, string fio = "", string role = "", string userName = "", string password = "")
        {
            InitializeComponent();
            this.Text = formTitle;

            isEditMode = formTitle.Equals("Редактирование пользователя");
            originalUserName = userName;

            FioBox.Text = fio;
            roleBox.Text = role;
            userNameBox.Text = userName;
            passwordBox.Text = password;
        }

        private void AddOrEditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormReports.Instance.Show();
            FormReports.Instance.LoadUsersData();
            this.Hide();
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FioBox.Text) || string.IsNullOrWhiteSpace(roleBox.Text) ||
                string.IsNullOrWhiteSpace(userNameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditMode)
            {
                UpdateUser();
            }
            else
            {
                AddUser();
            }
        }

        private void AddUser()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Users (FIO, Role, UserName, Password) VALUES (@fio, @role, @userName, @password)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("fio", FioBox.Text);
                        cmd.Parameters.AddWithValue("role", roleBox.Text);
                        cmd.Parameters.AddWithValue("userName", userNameBox.Text);
                        cmd.Parameters.AddWithValue("password", passwordBox.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Пользователь успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnToMainForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM Users WHERE UserName = @originalUserName";
                    using (NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("originalUserName", originalUserName);
                        deleteCmd.ExecuteNonQuery();
                    }

                    string insertQuery = "INSERT INTO Users (FIO, Role, UserName, Password) VALUES (@fio, @role, @userName, @password)";
                    using (NpgsqlCommand insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("fio", FioBox.Text);
                        insertCmd.Parameters.AddWithValue("role", roleBox.Text);
                        insertCmd.Parameters.AddWithValue("userName", userNameBox.Text);
                        insertCmd.Parameters.AddWithValue("password", passwordBox.Text);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные пользователя успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnToMainForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnToMainForm()
        {
            FormReports.Instance.Show();
            FormReports.Instance.LoadUsersData();
            this.Hide();
        }
    }
}
