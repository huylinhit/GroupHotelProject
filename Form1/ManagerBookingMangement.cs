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

            public string Role { get; set; }
            public string Status { get; set; }

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

        public int HotelID { get; set; }
        public ManagerBookingMangement()
        {
            InitializeComponent();
        }

        private void ManagerBookingMangement_Load(object sender, EventArgs e)
        {
            LoadBookings();
            txtBookingID.Enabled = false;
            txtUserID.Enabled = false;
            dgvBookingList.CellDoubleClick += dgvBookingList_CellDoubleClick;
            cboSearch.SelectedIndex = 0;
        }
        private void dgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ManagerBookingDetails bookingDetails = new ManagerBookingDetails()
            //{
            //    BookingRepository = bookingRepository,
            //    BookingID = int.Parse(txtBookingID.Text)
            //};
            //if (bookingDetails.ShowDialog() == DialogResult.OK)
            //{
            //    LoadBookings();
            //    source.Position = source.Count - 1;
            //}
            BookingManagementDetail bookingManagementDetail = new BookingManagementDetail()
            {
                BookingRepository = bookingRepository,
                BookingID = int.Parse(txtBookingID.Text)
            };
            if (bookingManagementDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
                source.Position = source.Count - 1;
            }
        }
        public void LoadBookings()
        {
            var _bookings = bookingRepository.ManagerGetBookingsByHotelID(HotelID);
            try
            {
                source = new BindingSource();
                source.DataSource = _bookings.Select(e => new MyViewModel(e)
                {
                    BookingID = e.BookingId,
                    UserID = (int)e.UserId,
                    RoomID = (int)e.RoomId,
                    CheckInDate = (DateTime)e.CheckInDate,
                    CheckOutTime = (DateTime)e.CheckOutDate,
                    TotalPrice = (decimal)e.TotalPrice,
                    //Room
                    RoomType = e.Room.RoomType.RoomTypeName,
                    //User
                    FirstName = e.User.FirstName,
                    LastName = e.User.LastName,
                    Email = e.User.Email,
                    Password = e.User.Password,
                    Phone = e.User.Phone,
                    Address = e.User.Address,
                    Role = e.User.Role,
                    Status = e.Status
                });

                if(_bookings.Count() > 0)
                {
                    txtBookingID.DataBindings.Clear();
                    txtUserID.DataBindings.Clear();
                    txtFirstName.DataBindings.Clear();
                    txtLastName.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtPhone.DataBindings.Clear();
                    txtAddress.DataBindings.Clear();
                    txtRole.DataBindings.Clear();

                    txtBookingID.DataBindings.Add("Text", source, "BookingID");
                    txtUserID.DataBindings.Add("Text", source, "UserID");
                    txtFirstName.DataBindings.Add("Text", source, "FirstName");
                    txtLastName.DataBindings.Add("Text", source, "LastName"); ;
                    txtEmail.DataBindings.Add("Text", source, "Email"); ;
                    txtPassword.DataBindings.Add("Text", source, "Password"); ;
                    txtPhone.DataBindings.Add("Text", source, "Phone"); ;
                    txtAddress.DataBindings.Add("Text", source, "Address");
                    txtRole.DataBindings.Add("Text", source, "Role");
                }
                 

                dgvBookingList.DataSource = null;
                dgvBookingList.DataSource = source;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var _bookings = bookingRepository.ManagerGetBookingsByHotelID(HotelID)
                .Where(o => o.User.Phone.Contains(txtSearch.Text));

            try
            {
                source = new BindingSource();
                source.DataSource = _bookings.Select(e => new MyViewModel(e)
                {
                    BookingID = e.BookingId,
                    UserID = (int)e.UserId,
                    RoomID = (int)e.RoomId,
                    CheckInDate = (DateTime)e.CheckInDate,
                    CheckOutTime = (DateTime)e.CheckOutDate,
                    TotalPrice = (decimal)e.TotalPrice,
                    //Room
                    RoomType = e.Room.RoomType.RoomTypeName,
                    //User
                    FirstName = e.User.FirstName,
                    LastName = e.User.LastName,
                    Email = e.User.Email,
                    Password = e.User.Password,
                    Phone = e.User.Phone,
                    Address = e.User.Address,
                    Role = e.User.Role,
                    Status = e.Status
                });

                txtBookingID.DataBindings.Clear();
                txtUserID.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtBookingID.DataBindings.Add("Text", source, "BookingID");
                txtUserID.DataBindings.Add("Text", source, "UserID");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastName.DataBindings.Add("Text", source, "LastName"); ;
                txtEmail.DataBindings.Add("Text", source, "Email"); ;
                txtPassword.DataBindings.Add("Text", source, "Password"); ;
                txtPhone.DataBindings.Add("Text", source, "Phone"); ;
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtRole.DataBindings.Add("Text", source, "Role");

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
