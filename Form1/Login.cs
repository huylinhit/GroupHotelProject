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

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailAdmin = userRepository.GetDefaultAccount(true).Email;
            string passwordAdmin = userRepository.GetDefaultAccount(true).Password;

            string emailManager = userRepository.GetDefaultAccount(false).Email;
            string passwordManager = userRepository.GetDefaultAccount(false).Password;
            if(txtEmail.Text.Equals(emailAdmin) && txtPassword.Text.Equals(passwordAdmin)) {
                AddHotel addHotel = new AddHotel();
                addHotel.Show();
            }
            else if(txtEmail.Text.Equals(emailManager) && txtPassword.Text.Equals(passwordManager))
            {
                HotelManager hotelManager = new HotelManager();
                hotelManager.Show();
            }
            this.Hide();

        }
    }
}
