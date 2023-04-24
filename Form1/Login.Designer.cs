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
            button1 = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 73);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 139);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(265, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 39);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(316, 39);
            txtPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(431, 236);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(275, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 378);
            Controls.Add(btnLogin);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button button1;
        private Button btnLogin;
    }
}