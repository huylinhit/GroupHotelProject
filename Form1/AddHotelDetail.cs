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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class AddHotelDetail : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public IHotelRepository hotelRepository { get; set; }
        //False is Insert, True is Update
        public bool InsertOrUpdate { get; set; }
        public Hotel HotelObject { get; set; }

        public AddHotelDetail()
        {
            InitializeComponent();
        }

        public void SetDefaultComboBoxValue()
        {


            cboManagerID.Items.Clear();


            IEnumerable<User> users = _userRepository.GetUsers().Where(item => item.Role.Contains("manager"));

            IEnumerable<Hotel> hotels = hotelRepository.GetHotels().ToList();

            int numbers = hotels.Count() + 1;
            txtHotelID.Text = numbers.ToString();

            var ManagerWithNoJob = hotelRepository.GetHotelsManager().Where(item => item.User.Status.Contains("inactive"));

            foreach (var item in ManagerWithNoJob)
            {
                cboManagerID.Items.Add(item.User.UserId);
            }


        }
        public void LoadValueOfObject()
        {
            Hotel _hotel = HotelObject;



            try
            {
                txtHotelID.Text = _hotel.HotelId.ToString();
                cboManagerID.Text = _hotel.ManagerId.ToString();
                txtHotelName.Text = _hotel.HotelName.ToString();
                txtAddress.Text = _hotel.Address.ToString();
                txtPhone.Text = _hotel.Phone.ToString();
                txtEmail.Text = _hotel.Email.ToString();
                txtContactPersonName.Text = _hotel.ContactPerson.ToString();
                txtContactPersonPhone.Text = _hotel.ContactPersonPhone.ToString();
                txtContactPersonEmail.Text = _hotel.ContactPersonEmail.ToString();
                txtCancellationPolicy.Text = _hotel.CancellationPolicy.ToString();
                txtCurrency.Text = _hotel.Currency.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public Hotel GetHotelObject()
        {
            Hotel _hotel = new Hotel();
            string status = "active";

            try
            {
                _hotel = new Hotel()
                {
                    HotelId = int.Parse(txtHotelID.Text),
                    ManagerId = int.Parse(cboManagerID.SelectedItem.ToString()),
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
        private void AddHotelDetail_Load(object sender, EventArgs e)
        {

            if (InsertOrUpdate)
            {
                SetDefaultComboBoxValue();
                txtHotelID.Enabled = false;
                cboManagerID.Enabled = false;
                LoadValueOfObject();
            }
            else
            {
                SetDefaultComboBoxValue();

                txtHotelID.Enabled = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var _hotel = GetHotelObject();



                if (InsertOrUpdate == true)
                {

                    DialogResult _confirm = MessageBox.Show("Do you want to Update Hotel?", "Update Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (_confirm == DialogResult.OK)
                    {
                        hotelRepository.UpdateHotel(_hotel);

                        MessageBox.Show("Update Hotel Successfully");
                    }
                }
                else
                {
                    DialogResult _confirm = MessageBox.Show("Do you want to Add New Hotel?", "Add New Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (_confirm == DialogResult.OK)
                    {
                        hotelRepository.AddHotel(_hotel);
                        MessageBox.Show("Add New Hotel Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboManagerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UserID = int.Parse(cboManagerID.SelectedItem.ToString());

            Hotel managerHaveJob = hotelRepository.GetHotelById(UserID);

            IEnumerable<User> users = _userRepository.GetUsers();

            if (managerHaveJob != null && InsertOrUpdate == false)
            {

            }

        }
    }
}
