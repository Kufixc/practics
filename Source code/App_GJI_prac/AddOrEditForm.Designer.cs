namespace App_GJI_prac
{
    partial class AddOrEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportsBox = new System.Windows.Forms.TextBox();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.dateRelease = new System.Windows.Forms.MaskedTextBox();
            this.dataSender = new System.Windows.Forms.MaskedTextBox();
            this.dateReg = new System.Windows.Forms.MaskedTextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.btnAddOrEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(367, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Состояние задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата написания жалобы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(367, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "ФИО отправителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(367, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата решения задачи";
            // 
            // reportsBox
            // 
            this.reportsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reportsBox.Location = new System.Drawing.Point(12, 46);
            this.reportsBox.Name = "reportsBox";
            this.reportsBox.Size = new System.Drawing.Size(212, 26);
            this.reportsBox.TabIndex = 5;
            // 
            // FIOBox
            // 
            this.FIOBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FIOBox.Location = new System.Drawing.Point(371, 46);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(212, 26);
            this.FIOBox.TabIndex = 10;
            // 
            // dateRelease
            // 
            this.dateRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateRelease.Location = new System.Drawing.Point(371, 164);
            this.dateRelease.Mask = "00/00/0000";
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(103, 26);
            this.dateRelease.TabIndex = 11;
            this.dateRelease.ValidatingType = typeof(System.DateTime);
            // 
            // dataSender
            // 
            this.dataSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dataSender.Location = new System.Drawing.Point(12, 164);
            this.dataSender.Mask = "00/00/0000";
            this.dataSender.Name = "dataSender";
            this.dataSender.Size = new System.Drawing.Size(106, 26);
            this.dataSender.TabIndex = 12;
            this.dataSender.ValidatingType = typeof(System.DateTime);
            // 
            // dateReg
            // 
            this.dateReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateReg.Location = new System.Drawing.Point(12, 106);
            this.dateReg.Mask = "00/00/0000";
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(103, 26);
            this.dateReg.TabIndex = 13;
            // 
            // typeBox
            // 
            this.typeBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Benzin-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(371, 106);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(212, 26);
            this.typeBox.TabIndex = 14;
            // 
            // btnAddOrEdit
            // 
            this.btnAddOrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddOrEdit.AutoSize = true;
            this.btnAddOrEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddOrEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrEdit.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnAddOrEdit.Location = new System.Drawing.Point(371, 218);
            this.btnAddOrEdit.Name = "btnAddOrEdit";
            this.btnAddOrEdit.Size = new System.Drawing.Size(212, 31);
            this.btnAddOrEdit.TabIndex = 15;
            this.btnAddOrEdit.Text = "Сохранить";
            this.btnAddOrEdit.UseVisualStyleBackColor = false;
            this.btnAddOrEdit.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Benzin-Regular", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(12, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddOrEdit);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.dataSender);
            this.Controls.Add(this.dateRelease);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.reportsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 300);
            this.MinimumSize = new System.Drawing.Size(613, 300);
            this.Name = "AddOrEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reportsBox;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.MaskedTextBox dateRelease;
        private System.Windows.Forms.MaskedTextBox dataSender;
        private System.Windows.Forms.MaskedTextBox dateReg;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button btnAddOrEdit;
        private System.Windows.Forms.Button btnBack;
    }
}