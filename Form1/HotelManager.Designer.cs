namespace HotelBooking
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
            cboFilter = new ComboBox();
            btnBookingManagement = new Button();
            btnRoomTypeManagement = new Button();
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
            cboSearch = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvRoomList = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1825, 953);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboFilter);
            tabPage1.Controls.Add(btnBookingManagement);
            tabPage1.Controls.Add(btnRoomTypeManagement);
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
            tabPage1.Controls.Add(cboSearch);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(dgvRoomList);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1809, 899);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Room Management";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(1228, 50);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(242, 40);
            cboFilter.TabIndex = 24;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // btnBookingManagement
            // 
            btnBookingManagement.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnBookingManagement.Location = new Point(28, 772);
            btnBookingManagement.Name = "btnBookingManagement";
            btnBookingManagement.Size = new Size(389, 78);
            btnBookingManagement.TabIndex = 23;
            btnBookingManagement.Text = "Booking Management";
            btnBookingManagement.UseVisualStyleBackColor = true;
            btnBookingManagement.Click += btnBookingManagement_Click;
            // 
            // btnRoomTypeManagement
            // 
            btnRoomTypeManagement.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoomTypeManagement.Location = new Point(28, 688);
            btnRoomTypeManagement.Name = "btnRoomTypeManagement";
            btnRoomTypeManagement.Size = new Size(389, 78);
            btnRoomTypeManagement.TabIndex = 23;
            btnRoomTypeManagement.Text = "Room Type Management";
            btnRoomTypeManagement.UseVisualStyleBackColor = true;
            btnRoomTypeManagement.Click += btnRoomTypeManagement_Click;
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
            txtSearch.ForeColor = Color.Silver;
            txtSearch.Location = new Point(663, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 39);
            txtSearch.TabIndex = 12;
            txtSearch.Text = "search";
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Room Number", "Room Type", "Status" });
            cboSearch.Location = new Point(454, 53);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(203, 40);
            cboSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(859, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 46);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1476, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1632, 46);
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
            dgvRoomList.Size = new Size(1328, 780);
            dgvRoomList.TabIndex = 6;
            dgvRoomList.CellDoubleClick += dgvRoomList_CellDoubleClick;
            // 
            // HotelManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 953);
            Controls.Add(tabControl1);
            Name = "HotelManager";
            Text = "HotelManager";
            Load += HotelManager_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtSearch;
        private ComboBox cboSearch;
        private Button btnSearch;
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
        private TextBox txtRoomType;
        private Label label15;
        private Button btnRoomTypeManagement;
        private Button btnBookingManagement;
        private ComboBox cboFilter;
    }
}