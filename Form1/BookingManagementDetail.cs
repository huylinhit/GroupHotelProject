using HotelBooking;
using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class BookingManagementDetail : Form
    {


        public IBookingRepository BookingRepository { get; set; }
        public int BookingID { get; set; }
        public BookingManagementDetail()
        {
            InitializeComponent();
        }

        public void SetDefaultStatus()
        {
            List<string> list = new List<string>()
            {
                "confirmed","pending","cancel"
            };
            var _bookings = list.ToList();

            foreach (var item in _bookings)
            {
                cboStatus.Items.Add(item);
            }
        }

        public void AddInputDefaultBox()
        {
            var _bookingInfo = BookingRepository.GetBookingByBookingID(BookingID);



            var booking = _bookingInfo.SingleOrDefault(item => item.BookingId == BookingID);

            txtUserID.Text = booking.User.UserId.ToString();
            txtFirstName.Text = booking.User.FirstName.ToString();
            txtLastName.Text = booking.User.LastName.ToString();
            txtEmail.Text = booking.User.Email.ToString();
            txtPassword.Text = booking.User.Password.ToString();
            txtPhone.Text = booking.User.Phone.ToString();
            txtAddress.Text = booking.User.Address.ToString();
            txtRole.Text = booking.User.Role.ToString();

            txtBookingID.Text = booking.BookingId.ToString();
            txtUserID2.Text = booking.UserId.ToString();
            txtRoomID.Text = booking.RoomId.ToString();
            txtRoomTypeName.Text = booking.Room.RoomType.RoomTypeName.ToString();
            txtRoomNumber.Text = booking.Room.RoomNumber.ToString();

            txtCheckInDate.Text = booking.CheckInDate.ToString();
            txtCheckOutDate.Text = booking.CheckOutDate.ToString();
            txtTotalPrice.Text = booking.TotalPrice.ToString();
            cboStatus.Text = booking.Status.ToString();



        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookingManagementDetail_Load(object sender, EventArgs e)
        {
            SetDefaultStatus();
            AddInputDefaultBox();




        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        public MyLibrary.Models.Booking GetBookingInfo()
        {
            MyLibrary.Models.Booking _booking = null;


            try
            {
                _booking = new MyLibrary.Models.Booking()
                {
                    BookingId = int.Parse(txtBookingID.Text),
                    UserId = int.Parse(txtUserID.Text),
                    RoomId = int.Parse(txtRoomID.Text),
                    CheckInDate = DateTime.Parse(txtCheckInDate.Text),
                    CheckOutDate = DateTime.Parse(txtCheckOutDate.Text),
                    TotalPrice = decimal.Parse(txtTotalPrice.Text),
                    Status = cboStatus.SelectedItem.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return _booking;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MyLibrary.Models.Booking _booking = GetBookingInfo();

            DialogResult _confirm = MessageBox.Show("Do you want to Update Booking?", "Update Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (_confirm == DialogResult.OK)
            {
                BookingRepository.UpdateBooking(_booking);

                btnUpdate.DialogResult = DialogResult.OK;
                MessageBox.Show("Update Booking Successfully");
            }
            else
            {
                btnUpdate.DialogResult = DialogResult.None;
            }



        }
    }
}
