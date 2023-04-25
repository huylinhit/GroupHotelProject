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

namespace Form1
{
    public partial class RoomTypeManagement : Form
    {
        public IRoomTypeRepository RoomTypeRepository { get; set; }
        public int HotelID { get; set; }
        BindingSource source;
        public RoomTypeManagement()
        {
            InitializeComponent();
        }

        private void RoomTypeManagement_Load(object sender, EventArgs e)
        {

            LoadRoomTypeList();
            dgvRoomTypeList.CellDoubleClick += dgvRoomTypeList_CellDoubleClick;
            txtRoomTypeID.Enabled = false;
            txtRoomTypeName.Enabled = false;
            txtDescription.Enabled = false;
            txtCapacity.Enabled = false;
            txtBedCount.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtHotelID.Enabled = false;
            txtStatus.Enabled = false;

            foreach (var item in RoomTypeRepository.GetRoomTypes()
                .Where(r => r.HotelId == HotelID))
            {
                if (!cboFilter.Items.Contains(item))
                {
                    cboFilter.Items.Add(item.RoomTypeName);
                }
            }
            cboSearch.SelectedIndex = 0;
        }
        private void dgvRoomTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomTypeDetails roomTypeDetails = new RoomTypeDetails
            {
                Text = "Update Room",
                InsertOrUpdate = true,
                RoomTypeInfo = GetRoomType(),
                RoomTypeRepository = RoomTypeRepository,
                HotelID = HotelID,
            };
            if (roomTypeDetails.ShowDialog() == DialogResult.OK)
            {
                LoadRoomTypeList();
                source.Position = source.Count - 1;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoomTypeDetails roomTypeDetails = new RoomTypeDetails
            {
                Text = "Add Room",
                InsertOrUpdate = false,
                RoomTypeRepository = RoomTypeRepository,
                HotelID = HotelID,
            };
            if (roomTypeDetails.ShowDialog() == DialogResult.OK)
            {
                LoadRoomTypeList();
                source.Position = source.Count - 1;
            }
        }
        public RoomType GetRoomType()
        {
            RoomType roomType = null;
            try
            {
                roomType = new RoomType
                {
                    RoomTypeId = int.Parse(txtRoomTypeID.Text),
                    RoomTypeName = txtRoomTypeName.Text,
                    Description = txtDescription.Text,
                    Capacity = int.Parse(txtCapacity.Text),
                    BedCount = int.Parse(txtBedCount.Text),
                    Price = decimal.Parse(txtTotalPrice.Text),
                    HotelId = int.Parse(txtHotelID.Text),
                    Status = txtStatus.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get room type");
            }
            return roomType;
        }
        public void LoadRoomTypeList()
        {
            var roomTypes = RoomTypeRepository.GetRoomTypes().Where(r => r.HotelId == HotelID);
            TryBindRoomTypeList(roomTypes);
        }
        private void TryBindRoomTypeList(IEnumerable<RoomType> roomTypes)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = roomTypes;

                if(roomTypes.Count() > 0)
                {
                    txtRoomTypeID.DataBindings.Clear();
                    txtRoomTypeName.DataBindings.Clear();
                    txtDescription.DataBindings.Clear();
                    txtCapacity.DataBindings.Clear();
                    txtBedCount.DataBindings.Clear();
                    txtTotalPrice.DataBindings.Clear();
                    txtHotelID.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();

                    txtRoomTypeID.DataBindings.Add("Text", source, "RoomTypeID");
                    txtRoomTypeName.DataBindings.Add("Text", source, "RoomTypeName");
                    txtDescription.DataBindings.Add("Text", source, "Description");
                    txtCapacity.DataBindings.Add("Text", source, "Capacity");
                    txtBedCount.DataBindings.Add("Text", source, "BedCount");
                    txtTotalPrice.DataBindings.Add("Text", source, "Price");
                    txtHotelID.DataBindings.Add("Text", source, "HotelID");
                    txtStatus.DataBindings.Add("Text", source, "Status");
                }
                 

                dgvRoomTypeList.DataSource = null;
                dgvRoomTypeList.DataSource = source;

                if (roomTypes.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    ClearText();
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
        public void ClearText()
        {
            txtRoomTypeID.Text = string.Empty;
            txtRoomTypeName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtBedCount.Text = string.Empty;
            txtTotalPrice.Text = string.Empty;
            txtHotelID.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _confirm = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (_confirm == DialogResult.OK)
                {
                    var roomType = GetRoomType();
                    RoomTypeRepository.DeleteRoomType(roomType.RoomTypeId);
                    MessageBox.Show("Delete Successfully");
                }
                 
                LoadRoomTypeList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Delete a product");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                var roomTypes = RoomTypeRepository.GetRoomTypes().
                    Where(r => r.HotelId == HotelID);
                TryBindRoomTypeList(roomTypes);
            }
            if (cboSearch.SelectedIndex == 0) // Search By Room Type
            {
                var roomTypes = RoomTypeRepository.GetRoomTypes()
                    .Where(r => r.HotelId == HotelID)
                    .Where(o => o.RoomTypeName.ToLower().Contains(txtSearch.Text.ToLower()));
                TryBindRoomTypeList(roomTypes);
            }
            else if (cboSearch.SelectedIndex == 1) // Search By capacity
            {
                var roomTypes = RoomTypeRepository.GetRoomTypes()
                    .Where(r => r.HotelId == HotelID)
                    .Where(o => o.Capacity == int.Parse(txtSearch.Text));
                TryBindRoomTypeList(roomTypes);
            }
            else if (cboSearch.SelectedIndex == 2) // Search By Bed Count
            {
                var roomTypes = RoomTypeRepository.GetRoomTypes()
                    .Where(r => r.HotelId == HotelID)
                    .Where(o => o.BedCount == int.Parse(txtSearch.Text));
                TryBindRoomTypeList(roomTypes);
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomTypes = RoomTypeRepository.GetRoomTypes()
                .Where(r => r.HotelId == HotelID)
                .Where(o => o.RoomTypeName.Equals(cboFilter.Text));
            TryBindRoomTypeList(roomTypes);
        }
    }
}
