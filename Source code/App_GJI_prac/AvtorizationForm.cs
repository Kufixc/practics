using Npgsql;
using System;
using System.Windows.Forms;

namespace App_GJI_prac
{
    public partial class AvtorizationForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=DataBaseGJI;Username=user;Password=pass";

        public AvtorizationForm()
        {
            InitializeComponent();
        }

        private void AvtorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public bool ValidateUser(string userName, string password, out string fio, out string role, out bool isAdmin)
        {
            fio = string.Empty;
            role = string.Empty;
            isAdmin = false;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT FIO, Role FROM Users WHERE UserName = @userName AND Password = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("userName", userName);
                        cmd.Parameters.AddWithValue("password", password);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fio = reader["FIO"].ToString();
                                role = reader["Role"].ToString();
                                isAdmin = role.Equals("Администратор", StringComparison.OrdinalIgnoreCase);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке данных пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateUser(userName, password, out string fio, out string role, out bool isAdmin))
            {
                FormReports formReports = new FormReports(fio, role, isAdmin, userName);
                formReports.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
