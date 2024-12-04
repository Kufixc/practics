namespace App_GJI_prac
{
    partial class FormReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddReports = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userRoleLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.dataGridReports = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnAddReports);
            this.panel1.Controls.Add(this.dateBox);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.userRoleLbl);
            this.panel1.Controls.Add(this.userNameLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 599);
            this.panel1.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnAddUser.Location = new System.Drawing.Point(15, 217);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(182, 31);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddReports
            // 
            this.btnAddReports.AutoSize = true;
            this.btnAddReports.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReports.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnAddReports.Location = new System.Drawing.Point(15, 217);
            this.btnAddReports.Name = "btnAddReports";
            this.btnAddReports.Size = new System.Drawing.Size(182, 31);
            this.btnAddReports.TabIndex = 6;
            this.btnAddReports.Text = "Добавить";
            this.btnAddReports.UseVisualStyleBackColor = false;
            this.btnAddReports.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateBox
            // 
            this.dateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateBox.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Items.AddRange(new object[] {
            "2024 год",
            "2023 год",
            "2022 год",
            "2021",
            "2020"});
            this.dateBox.Location = new System.Drawing.Point(15, 254);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(182, 23);
            this.dateBox.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(15, 556);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = true;
            this.btnReports.BackColor = System.Drawing.Color.Lavender;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnReports.Location = new System.Drawing.Point(15, 180);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(182, 31);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Жалобы";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.BackColor = System.Drawing.Color.Lavender;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Benzin-Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.Location = new System.Drawing.Point(15, 132);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(182, 31);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 2);
            this.panel3.TabIndex = 2;
            // 
            // userRoleLbl
            // 
            this.userRoleLbl.Font = new System.Drawing.Font("Benzin-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRoleLbl.ForeColor = System.Drawing.Color.White;
            this.userRoleLbl.Location = new System.Drawing.Point(0, 71);
            this.userRoleLbl.Name = "userRoleLbl";
            this.userRoleLbl.Size = new System.Drawing.Size(209, 21);
            this.userRoleLbl.TabIndex = 1;
            this.userRoleLbl.Text = "Администратор";
            this.userRoleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLbl
            // 
            this.userNameLbl.Font = new System.Drawing.Font("Benzin-Regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(0, 9);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(212, 62);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Ольга Валерьеввана";
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridReports
            // 
            this.dataGridReports.AllowUserToAddRows = false;
            this.dataGridReports.AllowUserToDeleteRows = false;
            this.dataGridReports.AllowUserToOrderColumns = true;
            this.dataGridReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridReports.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReports.Location = new System.Drawing.Point(212, 65);
            this.dataGridReports.MultiSelect = false;
            this.dataGridReports.Name = "dataGridReports";
            this.dataGridReports.ReadOnly = true;
            this.dataGridReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReports.Size = new System.Drawing.Size(836, 534);
            this.dataGridReports.TabIndex = 1;
            this.dataGridReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReports_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.typeBox);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 65);
            this.panel2.TabIndex = 2;
            // 
            // typeBox
            // 
            this.typeBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Benzin-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(618, 23);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(206, 26);
            this.typeBox.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.searchBox.Font = new System.Drawing.Font("Benzin-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(100, 23);
            this.searchBox.Margin = new System.Windows.Forms.Padding(100);
            this.searchBox.MaximumSize = new System.Drawing.Size(475, 30);
            this.searchBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(475, 30);
            this.searchBox.TabIndex = 0;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToOrderColumns = true;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsers.Location = new System.Drawing.Point(212, 65);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(836, 534);
            this.dataGridUsers.TabIndex = 3;
            this.dataGridUsers.Visible = false;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Benzin-Regular", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 599);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridReports);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1064, 350);
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное окно";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReports_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label userRoleLbl;
        private System.Windows.Forms.DataGridView dataGridReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.Button btnAddReports;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label1;
    }
}