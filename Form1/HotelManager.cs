using Form1;
using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class HotelManager : Form
    {
        BindingSource source;
        IRoomRepository roomRepository = new RoomRepository();
        class MyViewModel
        {
            public int HotelId { get; set; }
            public int RoomId { get; set; }
            public string RoomNumber { get; set; }
            public int RoomTypeId { get; set; }
            public string Status { get; set; }
            public string RoomTypeName { get; set; }


            private Room _obj;


            public MyViewModel(Room obj)
            {
                _obj = obj;
            }

            public Room GetModel()
            {
                return _obj;
            }
        }
        public HotelManager()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void HotelManager_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvRoomList.CellDoubleClick += dgvRoomList_CellDoubleClick;
            txtRoomID.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtRoomTypeID.Enabled = false;
            txtRoomType.Enabled = false;
            txtHotelID.Enabled = false;
            LoadRoomList();
        }
        private void dgvRoomList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomDetails roomDetails = new RoomDetails
            {
                Text = "Update Room",
                InsertOrUpdate = true,
                RoomInfo = GetRoom(),
                RoomRepository = roomRepository,
            };
            if (roomDetails.ShowDialog() == DialogResult.OK)
            {
                LoadRoomList();
                source.Position = source.Count - 1;
            }
        }
        private Room GetRoom()
        {
            Room room = null;
            try
            {
                room = new Room
                {
                    RoomId = int.Parse(txtRoomID.Text),
                    RoomNumber = txtRoomNumber.Text,
                    RoomTypeId = int.Parse(txtRoomTypeID.Text),
                    Status = txtAvailable.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return room;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoomDetails roomDetails = new RoomDetails
            {
                Text = "Add Room",
                InsertOrUpdate = false,
                RoomRepository = roomRepository,
            };
            if (roomDetails.DialogResult == DialogResult.OK)
            {
                LoadRoomList();
                source.Position = source.Count - 1;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var room = GetRoom();
                roomRepository.DeleteRoom(room.RoomId);
                LoadRoomList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot Delete a product");
            }
        }
        private void LoadRoomList()
        {
            var rooms = roomRepository.GetRoomsByID(1);
            TryBindRoomList(rooms);
        }
        private void TryBindRoomList(IEnumerable<Room> rooms)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = rooms.Select(o => new MyViewModel(o)
                {
                    HotelId = (int)o.RoomType.HotelId,
                    RoomId = o.RoomId,
                    RoomNumber = o.RoomNumber,
                    RoomTypeId = (int)o.RoomTypeId,
                    RoomTypeName = o.RoomType.RoomTypeName,
                    Status = o.Status

                }).ToList();

                txtRoomID.DataBindings.Clear();
                txtRoomNumber.DataBindings.Clear();
                txtRoomTypeID.DataBindings.Clear();
                txtAvailable.DataBindings.Clear();
                txtRoomType.DataBindings.Clear();

                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtRoomNumber.DataBindings.Add("Text", source, "RoomNumber");
                txtRoomTypeID.DataBindings.Add("Text", source, "RoomTypeId");
                txtAvailable.DataBindings.Add("Text", source, "Status");
                txtRoomType.DataBindings.Add("Text", source, "RoomTypeName");

                dgvRoomList.DataSource = null;
                dgvRoomList.DataSource = source;


                if (rooms.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    ClearText();
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearText()
        {
            txtRoomID.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRoomTypeID.Text = string.Empty;
            txtAvailable.Text = string.Empty;
            txtHotelID.Text = string.Empty;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
