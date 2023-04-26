namespace HotelBooking
{
    partial class Login
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
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSearchHotel = new Button();
            button2 = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 45);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(159, 86);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnSearchHotel
            // 
            btnSearchHotel.BackColor = Color.FromArgb(255, 128, 0);
            btnSearchHotel.FlatAppearance.BorderSize = 0;
            btnSearchHotel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchHotel.ForeColor = Color.White;
            btnSearchHotel.Location = new Point(262, 148);
            btnSearchHotel.Margin = new Padding(2);
            btnSearchHotel.Name = "btnSearchHotel";
            btnSearchHotel.Size = new Size(93, 34);
            btnSearchHotel.TabIndex = 5;
            btnSearchHotel.Text = "LOG IN";
            btnSearchHotel.UseVisualStyleBackColor = false;
            btnSearchHotel.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(159, 148);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(84, 34);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(159, 120);
            lblMsg.Margin = new Padding(2, 0, 2, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 207);
            Controls.Add(lblMsg);
            Controls.Add(button2);
            Controls.Add(btnSearchHotel);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSearchHotel;
        private Button button2;
        private Label lblMsg;
    }
}