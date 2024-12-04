using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GJI_prac
{
    public partial class FormReports : Form
    {
        private string userFio;
        private string userRole;
        private bool isAdmin;
        public static FormReports Instance { get; private set; }
        public static string CurrentUserName { get; private set; }



        private bool isUsersMode = false;
        private string connectionString = "Host=localhost;Port=5432;Database=DataBaseGJI;Username=user;Password=pass";

        public FormReports(string fio, string role, bool isAdmin, string userName = "")
        {
            InitializeComponent();
            InitializeTextBoxPlaceholder(searchBox, "");
            Instance = this;

            CurrentUserName = userName;
            this.isAdmin = isAdmin;

            userNameLbl.Text = fio;
            userRoleLbl.Text = role;

            if (!isAdmin)
            {
                btnUsers.Visible = false;
                dateBox.Location = btnAddUser.Location;
                btnAddReports.Location = btnReports.Location;
                btnReports.Location = btnUsers.Location;

            }
            LoadData();

            LoadFilters();
            ApplyFilters();
            searchBox.TextChanged += (s, e) => ApplyFilters();
            dateBox.SelectedIndexChanged += (s, e) => ApplyFilters();
            typeBox.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private async void btnUsers_Click(object sender, EventArgs e)
        {
            isUsersMode = true;
            ToggleViewMode();
            await LoadUsersDataAsync();
        }

        private async void btnReports_Click(object sender, EventArgs e)
        {
            isUsersMode = false;
            ToggleViewMode();
            await LoadDataAsync();
        }

        private void ToggleViewMode()
        {
            searchBox.Visible = !isUsersMode;
            typeBox.Visible = !isUsersMode;
            btnAddReports.Visible = !isUsersMode;
            dateBox.Visible = !isUsersMode;
            dataGridUsers.Visible = isUsersMode;
            dataGridReports.Visible = !isUsersMode;
            btnAddUser.Visible = isUsersMode;
            btnAddReports.Visible = !isUsersMode;
        }

        #region Загрузка данных и взаимодействие в таблицей
        public bool LoadUsersData()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FIO AS \"ФИО\", Role AS \"Роль\", UserName AS \"Имя пользователя\", Password AS \"Пароль\" FROM Users";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridUsers.DataSource = table;

                    int iconSize = 35;

                    if (dataGridUsers.Columns.Count < 6)
                    {
                        DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn
                        {
                            Image = ResizeImage("edit.png", iconSize, iconSize),
                            ImageLayout = DataGridViewImageCellLayout.Normal,
                            DefaultCellStyle = new DataGridViewCellStyle
                            {
                                Padding = new Padding((dataGridUsers.RowTemplate.Height - iconSize) / 2)
                            }
                        };
                        dataGridUsers.Columns.Add(editButtonColumn);
                        dataGridUsers.Columns[4].Width = 40;
                    }

                    if (dataGridUsers.Columns.Count < 6)
                    {
                        DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
                        {
                            Image = ResizeImage("del.png", 30, 30),
                            ImageLayout = DataGridViewImageCellLayout.Normal,
                            DefaultCellStyle = new DataGridViewCellStyle
                            {
                                Padding = new Padding((dataGridUsers.RowTemplate.Height - iconSize) / 2)
                            }
                        };
                        dataGridUsers.Columns.Add(deleteButtonColumn);
                        dataGridUsers.Columns[5].Width = 40;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}");
                return false;
            }
        }

        public async Task LoadUsersDataAsync()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT FIO AS \"ФИО\", Role AS \"Роль\", UserName AS \"Имя пользователя\", Password AS \"Пароль\" FROM Users";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        await Task.Run(() => adapter.Fill(table)); 

                        dataGridUsers.Invoke((Action)(() => dataGridUsers.DataSource = table));

                        int iconSize = 35;

                        if (dataGridUsers.Columns.Count < 6)
                        {
                            dataGridUsers.Invoke((Action)(() =>
                            {
                                DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn
                                {
                                    Image = ResizeImage("edit.png", iconSize, iconSize),
                                    ImageLayout = DataGridViewImageCellLayout.Normal,
                                    DefaultCellStyle = new DataGridViewCellStyle
                                    {
                                        Padding = new Padding((dataGridUsers.RowTemplate.Height - iconSize) / 2)
                                    }
                                };
                                dataGridUsers.Columns.Add(editButtonColumn);
                                dataGridUsers.Columns[4].Width = 40;
                            }));
                        }

                        if (dataGridUsers.Columns.Count < 6)
                        {
                            dataGridUsers.Invoke((Action)(() =>
                            {
                                DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
                                {
                                    Image = ResizeImage("del.png", 30, 30),
                                    ImageLayout = DataGridViewImageCellLayout.Normal,
                                    DefaultCellStyle = new DataGridViewCellStyle
                                    {
                                        Padding = new Padding((dataGridUsers.RowTemplate.Height - iconSize) / 2)
                                    }
                                };
                                dataGridUsers.Columns.Add(deleteButtonColumn);
                                dataGridUsers.Columns[5].Width = 40;
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}");
            }
        }

        public async Task LoadDataAsync()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    string query = @"SELECT ContractNumber AS ""Номер договора"", RegistrationDate AS ""Дата регистрации"",
                             ComplaintDate AS ""Дата написания жалобы"", SenderName AS ""ФИО отправителя"",
                             TaskStatus AS ""Состояние задачи"", ResolutionDate AS ""Дата решения проблемы"" FROM Report";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        await Task.Run(() => adapter.Fill(table));

                        dataGridReports.Invoke((Action)(() => dataGridReports.DataSource = table)); 

                        int iconSize = 35;

                        if (dataGridReports.Columns.Count < 8)
                        {
                            dataGridReports.Invoke((Action)(() =>
                            {
                                DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn
                                {
                                    Image = ResizeImage("edit.png", iconSize, iconSize),
                                    ImageLayout = DataGridViewImageCellLayout.Normal,
                                    DefaultCellStyle = new DataGridViewCellStyle
                                    {
                                        Padding = new Padding((dataGridReports.RowTemplate.Height - iconSize) / 2)
                                    }
                                };
                                dataGridReports.Columns.Add(editButtonColumn);
                                dataGridReports.Columns[6].Width = 40;
                            }));
                        }

                        if (dataGridReports.Columns.Count < 8)
                        {
                            dataGridReports.Invoke((Action)(() =>
                            {
                                DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
                                {
                                    Image = ResizeImage("del.png", 30, 30),
                                    ImageLayout = DataGridViewImageCellLayout.Normal,
                                    DefaultCellStyle = new DataGridViewCellStyle
                                    {
                                        Padding = new Padding((dataGridReports.RowTemplate.Height - iconSize) / 2)
                                    }
                                };
                                dataGridReports.Columns.Add(deleteButtonColumn);
                                dataGridReports.Columns[7].Width = 40;
                            }));
                        }

                        dataGridReports.Invoke((Action)(() =>
                        {
                            dataGridReports.Columns[1].DefaultCellStyle.Font = new Font(dataGridReports.DefaultCellStyle.Font, FontStyle.Bold);
                            dataGridReports.Columns[5].DefaultCellStyle.Font = new Font(dataGridReports.DefaultCellStyle.Font, FontStyle.Bold);
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }


        public bool LoadData()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT   ContractNumber AS ""Номер договора"", RegistrationDate AS ""Дата регистрации"", ComplaintDate AS ""Дата написания жалобы"", SenderName AS ""ФИО отправителя"", TaskStatus AS ""Состояние задачи"", ResolutionDate AS ""Дата решения проблемы"" FROM Report";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridReports.DataSource = table;
                    int iconSize = 35;

                    if (dataGridReports.Columns.Count < 8)
                    {
                        DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn
                        {

                            Image = ResizeImage("edit.png", iconSize, iconSize),
                            ImageLayout = DataGridViewImageCellLayout.Normal,
                            DefaultCellStyle = new DataGridViewCellStyle
                            {
                                Padding = new Padding((dataGridReports.RowTemplate.Height - iconSize) / 2)
                            }
                        };
                        dataGridReports.Columns.Add(editButtonColumn);
                        dataGridReports.Columns[6].Width = 40;
                    }

                    if (dataGridReports.Columns.Count < 8)
                    {
                        DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
                        {

                            Image = ResizeImage("del.png", 30, 30),
                            ImageLayout = DataGridViewImageCellLayout.Normal,
                            DefaultCellStyle = new DataGridViewCellStyle
                            {
                                Padding = new Padding((dataGridReports.RowTemplate.Height - iconSize) / 2)
                            }
                        };
                        dataGridReports.Columns.Add(deleteButtonColumn);
                        dataGridReports.Columns[7].Width = 40;
                    }
                    dataGridReports.Columns[1].DefaultCellStyle.Font = new Font(dataGridReports.DefaultCellStyle.Font, FontStyle.Bold);


                    dataGridReports.Columns[5].DefaultCellStyle.Font = new Font(dataGridReports.DefaultCellStyle.Font, FontStyle.Bold);

                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                return false;
            }
        }


        private Image ResizeImage(string imagePath, int width, int height)
        {
            using (Image originalImage = Image.FromFile(imagePath))
            {
                Bitmap resizedImage = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(originalImage, 0, 0, width, height);
                }
                return resizedImage;
            }
        }

        private void dataGridReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int columnName = dataGridReports.Columns[e.ColumnIndex].Index + 6;

                if (columnName == 6)
                {
                    DataGridViewRow selectedRow = dataGridReports.Rows[e.RowIndex];

                    string id = selectedRow.Cells[7].Value?.ToString();
                    string contractNumber = selectedRow.Cells["Номер договора"].Value?.ToString();
                    string registrationDate = selectedRow.Cells["Дата регистрации"].Value?.ToString();
                    string complaintDate = selectedRow.Cells["Дата написания жалобы"].Value?.ToString();
                    string senderName = selectedRow.Cells["ФИО отправителя"].Value?.ToString();
                    string taskStatus = selectedRow.Cells["Состояние задачи"].Value?.ToString();
                    string resolutionDate = selectedRow.Cells["Дата решения проблемы"].Value?.ToString();


                    var editForm = new AddOrEditForm("Редактирование жалобы",
                                                     contractNumber, registrationDate, complaintDate,
                                                     senderName, taskStatus, resolutionDate);
                    editForm.Show();
                    this.Hide();

                }
                else if (columnName == 7)
                {
                    string contractNumber = dataGridReports.Rows[e.RowIndex].Cells["Номер договора"].Value.ToString();

                    var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                                                        "Подтверждение удаления",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteRow(contractNumber);
                    }
                }

            }

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int columnName = dataGridUsers.Columns[e.ColumnIndex].Index + 1;

                if (columnName == 5)
                {
                    DataGridViewRow selectedRow = dataGridUsers.Rows[e.RowIndex];
                    string fio = selectedRow.Cells["ФИО"].Value?.ToString();
                    string role = selectedRow.Cells["Роль"].Value?.ToString();
                    string userName = selectedRow.Cells["Имя пользователя"].Value?.ToString();
                    string password = selectedRow.Cells["Пароль"].Value?.ToString();

                    var editUserForm = new AddOrEditUserForm("Редактирование пользователя", fio, role, userName, password);
                    editUserForm.Show();
                    this.Hide();
                }
                else if (columnName == 6)
                {
                    string userName = dataGridUsers.Rows[e.RowIndex].Cells["Имя пользователя"].Value.ToString();

                    var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить пользователя?",
                                                        "Подтверждение удаления",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteUser(userName);

                    }
                }

            }
        }


        private void DeleteUser(string userName)
        {
            if (userName == CurrentUserName)
            {
                MessageBox.Show("Вы не можете удалить свою собственную учётную запись!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE UserName = @userName";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("userName", userName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Пользователь успешно удалён!");
                LoadUsersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
            }
        }

        public bool DeleteRow(string contractNumber)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Report WHERE ContractNumber = @contractNumber";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("contractNumber", contractNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Запись успешно удалена.");
                LoadData();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении записи: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Поиск и фильтрация

        private void LoadFilters()
        {
            dateBox.Items.Clear();
            dateBox.Items.Add("Все годы");
            dateBox.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020" });
            dateBox.SelectedIndex = 0;

            typeBox.Items.Clear();
            typeBox.Items.Add("Все состояния");
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
                MessageBox.Show($"Ошибка загрузки фильтров: {ex.Message}");
            }
            typeBox.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                    ContractNumber AS ""Номер договора"",
                    RegistrationDate AS ""Дата регистрации"",
                    ComplaintDate AS ""Дата написания жалобы"",
                    SenderName AS ""ФИО отправителя"",
                    TaskStatus AS ""Состояние задачи"",
                    ResolutionDate AS ""Дата решения проблемы""
                    FROM Report
                    WHERE 1=1";


                    if (dateBox.SelectedIndex > 0)
                    {
                        query += " AND EXTRACT(YEAR FROM RegistrationDate) = @year";
                    }

                    if (typeBox.SelectedIndex > 0)
                    {
                        query += " AND TaskStatus = @taskStatus";
                    }

                    if (!string.IsNullOrWhiteSpace(searchBox.Text))
                    {
                        query += " AND (ContractNumber ILIKE @searchText OR SenderName ILIKE @searchText)";
                    }

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {

                        if (dateBox.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("year", int.Parse(dateBox.SelectedItem.ToString()));
                        }
                        if (typeBox.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("taskStatus", typeBox.SelectedItem.ToString());
                        }
                        if (!string.IsNullOrWhiteSpace(searchBox.Text))
                        {
                            cmd.Parameters.AddWithValue("searchText", $"%{searchBox.Text}%");
                        }

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridReports.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка фильтрации: {ex.Message}");
            }
        }

        #endregion

        private void InitializeTextBoxPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void FormReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEditForm addOrEditForm = new AddOrEditForm("Создание жалобы", "", "", "", "", "", "");
            addOrEditForm.Show();
            this.Hide();

        }

       
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var editForm = new AddOrEditUserForm("Создание пользователя");
            editForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AvtorizationForm avtorization = new AvtorizationForm();
            avtorization.Show();
            this.Hide();
        }
    }
}
