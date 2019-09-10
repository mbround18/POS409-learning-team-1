using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS409_Learning_Team_1.Forms
{
    public partial class Main : Form
    {
        private AddressList addressList = new AddressList();

        public Main()
        {
            InitializeComponent();
            gMapControl.SetPositionByKeywords("Portland, Oregon");

        }


        private void NavigateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented!", "Error");
        }

        private void GMapControl_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl.DragButton = MouseButtons.Left;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        }

        private void SaveDestinationAddressBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented!", "Error");
        }

        private void SaveSourceAddressBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented!", "Error");
        }

        private void SearchSourceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented!", "Error");
        }

        private void SearchDestinationBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented!", "Error");
        }

        private void SearchAddress(string type)
        {
            switch(type)
            {
                case "dest":
                    break;
                case "src":
                default:
                    break;
            }
        }

        private void ViewAddressBookBtn_Click(object sender, EventArgs e)
        {
            addressList.ShowDialog();
        }

        private void PickSrcAddressBtn_Click(object sender, EventArgs e)
        {
            addressList.ShowDialog();
            Entities.Address addr = addressList.SelectedAddress;
            if (addr != null)
            {
                sourceTextBox.Text = addr.ToString();
            }
        }

        private void PickDestAddressBtn_Click(object sender, EventArgs e)
        {
            addressList.ShowDialog();
            Entities.Address addr = addressList.SelectedAddress;
            if (addr != null)
            {
                destinationTextBox.Text = addr.ToString();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
