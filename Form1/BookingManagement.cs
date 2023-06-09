﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1;
using MyLibrary.Models;
using MyLibrary.Repositories;

namespace HotelBooking
{
    public partial class BookingManagement : Form
    {
        IBookingRepository bookingRepository = new BookingRepository();
        IRoomTypeRepository roomTypeRepository = new RoomTypeRepository();
        BindingSource source;

        public User User { get; set; }

        public string Filter { get; set; }
        public string FilterValue { get; set; }
        public bool IsSearchOrFilter { get; set; }
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

        public void SetDefaultPlaceHolderFilter()
        {
            txtSearchUserID.PlaceholderText = "User ID";
            txtNameSearch.PlaceholderText = "Search Name";

            cboHotelName.Text = string.Empty;
            List<RoomType> roomTypes = roomTypeRepository.GetRoomTypes().ToList();
            foreach (var item in roomTypes)
            {
                cboHotelName.Items.Add(item.RoomTypeName);
            }


            List<string> listPrice = new List<string>()
            {
                "Price Ascending", "Price Descending"
            };


            List<string> listRole = new List<string>()
            {
                "admin","manager","member"
            };

            List<string> listStatus = new List<string>()
            {
                "confirmed", "cancel", "pending"
            };

            foreach (var item in listPrice)
            {
                cboPrice.Items.Add(item);
            }

            foreach (string role in listRole)
            {
                cboRole.Items.Add(role);
            }

            foreach (var item in listStatus)
            {
                cboStatus.Items.Add(item);
            }
        }
        public BookingManagement()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtBookingID.Text = string.Empty;
            txtUserID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRole.Text = string.Empty;


        }

        public void ClearFilter()
        {
            Filter = "";
            FilterValue = "";


        }
        public void LoadBookings()
        {
            var _bookings = bookingRepository.GetBookings();

            //RemoveComboBox
            cboUsersName.Items.Clear();
            //cboStatus.Items.Clear();
            //cboRole.Items.Clear();
            //cboPrice.Items.Clear();


            //SetComboBoxName
            foreach (var item in _bookings)
            {
                cboUsersName.Items.Add(item.User.FirstName);
            }

            try
            {
                source = new BindingSource();

                switch (Filter)
                {
                    case "SearchByHotelName":
                        {
                            _bookings = bookingRepository.GetBookingDetailSearchHotelRoom(FilterValue);
                            ClearFilter();
                            break;
                        }

                    case "SearchByUserID":
                        {
                            int value = 0;
                            try
                            {
                                value = int.Parse(FilterValue);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Input UserID is Number");
                            }

                            _bookings = bookingRepository.GetBookingDetailSearchUserID(int.Parse(FilterValue));
                            ClearFilter();
                            break;
                        }
                    case "SearchByUserName":
                        {

                            _bookings = bookingRepository.GetBookingDetailSearchName(FilterValue);
                            ClearFilter();
                            break;
                        }
                    case "PriceAscending":
                        {
                            _bookings = bookingRepository.GetBookingDetailPriceAscending();
                            ClearFilter();
                            break;
                        }
                    case "PriceDescending":
                        {
                            _bookings = bookingRepository.GetBookingDetailPriceDescending();
                            ClearFilter();
                            break;
                        }
                    case "SearchByRole":
                        {
                            _bookings = bookingRepository.GetBookingDetailSearchRole(FilterValue);
                            ClearFilter();
                            break;
                        }

                    case "SearchByBookingStatus":
                        {
                            _bookings = bookingRepository.GetBookingDetailSearchHotelStatus(FilterValue);
                            ClearFilter();
                            break;
                        }


                    default:
                        {
                            _bookings = bookingRepository.GetBookings();
                            ClearFilter();
                            break;
                        }
                }

                if (_bookings.Count() > 0)
                {
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
                }
                else
                {
                    source = null;
                }

                dgvBookings.DataSource = null;
                dgvBookings.DataSource = source;
                ClearFilter();

                if (_bookings.Count() == 0)
                {
                    Clear();
                }
                else
                {
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void BookingManagement_Load(object sender, EventArgs e)
        {
            LoadBookings();
            SetDefaultPlaceHolderFilter();

            dgvBookings.CellDoubleClick += DgvBookings_CellDoubleClick;
        }

        private void DgvBookings_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchUserIDValue = txtSearchUserID.Text.Trim();

            string searchNameValue = txtNameSearch.Text.Trim();

            if (!searchUserIDValue.Equals(""))
            {
                Filter = "SearchByUserID";
                FilterValue = searchUserIDValue;

            }
            else if (!searchNameValue.Equals(""))
            {
                Filter = "SearchByUserName";
                FilterValue = searchNameValue;
            }
            else
            {
                ClearFilter();
            }
            LoadBookings();

        }

        private void cboUsersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchValue = cboUsersName.SelectedItem.ToString();
            if (!searchValue.Equals(""))
            {
                Filter = "SearchByUserName";
                FilterValue = searchValue;
                LoadBookings();
            }
            else
            {
                ClearFilter();
                LoadBookings();
            }

        }

        private void txtSearchUserID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSearchUserID_MouseClick(object sender, MouseEventArgs e)
        {
            txtNameSearch.Text = string.Empty;
        }

        private void txtNameSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchUserID.Text = string.Empty;
        }

        private void cboHotelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchValue = cboHotelName.SelectedItem.ToString();
            if (!searchValue.Equals(""))
            {
                Filter = "SearchByHotelName";
                FilterValue = searchValue;
                LoadBookings();
            }
            else
            {
                ClearFilter();
                LoadBookings();
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchValue = cboStatus.SelectedItem.ToString();
            if (!searchValue.Equals(""))
            {
                Filter = "SearchByBookingStatus";
                FilterValue = searchValue;
                LoadBookings();
            }
            else
            {
                ClearFilter();
                LoadBookings();
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchValue = cboRole.SelectedItem.ToString();
            if (!searchValue.Equals(""))
            {
                Filter = "SearchByRole";
                FilterValue = searchValue;
                LoadBookings();
            }
            else
            {
                ClearFilter();
                LoadBookings();
            }
        }

        private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchValue = cboPrice.SelectedIndex;
            ClearFilter();
            if (searchValue == 0)
            {
                Filter = "PriceAscending";
                LoadBookings();
            }
            else if (searchValue == 1)
            {
                Filter = "PriceDescending";
                LoadBookings();
            }
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            AddHotel addHotel = new AddHotel()
            {

            };
            addHotel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchUserID_TextChanged_1(object sender, EventArgs e)
        {
            txtNameSearch.Text = string.Empty;
        }

        private void txtNameSearch_TextChanged_1(object sender, EventArgs e)
        {
            txtSearchUserID.Text = string.Empty;
        }
    }
}
