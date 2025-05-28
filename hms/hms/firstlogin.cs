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
        public static System.Drawing.Size PreviousFormSize = new System.Drawing.Size(800, 600); // Default Size එකක් දෙන්න පුළුවන්
        public static System.Drawing.Point PreviousFormLocation = new System.Drawing.Point(100, 100); // Default Location එකක් දෙන්න පුළුවන්
        public Form1()
        {
            InitializeComponent();
        }

        private void usercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();

            if (selectedUserType == "Patient")
            {
                PreviousFormSize = this.Size;
                PreviousFormLocation = this.Location;

                Form3 patientForm = new Form3();
                patientForm.StartPosition = FormStartPosition.Manual;
                patientForm.Location = PreviousFormLocation;
                patientForm.Size = PreviousFormSize;
                patientForm.Show();
                this.Hide();
            }
            else if (selectedUserType == "Staff")
            {
                PreviousFormSize = this.Size; 
                PreviousFormLocation = this.Location;

                Form12 form12 = new Form12();
                form12.StartPosition = FormStartPosition.Manual;
                form12.Location = PreviousFormLocation; 
                form12.Size = PreviousFormSize;
                form12.Show();
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
