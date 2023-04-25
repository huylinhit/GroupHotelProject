using MyLibrary.Models;
using MyLibrary.Repositories;
using System.Globalization;

namespace HotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpkrCheckIn.MinDate = DateTime.Now.AddHours(30);
            dtpkrCheckIn.MaxDate = DateTime.Now.AddMonths(6);
        }
        IHotelRepository hotelRepository = new HotelRepository();

        public void PopulateSeachParameters()
        {
            txtSearch.Text = Search;
            txtGuest.Text = Guest.ToString();
            txtDuration.Text = Duration.ToString();
            dtpkrCheckIn.Value = CheckIn;
        }
        public int UserID { get; set; }
        public string Search { get; set; }
        public int Guest { get; set; }
        public int Duration { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int SelectedRoomTypeID { get; set; }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateSeachParameters();
        }
        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            UpdateCheckOutDate();
        }
        private void dtpkrCheckIn_ValueChanged(object sender, EventArgs e)
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHotel();
        }

        private void LoadHotel()
        {
            try
            {
                using (var db = new HotelProjectContext())
                {


                    lblMsg.Text = string.Empty;
                    string? search = txtSearch.Text.Trim();
                    bool guestValid = int.TryParse(txtGuest.Text, out int guest);
                    bool durationValid = int.TryParse(txtDuration.Text, out int duration);
                    if (!durationValid) { lblMsg.Text += "Duration must be filled in"; return; }
                    if (!guestValid) { lblMsg.Text += "Guest must a number, you can leave this field empty"; return; }
                    if (guest >= 24) { lblMsg.Text += "There is no room in our system for " + guest + "guest"; return; }
                    if (guest < 1) { lblMsg.Text += "guest must be a positive whole number"; return; }
                    DateTime checkin = dtpkrCheckIn.Value;
                    DateTime checkout = checkin.AddDays(duration);
                    CheckIn = checkin;
                    CheckOut = checkout;

                    IEnumerable<HotelViewModel> list = hotelRepository.GetHotelsBySearchParameters(search, checkin, checkout, guest, db).ToList();
                    //clear data 
                    lblSelectedRoomTypeID.DataBindings.Clear();
                    dgvHotel.DataSource = null;

                    //check if list == 0, else add databinding
                    if (list != null && list.Count() > 0)
                    {
                        BindingSource bds = new BindingSource();
                        bds.DataSource = list;
                        lblSelectedRoomTypeID.DataBindings.Add("Text", bds, "RoomTypeID");
                        dgvHotel.DataSource = bds;
                    }
                    else
                    {
                        ClearTxt();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Order failed");
            }
        }

        private void ClearTxt()
        {
            lblSelectedRoomTypeID.Text = string.Empty;
        }

        private void dgvHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool valid = int.TryParse(lblSelectedRoomTypeID.Text, out int id);
            if (valid)
            {
                this.Hide();
                HotelDetail hd = new HotelDetail()
                {
                    SelectedRoomTypeID = int.Parse(lblSelectedRoomTypeID.Text),
                    CheckIn = CheckIn,
                    CheckOut = CheckOut,
                    UserID = UserID
                };
                if (hd.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                }
            }

        }


    }
}