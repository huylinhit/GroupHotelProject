namespace Form1
{
    partial class RoomDetails
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
            txtRoomNumber = new TextBox();
            label2 = new Label();
            txtRoomID = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cboRoomType = new ComboBox();
            label4 = new Label();
            cboStatus = new ComboBox();
            SuspendLayout();
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(314, 219);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(275, 39);
            txtRoomNumber.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 226);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 27;
            label2.Text = "Room Number";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(314, 154);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(275, 39);
            txtRoomID.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(98, 37);
            label6.Name = "label6";
            label6.Size = new Size(209, 45);
            label6.TabIndex = 28;
            label6.Text = "Room Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 161);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 29;
            label1.Text = "Room ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 303);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 26;
            label3.Text = "Room Type  ";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.OK;
            btnClose.Location = new Point(439, 474);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(283, 474);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboRoomType
            // 
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(314, 295);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(275, 40);
            cboRoomType.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 382);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 26;
            label4.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "active", "inactive" });
            cboStatus.Location = new Point(314, 374);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(275, 40);
            cboStatus.TabIndex = 37;
            // 
            // RoomDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 609);
            Controls.Add(cboStatus);
            Controls.Add(cboRoomType);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(txtRoomNumber);
            Controls.Add(label2);
            Controls.Add(txtRoomID);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "RoomDetails";
            Text = "RoomDetails";
            Load += RoomDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRoomNumber;
        private Label label2;
        private TextBox txtRoomID;
        private Label label6;
        private Label label1;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cboRoomType;
        private Label label4;
        private ComboBox cboStatus;
    }
}