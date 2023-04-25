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
    public partial class ManagerBookingMangement : Form
    {
        class MyViewModel
        {
            public int BookingID { get; set; }
            public int UserID { get; set; }
            public int RoomID { get; set; }

            public DateTime CheckInDate { get; set; }

            public DateTime CheckOutTime { get; set; }

            public decimal TotalPrice { get; set; }

            public string RoomType { get; set; }

            //UserInfo
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

            private Booking _obj;
            private MyLibrary.Models.Booking e;

            public MyViewModel(MyLibrary.Models.Booking e)
            {
                this.e = e;
            }

            public Booking GetModel()
            {
                return _obj;
            }
        }
        BindingSource source;
        IBookingRepository bookingRepository = new BookingRepository();

        public int HotelID { get; set; } = 1;
        public ManagerBookingMangement()
        {
            InitializeComponent();
        }

        private void ManagerBookingMangement_Load(object sender, EventArgs e)
        {
            LoadBookingList();
            txtBookingID.Enabled = false;
            txtUserID.Enabled = false;
            txtRoomID.Enabled = false;
            txtCheckin.Enabled = false;
            txtCheckout.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtStatus.Enabled = false;
            dgvBookingList.CellDoubleClick += dgvBookingList_CellDoubleClick;
        }
        private void dgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
        private void LoadBookingList()
        {
            var bookings = bookingRepository.ManagerGetBookingsByHotelID(HotelID);
            TryBindBookingList(bookings);
        }
        private void TryBindBookingList(IEnumerable<Booking> bookings)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = bookings;

                txtBookingID.DataBindings.Clear();
                txtUserID.DataBindings.Clear();
                txtRoomID.DataBindings.Clear();
                txtCheckin.DataBindings.Clear();
                txtCheckout.DataBindings.Clear();
                txtTotalPrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtBookingID.DataBindings.Add("Text", source, "BookingID");
                txtUserID.DataBindings.Add("Text", source, "UserID");
                txtRoomID.DataBindings.Add("Text", source, "RoomID");
                txtCheckin.DataBindings.Add("Text", source, "CheckInDate");
                txtCheckout.DataBindings.Add("Text", source, "CheckOutDate");
                txtTotalPrice.DataBindings.Add("Text", source, "TotalPrice");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvBookingList.DataSource = null;
                dgvBookingList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 
    }
}
