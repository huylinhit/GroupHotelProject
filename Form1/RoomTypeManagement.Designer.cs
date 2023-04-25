namespace Form1
{
    partial class RoomTypeManagement
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
            txtHotelID = new TextBox();
            label24 = new Label();
            txtStatus = new TextBox();
            label16 = new Label();
            txtTotalPrice = new TextBox();
            label17 = new Label();
            txtBedCount = new TextBox();
            label18 = new Label();
            txtCapacity = new TextBox();
            label19 = new Label();
            txtDescription = new TextBox();
            label20 = new Label();
            txtRoomTypeName = new TextBox();
            label21 = new Label();
            txtRoomTypeID = new TextBox();
            label22 = new Label();
            label23 = new Label();
            txtSearch = new TextBox();
            cboSearch = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvRoomTypeList = new DataGridView();
            cboFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            SuspendLayout();
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(130, 458);
            txtHotelID.Margin = new Padding(2, 2, 2, 2);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(135, 27);
            txtHotelID.TabIndex = 80;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(25, 462);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(65, 20);
            label24.TabIndex = 70;
            label24.Text = "Hotel ID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(130, 412);
            txtStatus.Margin = new Padding(2, 2, 2, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(135, 27);
            txtStatus.TabIndex = 79;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 416);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 71;
            label16.Text = "Status";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(130, 364);
            txtTotalPrice.Margin = new Padding(2, 2, 2, 2);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(135, 27);
            txtTotalPrice.TabIndex = 82;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 369);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(78, 20);
            label17.TabIndex = 72;
            label17.Text = "Total Price";
            // 
            // txtBedCount
            // 
            txtBedCount.Location = new Point(130, 319);
            txtBedCount.Margin = new Padding(2, 2, 2, 2);
            txtBedCount.Name = "txtBedCount";
            txtBedCount.Size = new Size(135, 27);
            txtBedCount.TabIndex = 81;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 323);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(78, 20);
            label18.TabIndex = 73;
            label18.Text = "Bed Count";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(130, 274);
            txtCapacity.Margin = new Padding(2, 2, 2, 2);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(135, 27);
            txtCapacity.TabIndex = 83;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 279);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 74;
            label19.Text = "Capacity";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(130, 183);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(135, 75);
            txtDescription.TabIndex = 84;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(25, 188);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(85, 20);
            label20.TabIndex = 75;
            label20.Text = "Description";
            // 
            // txtRoomTypeName
            // 
            txtRoomTypeName.Location = new Point(130, 140);
            txtRoomTypeName.Margin = new Padding(2, 2, 2, 2);
            txtRoomTypeName.Name = "txtRoomTypeName";
            txtRoomTypeName.Size = new Size(135, 27);
            txtRoomTypeName.TabIndex = 85;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(25, 144);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(84, 20);
            label21.TabIndex = 76;
            label21.Text = "Room Type";
            // 
            // txtRoomTypeID
            // 
            txtRoomTypeID.Location = new Point(130, 99);
            txtRoomTypeID.Margin = new Padding(2, 2, 2, 2);
            txtRoomTypeID.Name = "txtRoomTypeID";
            txtRoomTypeID.Size = new Size(135, 27);
            txtRoomTypeID.TabIndex = 86;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.DodgerBlue;
            label22.Location = new Point(25, 32);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(231, 28);
            label22.TabIndex = 77;
            label22.Text = "Room Type Management";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(25, 104);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(103, 20);
            label23.TabIndex = 78;
            label23.Text = "Room Type ID";
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.Silver;
            txtSearch.Location = new Point(433, 32);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 27);
            txtSearch.TabIndex = 69;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Room Type", "Capacity", "Bed Count" });
            cboSearch.Location = new Point(287, 32);
            cboSearch.Margin = new Padding(2, 2, 2, 2);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(144, 28);
            cboSearch.TabIndex = 68;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Location = new Point(553, 29);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 29);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(926, 28);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 29);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1022, 28);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 29);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.Location = new Point(287, 62);
            dgvRoomTypeList.Margin = new Padding(2, 2, 2, 2);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.RowHeadersWidth = 82;
            dgvRoomTypeList.RowTemplate.Height = 41;
            dgvRoomTypeList.Size = new Size(827, 488);
            dgvRoomTypeList.TabIndex = 63;
            dgvRoomTypeList.CellDoubleClick += dgvRoomTypeList_CellDoubleClick;
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(779, 30);
            cboFilter.Margin = new Padding(2, 2, 2, 2);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(144, 28);
            cboFilter.TabIndex = 87;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // RoomTypeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 571);
            Controls.Add(cboFilter);
            Controls.Add(txtHotelID);
            Controls.Add(label24);
            Controls.Add(txtStatus);
            Controls.Add(label16);
            Controls.Add(txtTotalPrice);
            Controls.Add(label17);
            Controls.Add(txtBedCount);
            Controls.Add(label18);
            Controls.Add(txtCapacity);
            Controls.Add(label19);
            Controls.Add(txtDescription);
            Controls.Add(label20);
            Controls.Add(txtRoomTypeName);
            Controls.Add(label21);
            Controls.Add(txtRoomTypeID);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvRoomTypeList);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RoomTypeManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomTypeManagement";
            Load += RoomTypeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHotelID;
        private Label label24;
        private TextBox txtStatus;
        private Label label16;
        private TextBox txtTotalPrice;
        private Label label17;
        private TextBox txtBedCount;
        private Label label18;
        private TextBox txtCapacity;
        private Label label19;
        private TextBox txtDescription;
        private Label label20;
        private TextBox txtRoomTypeName;
        private Label label21;
        private TextBox txtRoomTypeID;
        private Label label22;
        private Label label23;
        private TextBox txtSearch;
        private ComboBox cboSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvRoomTypeList;
        private ComboBox cboFilter;
    }
}