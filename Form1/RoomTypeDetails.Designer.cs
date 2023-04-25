namespace Form1
{
    partial class RoomTypeDetails
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
            label23 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cboStatus = new ComboBox();
            SuspendLayout();
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(255, 46);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(309, 39);
            txtHotelID.TabIndex = 96;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(42, 53);
            label24.Name = "label24";
            label24.Size = new Size(102, 32);
            label24.TabIndex = 87;
            label24.Text = "Hotel ID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(42, 546);
            label16.Name = "label16";
            label16.Size = new Size(78, 32);
            label16.TabIndex = 88;
            label16.Text = "Status";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(255, 463);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(309, 39);
            txtTotalPrice.TabIndex = 98;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(42, 470);
            label17.Name = "label17";
            label17.Size = new Size(123, 32);
            label17.TabIndex = 89;
            label17.Text = "Total Price";
            // 
            // txtBedCount
            // 
            txtBedCount.Location = new Point(255, 390);
            txtBedCount.Name = "txtBedCount";
            txtBedCount.Size = new Size(309, 39);
            txtBedCount.TabIndex = 97;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(42, 397);
            label18.Name = "label18";
            label18.Size = new Size(127, 32);
            label18.TabIndex = 90;
            label18.Text = "Bed Count";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(255, 319);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(309, 39);
            txtCapacity.TabIndex = 99;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(42, 326);
            label19.Name = "label19";
            label19.Size = new Size(104, 32);
            label19.TabIndex = 91;
            label19.Text = "Capacity";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(255, 247);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(309, 39);
            txtDescription.TabIndex = 100;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(42, 254);
            label20.Name = "label20";
            label20.Size = new Size(135, 32);
            label20.TabIndex = 92;
            label20.Text = "Description";
            // 
            // txtRoomTypeName
            // 
            txtRoomTypeName.Location = new Point(255, 178);
            txtRoomTypeName.Name = "txtRoomTypeName";
            txtRoomTypeName.Size = new Size(309, 39);
            txtRoomTypeName.TabIndex = 101;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(42, 185);
            label21.Name = "label21";
            label21.Size = new Size(134, 32);
            label21.TabIndex = 93;
            label21.Text = "Room Type";
            // 
            // txtRoomTypeID
            // 
            txtRoomTypeID.Location = new Point(255, 113);
            txtRoomTypeID.Name = "txtRoomTypeID";
            txtRoomTypeID.Size = new Size(309, 39);
            txtRoomTypeID.TabIndex = 102;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(42, 120);
            label23.Name = "label23";
            label23.Size = new Size(164, 32);
            label23.TabIndex = 94;
            label23.Text = "Room Type ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(432, 708);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 103;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(276, 708);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 103;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "active\t", "inactive" });
            cboStatus.Location = new Point(255, 538);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(309, 40);
            cboStatus.TabIndex = 104;
            // 
            // RoomTypeDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 807);
            Controls.Add(cboStatus);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtHotelID);
            Controls.Add(label24);
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
            Controls.Add(label23);
            Name = "RoomTypeDetails";
            Text = "RoomTypeDetails";
            Load += RoomTypeDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHotelID;
        private Label label24;
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
        private Label label23;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cboStatus;
    }
}