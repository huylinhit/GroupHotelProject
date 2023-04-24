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

namespace HotelBooking
{
    public partial class HotelDetail : Form
    {
        public HotelDetail()
        {
            InitializeComponent();
        }

        public int SelectedRoomTypeID { get; set; }
        IHotelRepository hotelRepository = new HotelRepository();
        IRoomRepository roomRepository = new RoomRepository();
        TempRoomTypeRepository roomTypeRepository = new TempRoomTypeRepository();
        private void HotelDetail_Load(object sender, EventArgs e)
        {
            RoomType roomType = roomTypeRepository.GetRoomTypeByID(SelectedRoomTypeID);
            lblRoomType.Text = roomType.RoomTypeName;
            lblRoomTypeDes.Text = roomType.Description;
            lblRoomTypeCapacity.Text = roomType.Capacity.ToString();
            lblRoomTypeBedCount.Text = roomType.BedCount.ToString();
            lblRoomTypePrice.Text = roomType.Price.ToString();
            Hotel hotel = hotelRepository.GetHotelById(roomType.HotelId??-1);
            lblHotelName.Text = hotel.HotelName;
            lblHotelLocation.Text = hotel.Address;
            lblHotelEmail.Text = hotel.Email;
            lblHotelPhoneNumber.Text = hotel.ContactPersonPhone;
            lblHotelContactPerson.Text = hotel.ContactPerson;
            lblHotelPolicy.Text = hotel.CancellationPolicy;
        }
    }
}
