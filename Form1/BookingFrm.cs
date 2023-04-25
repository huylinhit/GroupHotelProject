using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class BookingFrm : Form
    {
        public BookingFrm()
        {
            InitializeComponent();
        }
        public int UserID { get; set; }
        public int HotelID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }

        IUserRepository userRepository = new UserRepository();
        IHotelRepository hotelRepository = new HotelRepository();
        IRoomRepository roomRepository = new RoomRepository();
        IRoomTypeRepository roomTypeRepository = new RoomTypeRepository();
        private void Booking_Load(object sender, EventArgs e)
        {
            User u = userRepository.GetUserByID(UserID);
            lblCusEmail.Text = u.Email;
            lblCusName.Text = u.FirstName + u.LastName;
            lblCusPhone.Text = u.Phone;
            lblCheckInDate.Text = CheckIn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblCheckOutDate.Text = CheckOut.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            Hotel h = hotelRepository.GetHotelById(HotelID);
            lblHotelName.Text = h.HotelName;
            lblHotelPolicy.Text = h.CancellationPolicy;
            RoomType rt = roomTypeRepository.GetRoomTypeByID(RoomTypeID);
            lblRoomType.Text = rt.RoomTypeName;
            lblRoomTypeBedCount.Text = rt.BedCount.ToString();
            lblRoomTypeCapacity.Text = rt.Capacity.ToString();
            Room r = roomRepository.GetRoomByID(RoomID);
            lblRoomNumber.Text = r.RoomNumber;
            TotalPrice = rt.Price * (CheckOut - CheckIn).Days ?? 0;
            lblTotalPrice.Text = (rt.Price * (CheckOut - CheckIn).Days).ToString() + h.Currency;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                IBookingRepository bookingRepository = new BookingRepository();
                bookingRepository.AddBooking(new MyLibrary.Models.Booking
                {
                    CheckInDate = CheckIn,
                    CheckOutDate = CheckOut,
                    RoomId = RoomID,
                    UserId = UserID,
                    TotalPrice = TotalPrice
                });
                MessageBox.Show("Thank you for booking with us. Your reservation will be confirmed by the hotel in a minute. We wish you an amazing holiday", "Booking Completed");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error making a booking record. Please try again");
                this.DialogResult = DialogResult.None;
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
