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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 73);
            label1.Name = "label1";
            label1.Size = new Size(330, 32);
            label1.TabIndex = 1;
            label1.Text = "City, Location or Hotel Name\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(72, 108);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1052, 38);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 219);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 1;
            label2.Text = "Check-in";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(473, 254);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(332, 38);
            textBox3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(473, 219);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 1;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(870, 219);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 1;
            label4.Text = "Check-out";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 379);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 1;
            label5.Text = "Guests";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(72, 414);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 38);
            textBox5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(870, 257);
            label7.Name = "label7";
            label7.Size = new Size(230, 37);
            label7.TabIndex = 1;
            label7.Text = "Mon, 4 April 2023";
            label7.Click += label7_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(72, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(332, 38);
            dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(289, 379);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 1;
            label6.Text = "Rooms";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(289, 414);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 38);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(768, 375);
            button1.Name = "button1";
            button1.Size = new Size(356, 74);
            button1.TabIndex = 4;
            button1.Text = "Search Hotels";
            button1.UseVisualStyleBackColor = false;
            // 
            // GiveInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 509);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GiveInfo";
            Text = "GiveInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
    }
}