﻿namespace Form1
{
    partial class ManagerBookingMangement
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
            label11 = new Label();
            txtSearch = new TextBox();
            cboSearch = new ComboBox();
            btnSearch = new Button();
            button6 = new Button();
            dgvBookingList = new DataGridView();
            panel1 = new Panel();
            txtBookingID = new TextBox();
            label3 = new Label();
            txtRole = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtUserID = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label2 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(28, 32);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(206, 28);
            label11.TabIndex = 54;
            label11.Text = "Booking Management";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(506, 30);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 27);
            txtSearch.TabIndex = 47;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Phone" });
            cboSearch.Location = new Point(414, 30);
            cboSearch.Margin = new Padding(2, 2, 2, 2);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(91, 28);
            cboSearch.TabIndex = 46;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(627, 28);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1083, 28);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(92, 29);
            button6.TabIndex = 43;
            button6.Text = "Load";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgvBookingList
            // 
            dgvBookingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingList.Location = new Point(415, 62);
            dgvBookingList.Margin = new Padding(2, 2, 2, 2);
            dgvBookingList.Name = "dgvBookingList";
            dgvBookingList.RowHeadersWidth = 82;
            dgvBookingList.RowTemplate.Height = 41;
            dgvBookingList.Size = new Size(761, 488);
            dgvBookingList.TabIndex = 41;
            dgvBookingList.CellDoubleClick += dgvBookingList_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBookingID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserID);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(28, 75);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 444);
            panel1.TabIndex = 55;
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(151, 16);
            txtBookingID.Margin = new Padding(2, 2, 2, 2);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.ReadOnly = true;
            txtBookingID.Size = new Size(195, 27);
            txtBookingID.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 18;
            label3.Text = "Booking ID";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(151, 381);
            txtRole.Margin = new Padding(2, 2, 2, 2);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(195, 27);
            txtRole.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 333);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(151, 287);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 239);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 193);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 148);
            txtLastName.Margin = new Padding(2, 2, 2, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(195, 27);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 102);
            txtFirstName.Margin = new Padding(2, 2, 2, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(195, 27);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 385);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Role";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(151, 57);
            txtUserID.Margin = new Padding(2, 2, 2, 2);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(195, 27);
            txtUserID.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 338);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 4;
            label13.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 291);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 5;
            label12.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 244);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 197);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 7;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 153);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 8;
            label9.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 104);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 9;
            label8.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 59);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 10;
            label7.Text = "User ID";
            // 
            // ManagerBookingMangement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 571);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Controls.Add(btnSearch);
            Controls.Add(button6);
            Controls.Add(dgvBookingList);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ManagerBookingMangement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerBookingMangement";
            Load += ManagerBookingMangement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private TextBox txtSearch;
        private ComboBox cboSearch;
        private Button btnSearch;
        private Button button6;
        private DataGridView dgvBookingList;
        private Panel panel1;
        private TextBox txtBookingID;
        private Label label3;
        private TextBox txtRole;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtUserID;
        private Label label13;
        private Label label12;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}