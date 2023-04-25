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
    public partial class Login : Form
    {
        IUserRepository userRepository = new UserRepository();
        IHotelRepository hotelRepository = new HotelRepository();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            /*            if (!email.Contains("@"))
                        {
                            lblMsg.Text = "Invalid Email";
                            return;
                        }*/

            User? user = userRepository.ValidateLogin(email, pwd);
            if (user == null) { lblMsg.Text = "Invalid account"; return; }
            string role = user.Role;
            if (role.Equals("admin"))
            {
                BookingManagement f = new BookingManagement()
                {
                    User = user,
                };
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (role.Equals("manager"))
            {
                Hotel hotel = hotelRepository.GetHotelsByManagerID(user.UserId);
                HotelManager f = new HotelManager()
                {
                    User = user,
                    Hotel = hotel
                };
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                GiveInfo f = new GiveInfo()
                {
                    User = user,
                };
                this.Hide();
                f.ShowDialog();
                this.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
