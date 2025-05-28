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
    public partial class Form12: Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Form1.PreviousFormSize;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Form1.PreviousFormLocation;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void usercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();

            if (selectedUserType == "Doctor" || selectedUserType == "Nurse")
            {
                usign.Visible = true;
                ulog.Visible = true;
            }
            else if (selectedUserType == "Patient")
            {
                usign.Visible = false;
                ulog.Visible = false;
                // patient form eka
                paymentForm patientForm = new paymentForm();
                patientForm.Show();
                this.Hide();
            }
        }

        private void usign_Click(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();
            staffsignin commonSignupForm = new staffsignin (selectedUserType);
            commonSignupForm.Show();
            this.Hide();
        }

        private void ulog_Click(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();
            if (selectedUserType == "Doctor")
            {
                // Doctor login form eka open karanawa
                DoctorLogin doctorLoginForm = new DoctorLogin();
                doctorLoginForm.Show();
                this.Hide();
            }
            else if (selectedUserType == "Nurse")
            {
                // Nurse login form eka open karanawa
                NurseLogin nurseLoginForm = new NurseLogin();
                nurseLoginForm.Show();
                this.Hide();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1.PreviousFormSize = this.Size;
            Form1.PreviousFormLocation = this.Location;

            Form1 form1 = new Form1();

            form1.StartPosition = FormStartPosition.Manual; // Location එක අතින් සෙට් කරන නිසා Manual කරන්න
            form1.Location = Form1.PreviousFormLocation;   // Form1 එකට කලින් Location එක දෙන්න
            form1.Size = Form1.PreviousFormSize;

            form1.Show();

            this.Hide();


        }
    }
}
