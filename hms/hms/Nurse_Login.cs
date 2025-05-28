using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class NurseLogin: Form
    {
        public NurseLogin()
        {
            InitializeComponent();
        }

        private void NurseLogin_Load(object sender, EventArgs e)
        {
            this.Size = Form1.PreviousFormSize;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Form1.PreviousFormLocation;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }

        private void staffid_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string staffId = staffid.Text.Trim();
            string password = Password.Text;

            // Validation
            if (string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Staff ID and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\hms\hms_assignment-main - Complete\hms_assignment-main - Complete\hms_assignment-main\hms\hms\LogIn DB.mdf"";Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM StaffLogin WHERE StaffId = @StaffId AND Password = @Password AND Role = 'Doctor'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffId", staffId);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Doctor login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Redirect to Doctor Dashboard

                            Patient_Registration.PreviousFormSize = this.Size;
                            Patient_Registration.PreviousFormLocation = this.Location;

                            Patient_Registration form1 = new Patient_Registration();

                            form1.StartPosition = FormStartPosition.Manual; // Location එක අතින් සෙට් කරන නිසා Manual කරන්න
                            form1.Location = Form1.PreviousFormLocation;   // Form1 එකට කලින් Location එක දෙන්න
                            form1.Size = Form1.PreviousFormSize;

                            form1.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Doctor credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

        private void reset_Click(object sender, EventArgs e)
        {
            staffid.Text = string.Empty;
            Password.Text = string.Empty;
        }
    }
}
