namespace hms
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.ulog = new System.Windows.Forms.Button();
            this.usign = new System.Windows.Forms.Button();
            this.usercmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ulog
            // 
            this.ulog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ulog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ulog.BackColor = System.Drawing.Color.LightGreen;
            this.ulog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulog.Location = new System.Drawing.Point(603, 331);
            this.ulog.Name = "ulog";
            this.ulog.Size = new System.Drawing.Size(124, 50);
            this.ulog.TabIndex = 0;
            this.ulog.Text = "Login";
            this.ulog.UseVisualStyleBackColor = false;
            this.ulog.Visible = false;
            this.ulog.Click += new System.EventHandler(this.ulog_Click);
            // 
            // usign
            // 
            this.usign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usign.BackColor = System.Drawing.Color.SlateBlue;
            this.usign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usign.Location = new System.Drawing.Point(438, 331);
            this.usign.Name = "usign";
            this.usign.Size = new System.Drawing.Size(118, 50);
            this.usign.TabIndex = 5;
            this.usign.Text = "Signup";
            this.usign.UseVisualStyleBackColor = false;
            this.usign.Visible = false;
            this.usign.Click += new System.EventHandler(this.usign_Click);
            // 
            // usercmb
            // 
            this.usercmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercmb.FormattingEnabled = true;
            this.usercmb.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.usercmb.Location = new System.Drawing.Point(539, 204);
            this.usercmb.Name = "usercmb";
            this.usercmb.Size = new System.Drawing.Size(202, 41);
            this.usercmb.TabIndex = 9;
            this.usercmb.SelectedIndexChanged += new System.EventHandler(this.usercmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "User";
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back.Location = new System.Drawing.Point(757, 488);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(101, 36);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usercmb);
            this.Controls.Add(this.usign);
            this.Controls.Add(this.ulog);
            this.Name = "Form12";
            this.Text = "Form12";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ulog;
        private System.Windows.Forms.Button usign;
        private System.Windows.Forms.ComboBox usercmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
    }
}

