namespace HotelBooking
{
    partial class GiveInfo
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
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            txtDuration = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtGuest = new TextBox();
            lblCheckOut = new Label();
            dtpkrCheckIn = new DateTimePicker();
            btnSearchHotel = new Button();
            lblMsg = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Location or Hotel Name\r\n";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(30, 39);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(649, 27);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-in";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(199, 105);
            txtDuration.Margin = new Padding(2, 1, 2, 1);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(130, 27);
            txtDuration.TabIndex = 2;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(199, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(396, 82);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 1;
            label4.Text = "Check-out";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(582, 84);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 1;
            label5.Text = "Guests";
            // 
            // txtGuest
            // 
            txtGuest.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuest.Location = new Point(582, 106);
            txtGuest.Margin = new Padding(2, 1, 2, 1);
            txtGuest.Name = "txtGuest";
            txtGuest.Size = new Size(97, 27);
            txtGuest.TabIndex = 2;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckOut.Location = new Point(396, 106);
            lblCheckOut.Margin = new Padding(2, 0, 2, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(144, 23);
            lblCheckOut.TabIndex = 1;
            lblCheckOut.Text = "Mon, 4 April 2023";
            // 
            // dtpkrCheckIn
            // 
            dtpkrCheckIn.CustomFormat = "dd/MM/yyyy";
            dtpkrCheckIn.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkrCheckIn.Format = DateTimePickerFormat.Custom;
            dtpkrCheckIn.Location = new Point(30, 102);
            dtpkrCheckIn.Margin = new Padding(2);
            dtpkrCheckIn.MinDate = new DateTime(2023, 4, 24, 0, 0, 0, 0);
            dtpkrCheckIn.Name = "dtpkrCheckIn";
            dtpkrCheckIn.Size = new Size(133, 27);
            dtpkrCheckIn.TabIndex = 3;
            dtpkrCheckIn.ValueChanged += dtpkrCheckIn_ValueChanged;
            // 
            // btnSearchHotel
            // 
            btnSearchHotel.BackColor = Color.FromArgb(255, 128, 0);
            btnSearchHotel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchHotel.ForeColor = Color.White;
            btnSearchHotel.Location = new Point(528, 144);
            btnSearchHotel.Margin = new Padding(2);
            btnSearchHotel.Name = "btnSearchHotel";
            btnSearchHotel.Size = new Size(151, 46);
            btnSearchHotel.TabIndex = 4;
            btnSearchHotel.Text = "Search Hotels";
            btnSearchHotel.UseVisualStyleBackColor = false;
            btnSearchHotel.Click += btnSearchHotel_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(231, 287);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnSearchHotel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpkrCheckIn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDuration);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtGuest);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblCheckOut);
            panel1.Location = new Point(13, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 206);
            panel1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(255, 128, 0);
            btnLogin.Location = new Point(30, 144);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(76, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Centaur", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(200, 23);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(297, 23);
            label6.TabIndex = 7;
            label6.Text = "Welcome to Hotel Booking System";
            // 
            // GiveInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 284);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(lblMsg);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GiveInfo";
            Text = "GiveInfo";
            Load += GiveInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private TextBox txtDuration;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGuest;
        private Label lblCheckOut;
        private DateTimePicker dtpkrCheckIn;
        private Button btnSearchHotel;
        private Label lblMsg;
        private Panel panel1;
        private Button btnLogin;
        private Label label6;
    }
}