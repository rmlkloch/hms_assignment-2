using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hms
{
    public partial class staffsignin: Form
    {
        private string userType;

        public staffsignin(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }
        public staffsignin()
        {
            InitializeComponent();
        }

        public static class AppSettings
        {
            // DefaultFormSize ekata gannawa
            public static System.Drawing.Size DefaultFormSize;

            // DefaultFormLocation
            public static System.Drawing.Point DefaultFormLocation;
            static AppSettings()
            {
                // Working area eke size eka gannawa.
                DefaultFormSize = Screen.PrimaryScreen.WorkingArea.Size;

                // form eka screen eke left top corner ekata set karanna.
                DefaultFormLocation = new System.Drawing.Point(0, 0);
            }
        }

        private void staffsignin_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbrole.SelectedItem.ToString();

            doctorgb.Visible = (selectedRole == "Doctor");
            nursegb.Visible = (selectedRole == "Nurse");
            PBD.Visible = (selectedRole == "Doctor");
            PBN.Visible = (selectedRole == "Nurse");
            lbrole.Visible = !((selectedRole == "Doctor") || (selectedRole == "Nurse"));
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            // Step 01: Create the connection string
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\hms\hms_assignment-main - Complete\hms_assignment-main - Complete\hms_assignment-main\hms\hms\StaffReg DB.mdf"";Integrated Security=True");

            // Step 02: Read input values
            string id = textBox1.Text.Trim();
            string name = txtname.Text.Trim();
            string role = cmbrole.Text;
            string department = cmbDepartment.Text;
            string phone = txtphone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = cmbgender.Text;
            DateTime DOB = dob_picker.Value.Date;
            DateTime joinDate = joindate_picker.Value.Date;
            string Medical_Licence_No = mln.Text.Trim();
            string Specilization = cmbspecialization.Text;
            string nurse_Id = nid.Text.Trim();
            string ward = cmbward.Text;
            string experiance = txtexperience.Text.Trim();

            // Step 03: Validate the input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 04: Handle image (convert to byte array)
            byte[] imageData;
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Step 05: Define the query with parameters (no SQL injection)
                string query = "INSERT INTO StaffReg (name, role, department, phone, email, gender, DOB, joinDate, Medical_Licence_No, Specilization, nurse_Id, ward, experiance, image) " +
                               "VALUES (@name, @role, @department, @phone, @email, @gender, @DOB, @joinDate, @Medical_Licence_No, @Specilization, @nurse_Id, @ward, @experiance, @image)";

                // Step 06: Prepare SQL command
                SqlCommand cmd1 = new SqlCommand(query, con1);

                // Step 07: Bind values to parameters
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@role", role);
                cmd1.Parameters.AddWithValue("@department", department);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@gender", gender);
                cmd1.Parameters.AddWithValue("@DOB", DOB);
                cmd1.Parameters.AddWithValue("@joinDate", joinDate);
                cmd1.Parameters.AddWithValue("@Medical_Licence_No", Medical_Licence_No);
                cmd1.Parameters.AddWithValue("@Specilization", Specilization);
                cmd1.Parameters.AddWithValue("@nurse_Id", nurse_Id);
                cmd1.Parameters.AddWithValue("@ward", ward);
                cmd1.Parameters.AddWithValue("@experiance", experiance);
                cmd1.Parameters.AddWithValue("@image", imageData);

                // Step 08: Execute the command
                con1.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show($"Registered {name} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Step 09: Always close the connection
                if (con1.State == ConnectionState.Open)
                    con1.Close();
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
