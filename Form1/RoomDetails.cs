using Microsoft.EntityFrameworkCore.Infrastructure;
using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class RoomDetails : Form
    {
        public IRoomRepository RoomRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Room RoomInfo { get; set; }
        public RoomDetails()
        {
            InitializeComponent();
        }

        private void RoomDetails_Load(object sender, EventArgs e)
        {
            txtRoomID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtRoomID.Text = RoomInfo.RoomId.ToString();
                txtRoomNumber.Text = RoomInfo.RoomNumber.ToString();
                cboRoomType.SelectedIndex = (int)RoomInfo.RoomTypeId - 1;
                if (RoomInfo.Status.Equals("active"))
                {
                    cboStatus.SelectedIndex = 0;
                }
                else
                {
                    cboStatus.SelectedIndex = 1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var room = new Room
                {
                    RoomId = int.Parse(txtRoomID.Text),
                    RoomNumber = txtRoomNumber.Text,
                    RoomTypeId = cboRoomType.SelectedIndex + 1,
                    Status = cboStatus.Text,
                };
                if (InsertOrUpdate == false)
                {
                    RoomRepository.AddRoom(room);
                }
                else
                {
                    RoomRepository.UpdateRoom(room);
                    MessageBox.Show(cboStatus.SelectedText);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
