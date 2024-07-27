using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    public partial class ShowDialog : Form
    {
        public string username { get; private set; }
        public ShowDialog()
        {
            InitializeComponent();
            this.Text = "Enter your username"; // Set the title of the form
            this.TBTusername.Text = "username"; // Set the default text of the TextBox
            
        }

        private void TBTusername_TextChanged(object sender, EventArgs e)
        {
            
            
              
            

        }

        private void BTNok_Click(object sender, EventArgs e)
        {
            username = TBTusername.Text;
            string playerName = username;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
