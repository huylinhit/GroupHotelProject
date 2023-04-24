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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            btnDelete = new Button();
            button1 = new Button();
            dgvBookings = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
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
            textBox9 = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tabControl1.Size = new Size(1103, 606);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1095, 573);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Booking Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(994, 4);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 28);
            comboBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(369, 4);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 28);
            comboBox1.TabIndex = 25;
            // 
            // button3
            // 
            button3.Location = new Point(612, 4);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 25);
            button3.TabIndex = 21;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(177, 448);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(273, 448);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 23;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(369, 33);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 82;
            dgvBookings.RowTemplate.Height = 41;
            dgvBookings.Size = new Size(722, 539);
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
            panel1.Controls.Add(textBox1);
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
            panel1.Size = new Size(362, 386);
            panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 344);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 296);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 250);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 202);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 156);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 111);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(195, 27);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 65);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(195, 27);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 348);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Phone";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(150, 20);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
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
            // textBox9
            // 
            textBox9.Location = new Point(468, 4);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(142, 27);
            textBox9.TabIndex = 26;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1095, 573);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BookingManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 606);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "BookingManagement";
            Text = "BookingManagement";
            Load += BookingManagement_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button3;
        private Button btnDelete;
        private Button button1;
        private DataGridView dgvBookings;
        private Label label2;
        private Panel panel1;
        private TextBox textBox1;
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
        private TextBox textBox9;
        private TabPage tabPage2;
    }
}