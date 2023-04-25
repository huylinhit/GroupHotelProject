namespace Form1
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
            txtStatus = new TextBox();
            label14 = new Label();
            txtTotalPrice = new TextBox();
            label13 = new Label();
            txtCheckout = new TextBox();
            label7 = new Label();
            txtCheckin = new TextBox();
            label8 = new Label();
            txtRoomID = new TextBox();
            label9 = new Label();
            txtUserID = new TextBox();
            label10 = new Label();
            txtHotelID = new TextBox();
            txtBookingID = new TextBox();
            label11 = new Label();
            label16 = new Label();
            label12 = new Label();
            textBox12 = new TextBox();
            comboBox2 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            dgvBookingList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(218, 632);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(217, 39);
            txtStatus.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 639);
            label14.Name = "label14";
            label14.Size = new Size(78, 32);
            label14.TabIndex = 48;
            label14.Text = "Status";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(218, 556);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(217, 39);
            txtTotalPrice.TabIndex = 58;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 563);
            label13.Name = "label13";
            label13.Size = new Size(123, 32);
            label13.TabIndex = 49;
            label13.Text = "Total Price";
            // 
            // txtCheckout
            // 
            txtCheckout.Location = new Point(218, 483);
            txtCheckout.Name = "txtCheckout";
            txtCheckout.Size = new Size(217, 39);
            txtCheckout.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 490);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 50;
            label7.Text = "Check-out";
            // 
            // txtCheckin
            // 
            txtCheckin.Location = new Point(218, 412);
            txtCheckin.Name = "txtCheckin";
            txtCheckin.Size = new Size(217, 39);
            txtCheckin.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 419);
            label8.Name = "label8";
            label8.Size = new Size(109, 32);
            label8.TabIndex = 51;
            label8.Text = "Check-in";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(218, 340);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(217, 39);
            txtRoomID.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 347);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 52;
            label9.Text = "Room ID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(218, 271);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(217, 39);
            txtUserID.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 278);
            label10.Name = "label10";
            label10.Size = new Size(91, 32);
            label10.TabIndex = 53;
            label10.Text = "User ID";
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(218, 135);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(217, 39);
            txtHotelID.TabIndex = 64;
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(218, 206);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(217, 39);
            txtBookingID.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(46, 51);
            label11.Name = "label11";
            label11.Size = new Size(335, 45);
            label11.TabIndex = 54;
            label11.Text = "Booking Management";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(46, 142);
            label16.Name = "label16";
            label16.Size = new Size(102, 32);
            label16.TabIndex = 55;
            label16.Text = "Hotel ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 213);
            label12.Name = "label12";
            label12.Size = new Size(132, 32);
            label12.TabIndex = 56;
            label12.Text = "Booking ID";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(623, 51);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(190, 39);
            textBox12.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(472, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 40);
            comboBox2.TabIndex = 46;
            // 
            // button5
            // 
            button5.Location = new Point(819, 47);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 42;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1760, 44);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 43;
            button6.Text = "Load";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgvBookingList
            // 
            dgvBookingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingList.Location = new Point(472, 99);
            dgvBookingList.Name = "dgvBookingList";
            dgvBookingList.RowHeadersWidth = 82;
            dgvBookingList.RowTemplate.Height = 41;
            dgvBookingList.Size = new Size(1438, 780);
            dgvBookingList.TabIndex = 41;
            dgvBookingList.CellDoubleClick += dgvBookingList_CellDoubleClick;
            // 
            // ManagerBookingMangement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1939, 914);
            Controls.Add(txtStatus);
            Controls.Add(label14);
            Controls.Add(txtTotalPrice);
            Controls.Add(label13);
            Controls.Add(txtCheckout);
            Controls.Add(label7);
            Controls.Add(txtCheckin);
            Controls.Add(label8);
            Controls.Add(txtRoomID);
            Controls.Add(label9);
            Controls.Add(txtUserID);
            Controls.Add(label10);
            Controls.Add(txtHotelID);
            Controls.Add(txtBookingID);
            Controls.Add(label11);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(comboBox2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(dgvBookingList);
            Name = "ManagerBookingMangement";
            Text = "ManagerBookingMangement";
            Load += ManagerBookingMangement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private Label label14;
        private TextBox txtTotalPrice;
        private Label label13;
        private TextBox txtCheckout;
        private Label label7;
        private TextBox txtCheckin;
        private Label label8;
        private TextBox txtRoomID;
        private Label label9;
        private TextBox txtUserID;
        private Label label10;
        private TextBox txtHotelID;
        private TextBox txtBookingID;
        private Label label11;
        private Label label16;
        private Label label12;
        private TextBox textBox12;
        private ComboBox comboBox2;
        private Button button5;
        private Button button6;
        private DataGridView dgvBookingList;
    }
}