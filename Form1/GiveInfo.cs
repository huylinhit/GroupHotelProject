using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class GiveInfo : Form
    {
        public GiveInfo()
        {
            InitializeComponent();
            dtpkrCheckIn.MinDate = DateTime.Now.AddDays(3);
            dtpkrCheckIn.MaxDate = DateTime.Now.AddMonths(6);
            txtDuration.Text = "1";
        }

        public int UserID { get; set; } = 1;

        private void GiveInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            UpdateCheckOutDate();
        }

        private void UpdateCheckOutDate()
        {
            bool durationValid = int.TryParse(txtDuration.Text, out int duration);
            if (durationValid)
            {
                if (duration >= 1 && duration <= 30)
                {
                    lblMsg.Text = string.Empty;
                    lblCheckOut.Text = dtpkrCheckIn.Value.AddDays(duration).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    lblMsg.Text = "Duration must be atleast 1 day and at most 30 days";
                }

            }
            else
            {
                lblMsg.Text = "Duration must be number";
            }
        }

        private void btnSearchHotel_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                string? search = txtSearch.Text.Trim();
                bool guestValid = int.TryParse(txtGuest.Text, out int guest);
                bool durationValid = int.TryParse(txtDuration.Text, out int duration);
                DateTime checkin = dtpkrCheckIn.Value;
                if (!durationValid) { lblMsg.Text += "Duration must be filled in"; return; }
                if (!guestValid) { lblMsg.Text += "Guest must a number, you can leave this field empty"; return; }
                if (guest >= 24) { lblMsg.Text += "There is no room in our system for " + guest + "guest"; return; }
                if (guest < 1) { lblMsg.Text += "guest must be a positive whole number"; return; }

                Form1 f = new Form1()
                {
                    UserID = UserID,
                    Guest = guest,
                    Search = search,
                    CheckIn = checkin,
                    Duration = duration
                };
                this.Hide();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                } else
                {
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong, unable to search for appropriate hotel");
            }
        }

        private void dtpkrCheckIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateCheckOutDate();
        }
    }
}
