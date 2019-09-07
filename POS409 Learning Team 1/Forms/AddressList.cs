using Microsoft.VisualBasic.FileIO;
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
    public partial class AddressList : Form
    {
        private bool mockDataLoaded = false;
        public AddressList()
        {

            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int editButtonIndex = 7;
            int deleteButtonIndex = 8;
            if (e.ColumnIndex == editButtonIndex)
            {
                UpdateSelectedAddressFromDataGrid(e.RowIndex);
            }
            if (e.ColumnIndex == deleteButtonIndex)
            {
                RemoveAddressFromDataGrid(e.RowIndex);
            }             
        }
        private void UpdateSelectedAddressFromDataGrid(int rowIndex)
        {
            Guid id = Guid.Parse(AddressListDataTable[0, rowIndex].Value.ToString());
            AddressForm objUI = new AddressForm(id);
            objUI.ShowDialog();
            try
            {
                AddressListDataTable.Rows.RemoveAt(rowIndex);
                Entities.Address addr = Repositories.Addresses.Read(id);
                AddressListDataTable.Rows.Insert(rowIndex - 1, addr.ToArray());
            } catch (ArgumentOutOfRangeException)
            {
                Entities.Address addr = Repositories.Addresses.Read(id);
                List<string> cells = addr.ToArray().ToList();
                cells.Add("Edit");
                cells.Add("Delete");
                AddressListDataTable.Rows.Add(cells.ToArray());
            }
            
            
        }
        private void RemoveAddressFromDataGrid(int rowIndex)
        {
            Guid id = Guid.Parse(AddressListDataTable[0, rowIndex].Value.ToString());
            AddressListDataTable.Rows.RemoveAt(rowIndex);
            Repositories.Addresses.Delete(id);
        }

        private void AddAddressBtn_Click(object sender, EventArgs e)
        {
            
            var id = Guid.Empty;
            AddressForm objUI = new AddressForm(id);
            objUI.ShowDialog();
            ResetDataTable();

        }

        private void ResetDataTable()
        {
            AddressListDataTable.Rows.Clear();
            foreach( Entities.Address addr in Repositories.Addresses.All()) {
                List<string> cells = addr.ToArray().ToList();
                cells.Add("Edit");
                cells.Add("Delete");
                AddressListDataTable.Rows.Add(cells.ToArray());                
            }
        }

        private void LoadMockData_Click(object sender, EventArgs e)
        {
            if (!mockDataLoaded)
            {
                var path = @"MOCK_DATA.csv"; // Habeeb, "Dubai Media City, Dubai"
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;
                    while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();                        
                        Repositories.Addresses.Create(fields[1], fields[2], fields[3], fields[4], fields[5], fields[6]);                                                     
                    }
                }
                ResetDataTable();
                mockDataLoaded = true;
            } else
            {
                MessageBox.Show("Mock Data already loaded!");
            }
           
        }
    }
}
