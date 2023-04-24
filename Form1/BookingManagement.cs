﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Models;
using MyLibrary.Repositories;

namespace HotelBooking
{
    public partial class BookingManagement : Form
    {
        IBookingRepository bookingRepository = new BookingRepository();

        BindingSource source;

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

            public MyViewModel(Booking obj)
            {
                _obj = obj;
            }

            public MyViewModel(MyLibrary.Models.Booking e)
            {
                this.e = e;
            }

            public Booking GetModel()
            {
                return _obj;
            }
        }

        public BookingManagement()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtUserID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }
        public void LoadBookings()
        {
            var _bookings = bookingRepository.GetBookings();

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
                    Address = e.User.Address
                });

                txtUserID.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtAddress.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "UserID");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastName.DataBindings.Add("Text", source, "LastName"); ;
                txtEmail.DataBindings.Add("Text", source, "Email"); ;
                txtPassword.DataBindings.Add("Text", source, "Password"); ;
                txtPhone.DataBindings.Add("Text", source, "Phone"); ;
                txtAddress.DataBindings.Add("Text", source, "Address"); ;





                dgvBookings.DataSource = null;
                dgvBookings.DataSource = source;

                if (_bookings.Count() == 0)
                {
                    Clear();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
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
        }
    }
}
