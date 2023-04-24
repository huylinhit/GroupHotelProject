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
    public partial class AddHotel : Form
    {
        IHotelRepository hotelRepository = new HotelRepository();
        BindingSource source;

        class MyViewModel
        {
            public int HotelId { get; set; }    
            public int ManagerID { get; set; }
            public string HotelName { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public string ContactPerson { get; set; }
            public string ContactPersonPhone { get; set; }

            public string ContactPersonEmail { get; set; }
            public string CancellationPolicy { get; set; }
            public string Currency { get; set; }

            private Hotel _obj;

            public MyViewModel(Hotel obj)
            {
                _obj = obj;
            }

            public Hotel GetModel()
            {
                return _obj;
            }
        }

        //grid.DataSource = objects.Select(o => new MyViewModel(o)
        //{ Column1 = o.SomeValue, Column2 = o.SomeOtherValue }).ToList();

        public AddHotel()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtHotelID.Text = string.Empty;
            txtManagerID.Text = string.Empty;
            txtHotelName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContactPersonName.Text = string.Empty;
            txtContactPersonPhone.Text = string.Empty;
            txtContactPersonEmail.Text = string.Empty;
            txtCancellationPolicy.Text = string.Empty;
            txtCurrency.Text = string.Empty;
        }
        public void LoadHotelsList()
        {
            var _hotels = hotelRepository.GetHotels();
            try
            {
                source = new BindingSource();
                source.DataSource = _hotels.Select(o => new MyViewModel(o)
                {
                    HotelId = o.HotelId,
                    ManagerID = (int)o.ManagerId,
                    HotelName = o.HotelName,
                    Address = o.Address,
                    Phone = o.Phone,
                    Email = o.Email,
                    ContactPerson = o.ContactPerson,
                    ContactPersonEmail = o.ContactPersonEmail,
                    ContactPersonPhone = o.ContactPersonPhone,
                    CancellationPolicy = o.CancellationPolicy,
                    Currency = o.Currency,


                }).ToList() ;

                txtHotelID.DataBindings.Clear();
                txtManagerID.DataBindings.Clear();
                txtHotelName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtContactPersonName.DataBindings.Clear();
                txtContactPersonPhone.DataBindings.Clear();
                txtContactPersonEmail.DataBindings.Clear();
                txtCancellationPolicy.DataBindings.Clear();
                txtCurrency.DataBindings.Clear();


                txtHotelID.DataBindings.Add("Text", source, "HotelID");
                txtManagerID.DataBindings.Add("Text", source, "ManagerID");
                txtHotelName.DataBindings.Add("Text", source, "HotelName");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtContactPersonName.DataBindings.Add("Text", source, "ContactPerson");
                txtContactPersonPhone.DataBindings.Add("Text", source, "ContactPersonPhone");
                txtContactPersonEmail.DataBindings.Add("Text", source, "ContactPersonEmail");
                txtCancellationPolicy.DataBindings.Add("Text", source, "CancellationPolicy");
                txtCurrency.DataBindings.Add("Text", source, "Currency");

                dgvHotels.DataSource = null;
                dgvHotels.DataSource = source;


                if (_hotels.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    Clear();
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddHotel_Load(object sender, EventArgs e)
        {
            LoadHotelsList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadHotelsList();
        }
    }
}
