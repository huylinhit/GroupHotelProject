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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblSelectedRoomTypeID = new Label();
            lblMsg = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSearch = new Button();
            dtpkrCheckIn = new DateTimePicker();
            txtDuration = new TextBox();
            txtGuest = new TextBox();
            txtSearch = new TextBox();
            lblCheckOut = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dgvHotel = new DataGridView();
            textBox10 = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).BeginInit();
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
            tabControl1.Size = new Size(1044, 699);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblSelectedRoomTypeID);
            tabPage1.Controls.Add(lblMsg);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(dtpkrCheckIn);
            tabPage1.Controls.Add(txtDuration);
            tabPage1.Controls.Add(txtGuest);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(lblCheckOut);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(dgvHotel);
            tabPage1.Controls.Add(textBox10);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1036, 666);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Booking";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblSelectedRoomTypeID
            // 
            lblSelectedRoomTypeID.AutoSize = true;
            lblSelectedRoomTypeID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedRoomTypeID.Location = new Point(43, 623);
            lblSelectedRoomTypeID.Margin = new Padding(2, 0, 2, 0);
            lblSelectedRoomTypeID.Name = "lblSelectedRoomTypeID";
            lblSelectedRoomTypeID.Size = new Size(0, 20);
            lblSelectedRoomTypeID.TabIndex = 32;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(349, 149);
            lblMsg.Margin = new Padding(2, 0, 2, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 31;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 314);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 24);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "Lowest Price";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 288);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 30;
            radioButton1.TabStop = true;
            radioButton1.Text = "Highest Price";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(783, 149);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(219, 46);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search Hotels";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpkrCheckIn
            // 
            dtpkrCheckIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkrCheckIn.Format = DateTimePickerFormat.Short;
            dtpkrCheckIn.Location = new Point(41, 93);
            dtpkrCheckIn.Margin = new Padding(2);
            dtpkrCheckIn.Name = "dtpkrCheckIn";
            dtpkrCheckIn.Size = new Size(160, 30);
            dtpkrCheckIn.TabIndex = 28;
            dtpkrCheckIn.ValueChanged += dtpkrCheckIn_ValueChanged;
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(349, 95);
            txtDuration.Margin = new Padding(2, 1, 2, 1);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(160, 30);
            txtDuration.TabIndex = 24;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // txtGuest
            // 
            txtGuest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuest.Location = new Point(846, 95);
            txtGuest.Margin = new Padding(2, 1, 2, 1);
            txtGuest.Name = "txtGuest";
            txtGuest.Size = new Size(156, 30);
            txtGuest.TabIndex = 26;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(41, 31);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(963, 30);
            txtSearch.TabIndex = 27;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckOut.Location = new Point(591, 100);
            lblCheckOut.Margin = new Padding(2, 0, 2, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(165, 25);
            lblCheckOut.TabIndex = 17;
            lblCheckOut.Text = "Mon, 4 April 2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(591, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 18;
            label1.Text = "Check-out";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(349, 73);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 19;
            label8.Text = "Duration";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(41, 74);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 20;
            label9.Text = "Check-in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 338);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 22;
            label3.Text = "___________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 252);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 22;
            label2.Text = "Sort Results";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(844, 74);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 22;
            label11.Text = "Guests";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(43, 9);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(205, 20);
            label12.TabIndex = 23;
            label12.Text = "City, Location or Hotel Name\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(43, 185);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(964, 28);
            label13.TabIndex = 10;
            label13.Text = "_______________________________________________________________________________________________________________________";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(564, 215);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 36);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 216);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(115, 36);
            comboBox1.TabIndex = 4;
            // 
            // dgvHotel
            // 
            dgvHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHotel.Location = new Point(206, 256);
            dgvHotel.Margin = new Padding(2);
            dgvHotel.Name = "dgvHotel";
            dgvHotel.RowHeadersWidth = 82;
            dgvHotel.RowTemplate.Height = 41;
            dgvHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHotel.Size = new Size(796, 406);
            dgvHotel.TabIndex = 1;
            dgvHotel.CellContentClick += dgvHotel_CellContentClick;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(323, 216);
            textBox10.Margin = new Padding(2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(152, 34);
            textBox10.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1036, 666);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 699);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DataGridView dgvHotel;
        private TextBox textBox10;
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label2;
        private Label lblMsg;
        private Label lblSelectedRoomTypeID;
    }
}