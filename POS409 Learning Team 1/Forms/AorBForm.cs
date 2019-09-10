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
    public partial class AorBForm : Form
    {
        public string selectedOption;
        public AorBForm(string optionAText = "Option A", string optionBText = "Option B")
        {
            InitializeComponent();
            optionA.Text = optionAText;
            optionB.Text = optionBText;
            
        }

        private void OptionA_Click(object sender, EventArgs e)
        {
            selectedOption = optionA.Text;
            Close();
        }

        private void OptionB_Click(object sender, EventArgs e)
        {
            selectedOption = optionB.Text;
            Close();
        }
    }
}
