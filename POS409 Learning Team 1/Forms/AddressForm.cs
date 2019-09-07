using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS409_Learning_Team_1.Services;

namespace POS409_Learning_Team_1.Forms
{
    public partial class AddressForm : Form
    {
        private Entities.Address currentAddress;
        public AddressForm(Guid id)
        {
     
            currentAddress = Repositories.Addresses.Read(id);
            if (currentAddress == null)
            {
                currentAddress = new Entities.Address("Example");
            } 
            InitializeComponent();
        }

        private void SyncAddressToForm(object sender, EventArgs e)
        {
            addressLine1TextFiield.Text = currentAddress.Address1;
            addressLine2TextFiield.Text = currentAddress.Address2;
            cityTextFiield.Text = currentAddress.City;
            stateTextFiield.Text = currentAddress.State;
            countryTextFiield.Text = currentAddress.Country;
            zipCodeTextFiield.Text = currentAddress.ZipCode;
        }
        private void SyncFormToAddress()
        {
            currentAddress.Address1 = addressLine1TextFiield.Text;
            currentAddress.Address2 = addressLine2TextFiield.Text;
            currentAddress.City = cityTextFiield.Text;
            currentAddress.State = stateTextFiield.Text;
            currentAddress.Country = countryTextFiield.Text;
            currentAddress.ZipCode = zipCodeTextFiield.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                SyncFormToAddress();
                Repositories.Addresses.Update(currentAddress);
                MessageBox.Show("Saved Address", "Success!");
                Close();
            }
        }

        private Boolean InputValidation()
        {
            if (addressLine1TextFiield.Text == string.Empty)
            {
                MessageBox.Show("Woah line 1 is required!", "error");
                addressLine1TextFiield.Focus();
                return false;
            }
            if (cityTextFiield.Text == string.Empty)
            {
                MessageBox.Show("Please input city!", "error");
                cityTextFiield.Focus();
                return false;
            }
            if (stateTextFiield.Text == string.Empty)
            {
                MessageBox.Show("Please input state!", "error");
                stateTextFiield.Focus();
                return false;
            }
            if (countryTextFiield.Text == string.Empty)
            {
                MessageBox.Show("Please input country!", "error");
                countryTextFiield.Focus();
                return false;
            }
            if (zipCodeTextFiield.Text == string.Empty)
            {
                MessageBox.Show("Please input zipcode!", "error");
                zipCodeTextFiield.Focus();
                return false;
            }
            else
            {
                if (!BusinessRule.IsZipCode(zipCodeTextFiield.Text))
                {
                    MessageBox.Show("Please input valid zipcode!", "error");
                    zipCodeTextFiield.Focus();
                    return false;
                }
            }
            return true;
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Repositories.Addresses.Delete(currentAddress.id);
            Close();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
