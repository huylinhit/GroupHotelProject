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
            String email = userRepository.GetDefaultAccount(true).Email;
            String password = userRepository.GetDefaultAccount(true).Password;
            if(txtEmail.Text.Equals(email) && txtPassword.Text.Equals(password)) {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
