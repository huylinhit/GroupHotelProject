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
            textBox16 = new TextBox();
            comboBox3 = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvRoomTypeList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            SuspendLayout();
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(212, 733);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(217, 39);
            txtHotelID.TabIndex = 80;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(40, 740);
            label24.Name = "label24";
            label24.Size = new Size(102, 32);
            label24.TabIndex = 70;
            label24.Text = "Hotel ID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(212, 659);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(217, 39);
            txtStatus.TabIndex = 79;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(40, 666);
            label16.Name = "label16";
            label16.Size = new Size(78, 32);
            label16.TabIndex = 71;
            label16.Text = "Status";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(212, 583);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(217, 39);
            txtTotalPrice.TabIndex = 82;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(40, 590);
            label17.Name = "label17";
            label17.Size = new Size(123, 32);
            label17.TabIndex = 72;
            label17.Text = "Total Price";
            // 
            // txtBedCount
            // 
            txtBedCount.Location = new Point(212, 510);
            txtBedCount.Name = "txtBedCount";
            txtBedCount.Size = new Size(217, 39);
            txtBedCount.TabIndex = 81;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(40, 517);
            label18.Name = "label18";
            label18.Size = new Size(127, 32);
            label18.TabIndex = 73;
            label18.Text = "Bed Count";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(212, 439);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(217, 39);
            txtCapacity.TabIndex = 83;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(40, 446);
            label19.Name = "label19";
            label19.Size = new Size(104, 32);
            label19.TabIndex = 74;
            label19.Text = "Capacity";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(212, 293);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(217, 117);
            txtDescription.TabIndex = 84;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(40, 300);
            label20.Name = "label20";
            label20.Size = new Size(135, 32);
            label20.TabIndex = 75;
            label20.Text = "Description";
            // 
            // txtRoomTypeName
            // 
            txtRoomTypeName.Location = new Point(212, 224);
            txtRoomTypeName.Name = "txtRoomTypeName";
            txtRoomTypeName.Size = new Size(217, 39);
            txtRoomTypeName.TabIndex = 85;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(40, 231);
            label21.Name = "label21";
            label21.Size = new Size(134, 32);
            label21.TabIndex = 76;
            label21.Text = "Room Type";
            // 
            // txtRoomTypeID
            // 
            txtRoomTypeID.Location = new Point(212, 159);
            txtRoomTypeID.Name = "txtRoomTypeID";
            txtRoomTypeID.Size = new Size(217, 39);
            txtRoomTypeID.TabIndex = 86;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.DodgerBlue;
            label22.Location = new Point(40, 51);
            label22.Name = "label22";
            label22.Size = new Size(377, 45);
            label22.TabIndex = 77;
            label22.Text = "Room Type Management";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(40, 166);
            label23.Name = "label23";
            label23.Size = new Size(164, 32);
            label23.TabIndex = 78;
            label23.Text = "Room Type ID";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(617, 51);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(190, 39);
            textBox16.TabIndex = 69;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(466, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(145, 40);
            comboBox3.TabIndex = 68;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(813, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1504, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1660, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.Location = new Point(466, 99);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.RowHeadersWidth = 82;
            dgvRoomTypeList.RowTemplate.Height = 41;
            dgvRoomTypeList.Size = new Size(1344, 780);
            dgvRoomTypeList.TabIndex = 63;
            dgvRoomTypeList.CellDoubleClick += dgvRoomTypeList_CellDoubleClick;
            // 
            // RoomTypeManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1842, 914);
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
            Controls.Add(textBox16);
            Controls.Add(comboBox3);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvRoomTypeList);
            Name = "RoomTypeManagement";
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
        private TextBox textBox16;
        private ComboBox comboBox3;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvRoomTypeList;
    }
}