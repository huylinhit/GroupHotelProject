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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Location or Hotel Name\r\n";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(44, 68);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(649, 27);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-in";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(213, 155);
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
            label3.Location = new Point(213, 136);
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
            label4.Location = new Point(410, 132);
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
            label5.Location = new Point(596, 134);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 1;
            label5.Text = "Guests";
            // 
            // txtGuest
            // 
            txtGuest.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuest.Location = new Point(596, 156);
            txtGuest.Margin = new Padding(2, 1, 2, 1);
            txtGuest.Name = "txtGuest";
            txtGuest.Size = new Size(97, 27);
            txtGuest.TabIndex = 2;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckOut.Location = new Point(410, 156);
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
            dtpkrCheckIn.Location = new Point(44, 152);
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
            btnSearchHotel.Location = new Point(269, 249);
            btnSearchHotel.Margin = new Padding(2);
            btnSearchHotel.Name = "btnSearchHotel";
            btnSearchHotel.Size = new Size(219, 46);
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
            lblMsg.Location = new Point(269, 206);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 5;
            // 
            // GiveInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 318);
            Controls.Add(lblMsg);
            Controls.Add(btnSearchHotel);
            Controls.Add(dtpkrCheckIn);
            Controls.Add(txtDuration);
            Controls.Add(txtGuest);
            Controls.Add(txtSearch);
            Controls.Add(lblCheckOut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GiveInfo";
            Text = "GiveInfo";
            Load += GiveInfo_Load;
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
    }
}