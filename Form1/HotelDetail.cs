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
        public int UserID { get; set; }
        public int SelectedRoomTypeID { get; set; }
        public int HotelID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        IHotelRepository hotelRepository = new HotelRepository();
        IRoomRepository roomRepository = new RoomRepository();
        IRoomTypeRepository roomTypeRepository = new RoomTypeRepository();
        private void HotelDetail_Load(object sender, EventArgs e)
        {
            RoomType roomType = roomTypeRepository.GetRoomTypeByID(SelectedRoomTypeID);
            HotelID = roomType.HotelId ?? -1;
            Hotel hotel = hotelRepository.GetHotelById(HotelID);

            lblRoomType.Text = roomType.RoomTypeName;
            lblRoomTypeDes.Text = roomType.Description;
            lblRoomTypeCapacity.Text = roomType.Capacity.ToString();
            lblRoomTypeBedCount.Text = roomType.BedCount.ToString();
            lblRoomTypePrice.Text = roomType.Price.ToString() + hotel.Currency;


            lblHotelName.Text = hotel.HotelName;
            lblHotelLocation.Text = hotel.Address;
            lblHotelEmail.Text = hotel.Email;
            lblHotelPhoneNumber.Text = hotel.ContactPersonPhone;
            lblHotelContactPerson.Text = hotel.ContactPerson;
            lblHotelPolicy.Text = hotel.CancellationPolicy;
            LoadRoom();
        }

        private void LoadRoom()
        {
            try
            {
                lblMsg.Text = string.Empty;
                using (var db = new HotelProjectContext())
                {

                    IEnumerable<RoomType> rtList = roomTypeRepository.GetRoomTypesByHotelID(HotelID).ToList();
                    IEnumerable<Room> rList = roomRepository.GetRoomsByRoomTypeID(SelectedRoomTypeID).ToList();
                    IEnumerable<RoomViewModel> list = new List<RoomViewModel>();
                    list = from rt in rtList
                           join r in rList on rt.RoomTypeId equals r.RoomTypeId
                           where r.RoomTypeId == SelectedRoomTypeID && r.Status == "active" && rt.Status == "active"
                           select new RoomViewModel()
                           {
                               RoomID = r.RoomId,
                               Number = r.RoomNumber,
                           };
                    //clear data 
                    lblRoomNumber.DataBindings.Clear();
                    lblRoomID.DataBindings.Clear();
                    dgvRoom.DataSource = null;

                    //check if list == 0, else add databinding
                    if (list != null && list.Count() > 0)
                    {
                        BindingSource bds = new BindingSource();
                        bds.DataSource = list;
                        lblRoomNumber.DataBindings.Add("Text", bds, "Number");
                        lblRoomID.DataBindings.Add("Text", bds, "RoomID");
                        dgvRoom.DataSource = bds;
                    }
                    else
                    {
                        lblMsg.Text = "There are no current Room with this room Type";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Order failed");
            }
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConfirmBooking();
        }


        private void ConfirmBooking()
        {
            this.Hide();
            if (UserID == 0)
            {
                DialogResult rs = MessageBox.Show("You need to login to book. Proceed to login form?", "Access denied", MessageBoxButtons.YesNo);
                if (rs == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                Booking f = new Booking()
                {

                    UserID = UserID,
                    HotelID = HotelID,
                    RoomTypeID = SelectedRoomTypeID,
                    RoomID = int.Parse(lblRoomID.Text),
                    CheckIn = CheckIn,
                    CheckOut = CheckOut,

                };
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Show();
                }
            }

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ConfirmBooking();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
