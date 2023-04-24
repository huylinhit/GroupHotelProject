﻿namespace HotelBooking
{
    partial class HotelManager
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
            txtHotelID = new TextBox();
            label5 = new Label();
            txtAvailable = new TextBox();
            label4 = new Label();
            txtRoomType = new TextBox();
            label15 = new Label();
            txtRoomTypeID = new TextBox();
            label3 = new Label();
            txtRoomNumber = new TextBox();
            label2 = new Label();
            txtRoomID = new TextBox();
            label6 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvRoomList = new DataGridView();
            tabPage2 = new TabPage();
            textBox14 = new TextBox();
            label14 = new Label();
            textBox13 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox12 = new TextBox();
            comboBox2 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1640, 966);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txtHotelID);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtAvailable);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtRoomType);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtRoomTypeID);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtRoomNumber);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtRoomID);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(btnLoad);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(dgvRoomList);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1624, 912);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Room Management";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(200, 501);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(217, 39);
            txtHotelID.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 508);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 13;
            label5.Text = "Hotel ID";
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(200, 430);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(217, 39);
            txtAvailable.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 437);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 14;
            label4.Text = "Available";
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(200, 366);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(217, 39);
            txtRoomType.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 373);
            label15.Name = "label15";
            label15.Size = new Size(134, 32);
            label15.TabIndex = 15;
            label15.Text = "Room Type";
            // 
            // txtRoomTypeID
            // 
            txtRoomTypeID.Location = new Point(200, 295);
            txtRoomTypeID.Name = "txtRoomTypeID";
            txtRoomTypeID.Size = new Size(217, 39);
            txtRoomTypeID.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 302);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 15;
            label3.Text = "Room Type ID ";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(200, 226);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(217, 39);
            txtRoomNumber.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 233);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 16;
            label2.Text = "Room Number";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(200, 161);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(217, 39);
            txtRoomID.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(28, 53);
            label6.Name = "label6";
            label6.Size = new Size(302, 45);
            label6.TabIndex = 17;
            label6.Text = "Room Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 168);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 17;
            label1.Text = "Room ID";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(605, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 39);
            txtSearch.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(454, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 40);
            comboBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(801, 49);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1132, 46);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 46);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1288, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1444, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvRoomList
            // 
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(454, 101);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.RowHeadersWidth = 82;
            dgvRoomList.RowTemplate.Height = 41;
            dgvRoomList.Size = new Size(1142, 780);
            dgvRoomList.TabIndex = 6;
            dgvRoomList.CellDoubleClick += dgvRoomList_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox14);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1624, 912);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Booking Management";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(200, 580);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(217, 39);
            textBox14.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 587);
            label14.Name = "label14";
            label14.Size = new Size(78, 32);
            label14.TabIndex = 30;
            label14.Text = "Status";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(200, 504);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(217, 39);
            textBox13.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 511);
            label13.Name = "label13";
            label13.Size = new Size(123, 32);
            label13.TabIndex = 30;
            label13.Text = "Total Price";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(200, 431);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(217, 39);
            textBox6.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 438);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 30;
            label7.Text = "Check-out";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 360);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(217, 39);
            textBox7.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 367);
            label8.Name = "label8";
            label8.Size = new Size(109, 32);
            label8.TabIndex = 31;
            label8.Text = "Check-in";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(200, 288);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(217, 39);
            textBox8.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 295);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 32;
            label9.Text = "Room ID";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(200, 219);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(217, 39);
            textBox9.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 226);
            label10.Name = "label10";
            label10.Size = new Size(91, 32);
            label10.TabIndex = 33;
            label10.Text = "User ID";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(200, 154);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(217, 39);
            textBox10.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(28, 46);
            label11.Name = "label11";
            label11.Size = new Size(335, 45);
            label11.TabIndex = 34;
            label11.Text = "Booking Management";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 161);
            label12.Name = "label12";
            label12.Size = new Size(132, 32);
            label12.TabIndex = 35;
            label12.Text = "Booking ID";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(605, 46);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(190, 39);
            textBox12.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(454, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 40);
            comboBox2.TabIndex = 28;
            // 
            // button5
            // 
            button5.Location = new Point(801, 42);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 24;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1132, 39);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 25;
            button6.Text = "Load";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1288, 39);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 26;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1444, 39);
            button8.Name = "button8";
            button8.Size = new Size(150, 46);
            button8.TabIndex = 27;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(454, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.RowTemplate.Height = 41;
            dataGridView2.Size = new Size(1142, 780);
            dataGridView2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 803);
            button1.Name = "button1";
            button1.Size = new Size(389, 78);
            button1.TabIndex = 23;
            button1.Text = "Room Type Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // HotelManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 966);
            Controls.Add(tabControl1);
            Name = "HotelManager";
            Text = "HotelManager";
            Load += HotelManager_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private Button button4;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvRoomList;
        private TextBox txtHotelID;
        private Label label5;
        private TextBox txtAvailable;
        private Label label4;
        private TextBox txtRoomTypeID;
        private Label label3;
        private TextBox txtRoomNumber;
        private Label label2;
        private TextBox txtRoomID;
        private Label label6;
        private Label label1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private Label label12;
        private TextBox textBox12;
        private ComboBox comboBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView2;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox13;
        private Label label13;
        private TextBox txtRoomType;
        private Label label15;
        private Button button1;
    }
}