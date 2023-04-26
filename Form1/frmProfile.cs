using Microsoft.EntityFrameworkCore.Metadata;
using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frmProfile : Form
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
        public frmProfile()
        {
            InitializeComponent();
        }
        BindingSource source;
        IBookingRepository bookingRepository = new BookingRepository();

        public User user { get; set; }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadBookings();
            txtBookingID.Enabled = false;
            txtUserID.Enabled = false;
            //dgvBookingList.CellDoubleClick += dgvBookingList_CellDoubleClick;
        }

        public void LoadBookings()
        {
            var _bookings = bookingRepository.GetBookingsByUserID(user.UserId);
            try
            {
                source = new BindingSource();
                var temp = _bookings.Select(e => new MyViewModel(e)
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

                if (temp.Count() != 0)
                {
                    source.DataSource = temp;
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
                else
                {
                    lblMsg.Text = "You haven't made a booking yet";
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void dgvBookingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            bool bookingIDValid = int.TryParse(txtBookingID.Text, out int bookingID);
            if (bookingIDValid)
            {
                DialogResult rs = MessageBox.Show("Do you want to cancel this Booking?", "Cancel Booking", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    IBookingRepository bookingRepository = new BookingRepository();
                    Booking b = bookingRepository.GetBookingByID(bookingID);
                    if (b != null && b.Status=="pending") {
                        bookingRepository.UpdateBookingStatusByBookingID(bookingID, "cancel");
                    } else
                    {
                        lblMsg.Text = "Error canceling booking";
                    }
                }
                else
                {
                    lblMsg.Text = "Error canceling booking";
                }
            }
            LoadBookings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
