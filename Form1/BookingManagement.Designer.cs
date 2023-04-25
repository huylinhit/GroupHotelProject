namespace HotelBooking
{
    partial class BookingManagement
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
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            btnAddHotel = new Button();
            cboPrice = new ComboBox();
            cboRole = new ComboBox();
            txtSearchUserID = new TextBox();
            txtNameSearch = new TextBox();
            cboUsersName = new ComboBox();
            cboStatus = new ComboBox();
            cboHotelName = new ComboBox();
            btnSearch = new Button();
            button1 = new Button();
            dgvBookings = new DataGridView();
            label2 = new Label();
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1832, 573);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddHotel);
            tabPage1.Controls.Add(cboPrice);
            tabPage1.Controls.Add(cboRole);
            tabPage1.Controls.Add(txtSearchUserID);
            tabPage1.Controls.Add(txtNameSearch);
            tabPage1.Controls.Add(cboUsersName);
            tabPage1.Controls.Add(cboStatus);
            tabPage1.Controls.Add(cboHotelName);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1832, 573);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Booking Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddHotel
            // 
            btnAddHotel.Location = new Point(75, 492);
            btnAddHotel.Name = "btnAddHotel";
            btnAddHotel.Size = new Size(250, 29);
            btnAddHotel.TabIndex = 31;
            btnAddHotel.Text = "Hotel Management";
            btnAddHotel.UseVisualStyleBackColor = true;
            btnAddHotel.Click += btnAddHotel_Click;
            // 
            // cboPrice
            // 
            cboPrice.FormattingEnabled = true;
            cboPrice.Location = new Point(1322, 3);
            cboPrice.Margin = new Padding(2);
            cboPrice.Name = "cboPrice";
            cboPrice.Size = new Size(251, 28);
            cboPrice.TabIndex = 30;
            cboPrice.SelectedIndexChanged += cboPrice_SelectedIndexChanged;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(1577, 3);
            cboRole.Margin = new Padding(2);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(122, 28);
            cboRole.TabIndex = 29;
            cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
            // 
            // txtSearchUserID
            // 
            txtSearchUserID.Location = new Point(748, 2);
            txtSearchUserID.Margin = new Padding(2);
            txtSearchUserID.Name = "txtSearchUserID";
            txtSearchUserID.Size = new Size(80, 27);
            txtSearchUserID.TabIndex = 28;
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(832, 3);
            txtNameSearch.Margin = new Padding(2);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(142, 27);
            txtNameSearch.TabIndex = 26;
            // 
            // cboUsersName
            // 
            cboUsersName.FormattingEnabled = true;
            cboUsersName.Location = new Point(540, 0);
            cboUsersName.Margin = new Padding(2);
            cboUsersName.Name = "cboUsersName";
            cboUsersName.Size = new Size(171, 28);
            cboUsersName.TabIndex = 27;
            cboUsersName.SelectedIndexChanged += cboUsersName_SelectedIndexChanged;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1703, 3);
            cboStatus.Margin = new Padding(2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(122, 28);
            cboStatus.TabIndex = 24;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // cboHotelName
            // 
            cboHotelName.FormattingEnabled = true;
            cboHotelName.Location = new Point(369, 0);
            cboHotelName.Margin = new Padding(2);
            cboHotelName.Name = "cboHotelName";
            cboHotelName.Size = new Size(167, 28);
            cboHotelName.TabIndex = 25;
            cboHotelName.SelectedIndexChanged += cboHotelName_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(976, 3);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 28);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.Location = new Point(153, 537);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 23;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(369, 33);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 82;
            dgvBookings.RowTemplate.Height = 41;
            dgvBookings.Size = new Size(1456, 539);
            dgvBookings.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 32);
            label2.TabIndex = 19;
            label2.Text = "Booking Management";
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
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 33);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 444);
            panel1.TabIndex = 18;
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(151, 16);
            txtBookingID.Margin = new Padding(2);
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
            txtRole.Margin = new Padding(2);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(195, 27);
            txtRole.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 333);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(151, 287);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 239);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 193);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 148);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(195, 27);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 102);
            txtFirstName.Margin = new Padding(2);
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
            txtUserID.Margin = new Padding(2);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 244);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 6;
            label11.Text = "Password";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1840, 606);
            tabControl1.TabIndex = 0;
            // 
            // BookingManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1840, 606);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "BookingManagement";
            Text = "BookingManagement";
            Load += BookingManagement_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnAddHotel;
        private ComboBox cboPrice;
        private ComboBox cboRole;
        private TextBox txtSearchUserID;
        private TextBox txtNameSearch;
        private ComboBox cboUsersName;
        private ComboBox cboStatus;
        private ComboBox cboHotelName;
        private Button btnSearch;
        private Button button1;
        private DataGridView dgvBookings;
        private Label label2;
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
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TabControl tabControl1;
    }
}