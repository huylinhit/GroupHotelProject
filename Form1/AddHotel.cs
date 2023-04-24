using Form1;
using MyLibrary.Models;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Hotel GetHotelObject()
        {
            Hotel _hotel = null;
            string status = "active";

            try
            {
                _hotel = new Hotel()
                {
                    HotelId = int.Parse(txtHotelID.Text),
                    ManagerId = int.Parse(txtManagerID.Text),
                    HotelName = txtHotelName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    ContactPerson = txtContactPersonName.Text,
                    ContactPersonEmail = txtContactPersonEmail.Text,
                    ContactPersonPhone = txtContactPersonPhone.Text,
                    CancellationPolicy = txtCancellationPolicy.Text,
                    Currency = txtCurrency.Text,
                    Status = status
                };



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return _hotel;
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


                }).ToList();

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

            dgvHotels.CellDoubleClick += DgvHotels_CellDoubleClick;
        }

        private void DgvHotels_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            var _hotel = GetHotelObject();

            AddHotelDetail addHotelDetail = new AddHotelDetail()
            {
                Text = "Update Hotel",
                InsertOrUpdate = true,
                HotelObject = _hotel,
                hotelRepository = hotelRepository
            };

            if (addHotelDetail.ShowDialog() == DialogResult.OK)
            {
                LoadHotelsList();
                source.Position = source.Count - 1;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadHotelsList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _hotelID = int.Parse(txtHotelID.Text);
            try
            {
                DialogResult _confirm = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (_confirm == DialogResult.OK)
                {
                    hotelRepository.DeleteHotel(_hotelID);
                    MessageBox.Show("Delete Successfully");
                }
                LoadHotelsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHotelDetail addHotelDetail = new AddHotelDetail()
            {
                Text = "Add New Hotel",
                InsertOrUpdate = false,
                hotelRepository = hotelRepository,
            };

            if (addHotelDetail.ShowDialog() == DialogResult.OK)
            {
                LoadHotelsList();
                source.Position = source.Count - 1;
            }
        }
    }
}
