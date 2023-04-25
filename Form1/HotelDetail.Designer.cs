namespace HotelBooking
{
    partial class HotelDetail
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
            components = new System.ComponentModel.Container();
            lblHotelName = new Label();
            lblHotelLocation = new Label();
            lblHotelEmail = new Label();
            label4 = new Label();
            label5 = new Label();
            lblHotelPhoneNumber = new Label();
            label7 = new Label();
            label13 = new Label();
            dgvRoom = new DataGridView();
            label8 = new Label();
            lblHotelPolicy = new Label();
            lblHotelContactPerson = new Label();
            label11 = new Label();
            label12 = new Label();
            lblRoomTypeDes = new Label();
            label15 = new Label();
            lblRoomTypeCapacity = new Label();
            lblRoomTypeBedCount = new Label();
            label18 = new Label();
            lblRoomType = new Label();
            label20 = new Label();
            lblRoomTypePrice = new Label();
            toolTip1 = new ToolTip(components);
            btnBook = new Button();
            asd = new Label();
            lblRoomNumber = new Label();
            lblRoomID = new Label();
            lblMsg = new Label();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblHotelName.ForeColor = Color.DodgerBlue;
            lblHotelName.Location = new Point(40, 36);
            lblHotelName.Margin = new Padding(2, 0, 2, 0);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(201, 30);
            lblHotelName.TabIndex = 0;
            lblHotelName.Text = "The Five Star Hotel";
            // 
            // lblHotelLocation
            // 
            lblHotelLocation.AutoSize = true;
            lblHotelLocation.ForeColor = Color.FromArgb(64, 64, 64);
            lblHotelLocation.Location = new Point(114, 81);
            lblHotelLocation.Margin = new Padding(2, 0, 2, 0);
            lblHotelLocation.Name = "lblHotelLocation";
            lblHotelLocation.Size = new Size(597, 20);
            lblHotelLocation.TabIndex = 1;
            lblHotelLocation.Text = "Hoa Hai, Ngu Hanh Son, Hoa Hai Ward, Ngu Hanh Son District, Da Nang, Vietnam, 50000";
            // 
            // lblHotelEmail
            // 
            lblHotelEmail.AutoSize = true;
            lblHotelEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblHotelEmail.Location = new Point(114, 113);
            lblHotelEmail.Margin = new Padding(2, 0, 2, 0);
            lblHotelEmail.Name = "lblHotelEmail";
            lblHotelEmail.Size = new Size(154, 20);
            lblHotelEmail.TabIndex = 1;
            lblHotelEmail.Text = "info@grandhotel.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 2;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // lblHotelPhoneNumber
            // 
            lblHotelPhoneNumber.AutoSize = true;
            lblHotelPhoneNumber.ForeColor = Color.FromArgb(64, 64, 64);
            lblHotelPhoneNumber.Location = new Point(114, 147);
            lblHotelPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblHotelPhoneNumber.Name = "lblHotelPhoneNumber";
            lblHotelPhoneNumber.Size = new Size(71, 20);
            lblHotelPhoneNumber.TabIndex = 1;
            lblHotelPhoneNumber.Text = "555-1234";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 147);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 2;
            label7.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(46, 167);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(860, 28);
            label13.TabIndex = 11;
            label13.Text = "__________________________________________________________________________________________________________";
            // 
            // dgvRoom
            // 
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Location = new Point(375, 206);
            dgvRoom.Margin = new Padding(2);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.RowHeadersWidth = 82;
            dgvRoom.RowTemplate.Height = 41;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoom.Size = new Size(515, 270);
            dgvRoom.TabIndex = 12;
            dgvRoom.CellContentClick += dgvRoom_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(457, 147);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 2;
            label8.Text = "Cancellation Policy";
            // 
            // lblHotelPolicy
            // 
            lblHotelPolicy.AutoSize = true;
            lblHotelPolicy.ForeColor = Color.FromArgb(64, 64, 64);
            lblHotelPolicy.Location = new Point(594, 147);
            lblHotelPolicy.Margin = new Padding(2, 0, 2, 0);
            lblHotelPolicy.Name = "lblHotelPolicy";
            lblHotelPolicy.Size = new Size(172, 20);
            lblHotelPolicy.TabIndex = 1;
            lblHotelPolicy.Text = "24 hours before check-in";
            // 
            // lblHotelContactPerson
            // 
            lblHotelContactPerson.AutoSize = true;
            lblHotelContactPerson.ForeColor = Color.FromArgb(64, 64, 64);
            lblHotelContactPerson.Location = new Point(594, 113);
            lblHotelContactPerson.Margin = new Padding(2, 0, 2, 0);
            lblHotelContactPerson.Name = "lblHotelContactPerson";
            lblHotelContactPerson.Size = new Size(71, 20);
            lblHotelContactPerson.TabIndex = 1;
            lblHotelContactPerson.Text = "John Doe";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(457, 113);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 2;
            label11.Text = "Contact Person";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(46, 261);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 2;
            label12.Text = "Description";
            // 
            // lblRoomTypeDes
            // 
            lblRoomTypeDes.Location = new Point(46, 281);
            lblRoomTypeDes.Margin = new Padding(2, 0, 2, 0);
            lblRoomTypeDes.Name = "lblRoomTypeDes";
            lblRoomTypeDes.Size = new Size(299, 41);
            lblRoomTypeDes.TabIndex = 1;
            lblRoomTypeDes.Text = "A basic room with a queen-size bed and a TV.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(46, 335);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 2;
            label15.Text = "Capacity";
            // 
            // lblRoomTypeCapacity
            // 
            lblRoomTypeCapacity.AutoSize = true;
            lblRoomTypeCapacity.Location = new Point(46, 355);
            lblRoomTypeCapacity.Margin = new Padding(2, 0, 2, 0);
            lblRoomTypeCapacity.Name = "lblRoomTypeCapacity";
            lblRoomTypeCapacity.Size = new Size(63, 20);
            lblRoomTypeCapacity.TabIndex = 1;
            lblRoomTypeCapacity.Text = "2 guests";
            // 
            // lblRoomTypeBedCount
            // 
            lblRoomTypeBedCount.AutoSize = true;
            lblRoomTypeBedCount.Location = new Point(206, 355);
            lblRoomTypeBedCount.Margin = new Padding(2, 0, 2, 0);
            lblRoomTypeBedCount.Name = "lblRoomTypeBedCount";
            lblRoomTypeBedCount.Size = new Size(115, 20);
            lblRoomTypeBedCount.TabIndex = 1;
            lblRoomTypeBedCount.Text = "1 standard beds";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(206, 335);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(35, 20);
            label18.TabIndex = 2;
            label18.Text = "Bed";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(46, 226);
            lblRoomType.Margin = new Padding(2, 0, 2, 0);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(69, 20);
            lblRoomType.TabIndex = 1;
            lblRoomType.Text = "Standard";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(46, 206);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(83, 20);
            label20.TabIndex = 2;
            label20.Text = "Room type";
            // 
            // lblRoomTypePrice
            // 
            lblRoomTypePrice.AutoSize = true;
            lblRoomTypePrice.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomTypePrice.ForeColor = Color.FromArgb(255, 128, 0);
            lblRoomTypePrice.Location = new Point(209, 391);
            lblRoomTypePrice.Margin = new Padding(2, 0, 2, 0);
            lblRoomTypePrice.Name = "lblRoomTypePrice";
            lblRoomTypePrice.Size = new Size(140, 30);
            lblRoomTypePrice.TabIndex = 13;
            lblRoomTypePrice.Text = "100.000 VND";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(255, 128, 0);
            btnBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(213, 437);
            btnBook.Margin = new Padding(2);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(136, 39);
            btnBook.TabIndex = 14;
            btnBook.Text = "Book Now!";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // asd
            // 
            asd.AutoSize = true;
            asd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            asd.Location = new Point(209, 206);
            asd.Margin = new Padding(2, 0, 2, 0);
            asd.Name = "asd";
            asd.Size = new Size(49, 20);
            asd.TabIndex = 16;
            asd.Text = "Room";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(209, 226);
            lblRoomNumber.Margin = new Padding(2, 0, 2, 0);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(60, 20);
            lblRoomNumber.TabIndex = 15;
            lblRoomNumber.Text = "number";
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Location = new Point(857, 522);
            lblRoomID.Margin = new Padding(2, 0, 2, 0);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(0, 20);
            lblRoomID.TabIndex = 17;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsg.Location = new Point(405, 261);
            lblMsg.Margin = new Padding(2, 0, 2, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 399);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 19;
            label1.Text = "Price per night";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(255, 128, 0);
            btnBack.Location = new Point(50, 437);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 39);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // HotelDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 510);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(lblMsg);
            Controls.Add(asd);
            Controls.Add(lblRoomNumber);
            Controls.Add(btnBook);
            Controls.Add(lblRoomTypePrice);
            Controls.Add(dgvRoom);
            Controls.Add(label13);
            Controls.Add(label18);
            Controls.Add(label15);
            Controls.Add(label20);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblHotelContactPerson);
            Controls.Add(lblHotelPhoneNumber);
            Controls.Add(lblRoomTypeBedCount);
            Controls.Add(lblHotelPolicy);
            Controls.Add(lblRoomTypeCapacity);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomTypeDes);
            Controls.Add(lblHotelEmail);
            Controls.Add(lblHotelLocation);
            Controls.Add(lblHotelName);
            Controls.Add(lblRoomID);
            Margin = new Padding(2);
            Name = "HotelDetail";
            Text = "HotelDetail";
            Load += HotelDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHotelName;
        private Label lblHotelLocation;
        private Label lblHotelEmail;
        private Label label4;
        private Label label5;
        private Label lblHotelPhoneNumber;
        private Label label7;
        private Label label13;
        private DataGridView dgvRoom;
        private Label label8;
        private Label lblHotelPolicy;
        private Label lblHotelContactPerson;
        private Label label11;
        private Label label12;
        private Label lblRoomTypeDes;
        private Label label15;
        private Label lblRoomTypeCapacity;
        private Label lblRoomTypeBedCount;
        private Label label18;
        private Label lblRoomType;
        private Label label20;
        private Label lblRoomTypePrice;
        private ToolTip toolTip1;
        private Button btnBook;
        private Label asd;
        private Label lblRoomNumber;
        private Label lblRoomID;
        private Label lblMsg;
        private Label label1;
        private Button btnBack;
    }
}