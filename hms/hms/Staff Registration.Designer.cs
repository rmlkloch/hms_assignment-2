namespace hms
{
    partial class staffsignin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffsignin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.joindate_picker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nursegb = new System.Windows.Forms.GroupBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbward = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.doctorgb = new System.Windows.Forms.GroupBox();
            this.cmbspecialization = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mln = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.nursegb.SuspendLayout();
            this.doctorgb.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(504, 42);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(244, 30);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role";
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.cmbrole.Location = new System.Drawing.Point(130, 109);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(194, 33);
            this.cmbrole.TabIndex = 2;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.cmbrole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(130, 189);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(240, 30);
            this.txtphone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbgender.Location = new System.Drawing.Point(130, 269);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(136, 33);
            this.cmbgender.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of Birth";
            // 
            // dob_picker
            // 
            this.dob_picker.Location = new System.Drawing.Point(168, 362);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(224, 30);
            this.dob_picker.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(51, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 506);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.joindate_picker);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbDepartment);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dob_picker);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtname);
            this.tabPage1.Controls.Add(this.cmbgender);
            this.tabPage1.Controls.Add(this.cmbrole);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtphone);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(871, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Information";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(549, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(416, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "NIC";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 15;
            // 
            // joindate_picker
            // 
            this.joindate_picker.Location = new System.Drawing.Point(549, 360);
            this.joindate_picker.Name = "joindate_picker";
            this.joindate_picker.Size = new System.Drawing.Size(224, 30);
            this.joindate_picker.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Join Date";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "General Medicine(සාමාන්‍ය වෛද්‍ය)",
            "Pediatrics(ළමා රෝග)",
            "General Surgery(ශල්‍ය වෛද්‍ය)",
            "Ophthalmology(අක්ෂි රෝග)",
            "Cardiology(හෘද රෝග)"});
            this.cmbDepartment.Location = new System.Drawing.Point(549, 108);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(272, 33);
            this.cmbDepartment.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.nursegb);
            this.tabPage2.Controls.Add(this.doctorgb);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(871, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role-Specific Fields";
            // 
            // nursegb
            // 
            this.nursegb.Controls.Add(this.txtexperience);
            this.nursegb.Controls.Add(this.label14);
            this.nursegb.Controls.Add(this.cmbward);
            this.nursegb.Controls.Add(this.label12);
            this.nursegb.Controls.Add(this.nid);
            this.nursegb.Controls.Add(this.label13);
            this.nursegb.Controls.Add(this.label10);
            this.nursegb.Location = new System.Drawing.Point(132, 209);
            this.nursegb.Name = "nursegb";
            this.nursegb.Size = new System.Drawing.Size(598, 231);
            this.nursegb.TabIndex = 11;
            this.nursegb.TabStop = false;
            this.nursegb.Text = "NursegroupBox";
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(182, 177);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(199, 30);
            this.txtexperience.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Experience";
            // 
            // cmbward
            // 
            this.cmbward.FormattingEnabled = true;
            this.cmbward.Items.AddRange(new object[] {
            "General Ward",
            "Surgical Ward",
            "Pediatric Ward",
            "Cardiology Ward",
            "Emergency Treatment Unit"});
            this.cmbward.Location = new System.Drawing.Point(182, 120);
            this.cmbward.Name = "cmbward";
            this.cmbward.Size = new System.Drawing.Size(199, 33);
            this.cmbward.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ward";
            // 
            // nid
            // 
            this.nid.Location = new System.Drawing.Point(182, 68);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(199, 30);
            this.nid.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nursing ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nurse";
            // 
            // doctorgb
            // 
            this.doctorgb.Controls.Add(this.cmbspecialization);
            this.doctorgb.Controls.Add(this.label11);
            this.doctorgb.Controls.Add(this.mln);
            this.doctorgb.Controls.Add(this.label9);
            this.doctorgb.Controls.Add(this.label8);
            this.doctorgb.Location = new System.Drawing.Point(98, 22);
            this.doctorgb.Name = "doctorgb";
            this.doctorgb.Size = new System.Drawing.Size(658, 182);
            this.doctorgb.TabIndex = 10;
            this.doctorgb.TabStop = false;
            this.doctorgb.Text = "DoctorgroupBox";
            // 
            // cmbspecialization
            // 
            this.cmbspecialization.FormattingEnabled = true;
            this.cmbspecialization.Items.AddRange(new object[] {
            "Hospital Medicine",
            "Neonatology",
            "Trauma and Critical Care Surgery",
            "Retina and Vitreous",
            "Heart Failure and Transplant Cardiology"});
            this.cmbspecialization.Location = new System.Drawing.Point(242, 123);
            this.cmbspecialization.Name = "cmbspecialization";
            this.cmbspecialization.Size = new System.Drawing.Size(199, 33);
            this.cmbspecialization.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Specialization";
            // 
            // mln
            // 
            this.mln.Location = new System.Drawing.Point(242, 74);
            this.mln.Name = "mln";
            this.mln.Size = new System.Drawing.Size(199, 30);
            this.mln.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Medical License No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doctor";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.clear);
            this.tabPage3.Controls.Add(this.save);
            this.tabPage3.Controls.Add(this.browse);
            this.tabPage3.Controls.Add(this.pictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(871, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Image Upload";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.Location = new System.Drawing.Point(628, 180);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(134, 69);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(628, 69);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 69);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.browse.Location = new System.Drawing.Point(417, 162);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(136, 57);
            this.browse.TabIndex = 1;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Location = new System.Drawing.Point(48, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(340, 343);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Location = new System.Drawing.Point(756, 566);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(142, 57);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // staffsignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(966, 640);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.back);
            this.Name = "staffsignin";
            this.Text = "Staff_Registration";
            this.Load += new System.EventHandler(this.staffsignin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.nursegb.ResumeLayout(false);
            this.nursegb.PerformLayout();
            this.doctorgb.ResumeLayout(false);
            this.doctorgb.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker joindate_picker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbward;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbspecialization;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mln;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox nursegb;
        private System.Windows.Forms.GroupBox doctorgb;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}