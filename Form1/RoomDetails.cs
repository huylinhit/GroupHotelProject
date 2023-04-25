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
        public IRoomTypeRepository RoomTypeRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public int HotelID { get; set; } = 1;
        public Room RoomInfo { get; set; }
        public RoomDetails()
        {
            InitializeComponent();
        }

        private void RoomDetails_Load(object sender, EventArgs e)
        {
            txtRoomID.Text = (RoomRepository.GetRooms().Count() + 1).ToString();
            txtRoomID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtRoomID.Text = RoomInfo.RoomId.ToString();
                txtRoomNumber.Text = RoomInfo.RoomNumber.ToString();

                if (RoomInfo.Status.Equals("active"))
                {
                    cboStatus.SelectedIndex = 0;
                }
                else
                {
                    cboStatus.SelectedIndex = 1;
                }
            }
            else if(InsertOrUpdate == false)
            {
                cboStatus.SelectedIndex = 0;
                cboStatus.Enabled = false;
            }
            foreach (var item in RoomTypeRepository.GetRoomTypes()
                .Where(r => r.HotelId == HotelID))
            {
                if (!cboRoomType.Items.Contains(item))
                {
                    cboRoomType.Items.Add(item.RoomTypeName);
                }
            }
            cboRoomType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var roomTypeID = RoomTypeRepository.GetRoomTypeByName(cboRoomType.Text).RoomTypeId;
            try
            {
                var room = new Room
                {
                    RoomId = int.Parse(txtRoomID.Text),
                    RoomNumber = txtRoomNumber.Text,
                    RoomTypeId = roomTypeID,
                    Status = cboStatus.Text,
                };
                if (InsertOrUpdate == false)
                {
                    RoomRepository.AddRoom(room);
                }
                else
                {
                    RoomRepository.UpdateRoom(room);
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
