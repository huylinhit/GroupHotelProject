namespace HotelBooking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label5 = new Label();
            sortBedH2L = new RadioButton();
            sortBedNone = new RadioButton();
            sortBedL2H = new RadioButton();
            panel1 = new Panel();
            label2 = new Label();
            sortHigh2Low = new RadioButton();
            sortLow2High = new RadioButton();
            sortNone = new RadioButton();
            lblMsg = new Label();
            btnSearch = new Button();
            dtpkrCheckIn = new DateTimePicker();
            txtDuration = new TextBox();
            txtGuest = new TextBox();
            txtSearch = new TextBox();
            lblCheckOut = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dgvHotel = new DataGridView();
            lblSelectedRoomTypeID = new Label();
            btnLogout = new Button();
            btnHistory = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(sortBedH2L);
            panel2.Controls.Add(sortBedNone);
            panel2.Controls.Add(sortBedL2H);
            panel2.Location = new Point(38, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 120);
            panel2.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 9);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 35;
            label5.Text = "Sort By Bed";
            // 
            // sortBedH2L
            // 
            sortBedH2L.AutoSize = true;
            sortBedH2L.Location = new Point(20, 34);
            sortBedH2L.Margin = new Padding(2);
            sortBedH2L.Name = "sortBedH2L";
            sortBedH2L.Size = new Size(113, 24);
            sortBedH2L.TabIndex = 37;
            sortBedH2L.TabStop = true;
            sortBedH2L.Text = "High To Low";
            sortBedH2L.UseVisualStyleBackColor = true;
            // 
            // sortBedNone
            // 
            sortBedNone.AutoSize = true;
            sortBedNone.Location = new Point(20, 90);
            sortBedNone.Margin = new Padding(2);
            sortBedNone.Name = "sortBedNone";
            sortBedNone.Size = new Size(66, 24);
            sortBedNone.TabIndex = 38;
            sortBedNone.TabStop = true;
            sortBedNone.Text = "None";
            sortBedNone.UseVisualStyleBackColor = true;
            // 
            // sortBedL2H
            // 
            sortBedL2H.AutoSize = true;
            sortBedL2H.Location = new Point(20, 62);
            sortBedL2H.Margin = new Padding(2);
            sortBedL2H.Name = "sortBedL2H";
            sortBedL2H.Size = new Size(111, 24);
            sortBedL2H.TabIndex = 36;
            sortBedL2H.TabStop = true;
            sortBedL2H.Text = "Low to High";
            sortBedL2H.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(sortHigh2Low);
            panel1.Controls.Add(sortLow2High);
            panel1.Controls.Add(sortNone);
            panel1.Location = new Point(38, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 128);
            panel1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 22;
            label2.Text = "Sort By Prices";
            // 
            // sortHigh2Low
            // 
            sortHigh2Low.AutoSize = true;
            sortHigh2Low.Location = new Point(17, 33);
            sortHigh2Low.Margin = new Padding(2);
            sortHigh2Low.Name = "sortHigh2Low";
            sortHigh2Low.Size = new Size(113, 24);
            sortHigh2Low.TabIndex = 30;
            sortHigh2Low.TabStop = true;
            sortHigh2Low.Text = "High To Low";
            sortHigh2Low.UseVisualStyleBackColor = true;
            // 
            // sortLow2High
            // 
            sortLow2High.AutoSize = true;
            sortLow2High.Location = new Point(17, 61);
            sortLow2High.Margin = new Padding(2);
            sortLow2High.Name = "sortLow2High";
            sortLow2High.Size = new Size(111, 24);
            sortLow2High.TabIndex = 30;
            sortLow2High.TabStop = true;
            sortLow2High.Text = "Low to High";
            sortLow2High.UseVisualStyleBackColor = true;
            // 
            // sortNone
            // 
            sortNone.AutoSize = true;
            sortNone.Location = new Point(17, 89);
            sortNone.Margin = new Padding(2);
            sortNone.Name = "sortNone";
            sortNone.Size = new Size(66, 24);
            sortNone.TabIndex = 33;
            sortNone.TabStop = true;
            sortNone.Text = "None";
            sortNone.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(344, 164);
            lblMsg.Margin = new Padding(2, 0, 2, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 54;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(778, 164);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(219, 46);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Search Hotels";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpkrCheckIn
            // 
            dtpkrCheckIn.CustomFormat = "dd/MM/yyyy";
            dtpkrCheckIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkrCheckIn.Format = DateTimePickerFormat.Custom;
            dtpkrCheckIn.Location = new Point(36, 108);
            dtpkrCheckIn.Margin = new Padding(2);
            dtpkrCheckIn.Name = "dtpkrCheckIn";
            dtpkrCheckIn.Size = new Size(160, 30);
            dtpkrCheckIn.TabIndex = 52;
            dtpkrCheckIn.ValueChanged += dtpkrCheckIn_ValueChanged;
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(344, 110);
            txtDuration.Margin = new Padding(2, 1, 2, 1);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(160, 30);
            txtDuration.TabIndex = 49;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // txtGuest
            // 
            txtGuest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuest.Location = new Point(841, 110);
            txtGuest.Margin = new Padding(2, 1, 2, 1);
            txtGuest.Name = "txtGuest";
            txtGuest.Size = new Size(156, 30);
            txtGuest.TabIndex = 50;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(36, 46);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(963, 30);
            txtSearch.TabIndex = 51;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckOut.Location = new Point(586, 115);
            lblCheckOut.Margin = new Padding(2, 0, 2, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(165, 25);
            lblCheckOut.TabIndex = 43;
            lblCheckOut.Text = "Mon, 4 April 2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(586, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 44;
            label1.Text = "Check-out";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(344, 88);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 45;
            label8.Text = "Duration";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(36, 89);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 46;
            label9.Text = "Check-in";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(839, 89);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 47;
            label11.Text = "Guests";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(38, 24);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(205, 20);
            label12.TabIndex = 48;
            label12.Text = "City, Location or Hotel Name\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(38, 200);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(964, 28);
            label13.TabIndex = 42;
            label13.Text = "_______________________________________________________________________________________________________________________";
            // 
            // dgvHotel
            // 
            dgvHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHotel.Location = new Point(201, 235);
            dgvHotel.Margin = new Padding(2);
            dgvHotel.Name = "dgvHotel";
            dgvHotel.RowHeadersWidth = 82;
            dgvHotel.RowTemplate.Height = 41;
            dgvHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHotel.Size = new Size(796, 442);
            dgvHotel.TabIndex = 41;
            dgvHotel.CellContentClick += dgvHotel_CellContentClick;
            // 
            // lblSelectedRoomTypeID
            // 
            lblSelectedRoomTypeID.AutoSize = true;
            lblSelectedRoomTypeID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedRoomTypeID.Location = new Point(221, 645);
            lblSelectedRoomTypeID.Margin = new Padding(2, 0, 2, 0);
            lblSelectedRoomTypeID.Name = "lblSelectedRoomTypeID";
            lblSelectedRoomTypeID.Size = new Size(0, 20);
            lblSelectedRoomTypeID.TabIndex = 55;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(255, 128, 0);
            btnLogout.Location = new Point(38, 171);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 39);
            btnLogout.TabIndex = 58;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.White;
            btnHistory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.FromArgb(255, 128, 0);
            btnHistory.Location = new Point(178, 171);
            btnHistory.Margin = new Padding(2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(94, 39);
            btnHistory.TabIndex = 59;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 699);
            Controls.Add(btnHistory);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblMsg);
            Controls.Add(btnSearch);
            Controls.Add(dtpkrCheckIn);
            Controls.Add(txtDuration);
            Controls.Add(txtGuest);
            Controls.Add(txtSearch);
            Controls.Add(lblCheckOut);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(dgvHotel);
            Controls.Add(lblSelectedRoomTypeID);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private RadioButton sortBedH2L;
        private RadioButton sortBedNone;
        private RadioButton sortBedL2H;
        private Panel panel1;
        private Label label2;
        private RadioButton sortHigh2Low;
        private RadioButton sortLow2High;
        private RadioButton sortNone;
        private Label lblMsg;
        private Button btnSearch;
        private DateTimePicker dtpkrCheckIn;
        private TextBox txtDuration;
        private TextBox txtGuest;
        private TextBox txtSearch;
        private Label lblCheckOut;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dgvHotel;
        private Label lblSelectedRoomTypeID;
        private Button btnLogout;
        private Button btnHistory;
    }
}