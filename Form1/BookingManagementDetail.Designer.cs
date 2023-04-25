namespace Form1
{
    partial class BookingManagementDetail
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
            panel1 = new Panel();
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtCheckOutDate = new TextBox();
            txtCheckInDate = new TextBox();
            txtRoomTypeName = new TextBox();
            label19 = new Label();
            txtTotalPrice = new TextBox();
            txtRoomNumber = new TextBox();
            label3 = new Label();
            txtRoomID = new TextBox();
            cboStatus = new ComboBox();
            txtUserID2 = new TextBox();
            txtBookingID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(42, 85);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 432);
            panel1.TabIndex = 19;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(150, 344);
            txtRole.Margin = new Padding(2);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(195, 27);
            txtRole.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 296);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 250);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 202);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 156);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 111);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(195, 27);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 65);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(195, 27);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 348);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Role";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(150, 20);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(195, 27);
            txtUserID.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 301);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 4;
            label13.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 254);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 5;
            label12.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 207);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 6;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 160);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 7;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 116);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 8;
            label9.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 67);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 9;
            label8.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 22);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 10;
            label7.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(353, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 20;
            label2.Text = "Booking Management Update";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCheckOutDate);
            panel2.Controls.Add(txtCheckInDate);
            panel2.Controls.Add(txtRoomTypeName);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txtTotalPrice);
            panel2.Controls.Add(txtRoomNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtRoomID);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(txtUserID2);
            panel2.Controls.Add(txtBookingID);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(455, 85);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 432);
            panel2.TabIndex = 20;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Location = new Point(150, 290);
            txtCheckOutDate.Margin = new Padding(2);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.ReadOnly = true;
            txtCheckOutDate.Size = new Size(392, 27);
            txtCheckOutDate.TabIndex = 36;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.Location = new Point(150, 244);
            txtCheckInDate.Margin = new Padding(2);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.ReadOnly = true;
            txtCheckInDate.Size = new Size(392, 27);
            txtCheckInDate.TabIndex = 35;
            // 
            // txtRoomTypeName
            // 
            txtRoomTypeName.Location = new Point(150, 202);
            txtRoomTypeName.Margin = new Padding(2);
            txtRoomTypeName.Name = "txtRoomTypeName";
            txtRoomTypeName.ReadOnly = true;
            txtRoomTypeName.Size = new Size(392, 27);
            txtRoomTypeName.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 202);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 33;
            label19.Text = "RoomType";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(150, 332);
            txtTotalPrice.Margin = new Padding(2);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(392, 27);
            txtTotalPrice.TabIndex = 30;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(150, 159);
            txtRoomNumber.Margin = new Padding(2);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(392, 27);
            txtRoomNumber.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 26;
            label3.Text = "RoomNumber";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(150, 113);
            txtRoomID.Margin = new Padding(2);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.ReadOnly = true;
            txtRoomID.Size = new Size(392, 27);
            txtRoomID.TabIndex = 25;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(150, 376);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(392, 28);
            cboStatus.TabIndex = 24;
            // 
            // txtUserID2
            // 
            txtUserID2.Location = new Point(150, 65);
            txtUserID2.Margin = new Padding(2);
            txtUserID2.Name = "txtUserID2";
            txtUserID2.ReadOnly = true;
            txtUserID2.Size = new Size(392, 27);
            txtUserID2.TabIndex = 16;
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(150, 20);
            txtBookingID.Margin = new Padding(2);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.ReadOnly = true;
            txtBookingID.Size = new Size(392, 27);
            txtBookingID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 376);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 338);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "TotalPrice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 291);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 6;
            label6.Text = "CheckOutDate";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 244);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(92, 20);
            label14.TabIndex = 7;
            label14.Text = "CheckInDate";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 116);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 8;
            label15.Text = "RoomID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 67);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 9;
            label16.Text = "User ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 22);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(83, 20);
            label17.TabIndex = 10;
            label17.Text = "Booking ID";
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(324, 538);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(522, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookingManagementDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 595);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "BookingManagementDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingManagementDetail";
            Load += BookingManagementDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
        private Panel panel2;
        private ComboBox cboStatus;
        private TextBox txtUserID2;
        private TextBox txtBookingID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtRoomID;
        private Label label3;
        private TextBox txtTotalPrice;
        private TextBox txtRoomNumber;
        private Label label19;
        private TextBox textBox1;
        private TextBox txtCheckInDate;
        private TextBox txtRoomTypeName;
        public TextBox txtCheckOutDate;
        private Button btnUpdate;
        private Button btnCancel;
    }
}