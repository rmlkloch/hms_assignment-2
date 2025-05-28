using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();

            if (selectedUserType == "Patient")
            {

                Form3 patientForm = new Form3();
                patientForm.Show();
                this.Hide();
            }
            else if (selectedUserType == "Staff")
            {

                Form12 Form12 = new Form12();
                Form12.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid User Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usign_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
