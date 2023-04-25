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
    public partial class RoomTypeDetails : Form
    {
        public RoomTypeDetails()
        {
            InitializeComponent();
        }
        public IRoomTypeRepository RoomTypeRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public int HotelID { get; set; }
        public RoomType RoomTypeInfo { get; set; }

        private void RoomTypeDetails_Load(object sender, EventArgs e)
        {
            txtRoomTypeID.Enabled = !InsertOrUpdate;
            txtHotelID.Text = HotelID.ToString();
            txtHotelID.Enabled = false;
            int newRoomTypeID = RoomTypeRepository.GetRoomTypes().Count() + 1;
            var o = RoomTypeRepository.GetRoomTypeByID(newRoomTypeID);
            while (o != null)
            {
                newRoomTypeID += 1;
                o = RoomTypeRepository.GetRoomTypeByID(newRoomTypeID);
            }
            txtRoomTypeID.Text = newRoomTypeID.ToString();
            txtRoomTypeID.Enabled = false;
            if (InsertOrUpdate == true)
            {

                txtRoomTypeID.Text = RoomTypeInfo.RoomTypeId.ToString();
                txtRoomTypeName.Text = RoomTypeInfo.RoomTypeName.ToString();
                txtDescription.Text = RoomTypeInfo.Description;
                txtCapacity.Text = RoomTypeInfo.Capacity.ToString();
                txtBedCount.Text = RoomTypeInfo.BedCount.ToString();
                txtTotalPrice.Text = RoomTypeInfo.Price.ToString();
                if (RoomTypeInfo.Status.Equals("active"))
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
                var roomType = new RoomType
                {
                    RoomTypeId = int.Parse(txtRoomTypeID.Text),
                    RoomTypeName = txtRoomTypeName.Text,
                    Description = txtDescription.Text,
                    Capacity = int.Parse(txtCapacity.Text),
                    BedCount = int.Parse(txtBedCount.Text),
                    Price = decimal.Parse(txtTotalPrice.Text),
                    HotelId = HotelID,
                    Status = "active",
                };
                if (InsertOrUpdate == false)
                {
                    RoomTypeRepository.AddRoomType(roomType);
                }
                else
                {
                    RoomTypeRepository.UpdateRoomType(roomType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new room type" : "Update room type");
            }
        }
    }
}
