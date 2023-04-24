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
        public HotelManager()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void HotelManager_Load(object sender, EventArgs e)
        {
            LoadRoomList();
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
                source.DataSource = rooms;

                txtRoomID.DataBindings.Clear();
                txtRoomNumber.DataBindings.Clear();
                txtRoomTypeID.DataBindings.Clear();
                txtAvailable.DataBindings.Clear();
                txtHotelID.DataBindings.Clear();

                txtRoomID.DataBindings.Add("Text", source, "RoomId");
                txtRoomNumber.DataBindings.Add("Text", source, "RoomNumber");
                txtRoomTypeID.DataBindings.Add("Text", source, "RoomTypeId");
                txtAvailable.DataBindings.Add("Text", source, "Status");
                //txtHotelID.DataBindings.Add("Text", source, "HotelId");

                dgvRoomList.DataSource = null;
                dgvRoomList.DataSource = source;
                if (rooms.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
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
    }
}
