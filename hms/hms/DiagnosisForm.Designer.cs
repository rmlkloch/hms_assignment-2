namespace hms
{
    partial class DiagnosisForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.date_lbl = new System.Windows.Forms.Label();
            this.patientname_textbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.patientid_textbox = new System.Windows.Forms.TextBox();
            this.patientid_lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.diagnosis_richtextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symptoms_richtextbox = new System.Windows.Forms.RichTextBox();
            this.symptoms_lbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.save_btn = new System.Windows.Forms.Button();
            this.removemedicine_btn = new System.Windows.Forms.Button();
            this.addmedicine_button = new System.Windows.Forms.Button();
            this.mwdicines_datagrideview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentplan_richtextbox = new System.Windows.Forms.RichTextBox();
            this.treatmentplan_lbl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mwdicines_datagrideview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.datetimepicker);
            this.tabPage1.Controls.Add(this.date_lbl);
            this.tabPage1.Controls.Add(this.patientname_textbox);
            this.tabPage1.Controls.Add(this.name_lbl);
            this.tabPage1.Controls.Add(this.patientid_textbox);
            this.tabPage1.Controls.Add(this.patientid_lbl);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(761, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient Details";
            // 
            // datetimepicker
            // 
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepicker.Location = new System.Drawing.Point(305, 123);
            this.datetimepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(227, 26);
            this.datetimepicker.TabIndex = 5;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(151, 123);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(45, 20);
            this.date_lbl.TabIndex = 4;
            this.date_lbl.Text = "Date";
            // 
            // patientname_textbox
            // 
            this.patientname_textbox.Location = new System.Drawing.Point(305, 74);
            this.patientname_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientname_textbox.Name = "patientname_textbox";
            this.patientname_textbox.Size = new System.Drawing.Size(227, 26);
            this.patientname_textbox.TabIndex = 3;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(151, 74);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(53, 20);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name";
            // 
            // patientid_textbox
            // 
            this.patientid_textbox.Location = new System.Drawing.Point(305, 36);
            this.patientid_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientid_textbox.Name = "patientid_textbox";
            this.patientid_textbox.Size = new System.Drawing.Size(227, 26);
            this.patientid_textbox.TabIndex = 1;
            // 
            // patientid_lbl
            // 
            this.patientid_lbl.AutoSize = true;
            this.patientid_lbl.Location = new System.Drawing.Point(148, 36);
            this.patientid_lbl.Name = "patientid_lbl";
            this.patientid_lbl.Size = new System.Drawing.Size(83, 20);
            this.patientid_lbl.TabIndex = 0;
            this.patientid_lbl.Text = "Patient ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.diagnosis_richtextbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.symptoms_richtextbox);
            this.tabPage2.Controls.Add(this.symptoms_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(761, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diagnosis Details";
            // 
            // diagnosis_richtextbox
            // 
            this.diagnosis_richtextbox.Location = new System.Drawing.Point(224, 111);
            this.diagnosis_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diagnosis_richtextbox.Name = "diagnosis_richtextbox";
            this.diagnosis_richtextbox.Size = new System.Drawing.Size(331, 73);
            this.diagnosis_richtextbox.TabIndex = 3;
            this.diagnosis_richtextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagnosis";
            // 
            // symptoms_richtextbox
            // 
            this.symptoms_richtextbox.Location = new System.Drawing.Point(224, 27);
            this.symptoms_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.symptoms_richtextbox.Name = "symptoms_richtextbox";
            this.symptoms_richtextbox.Size = new System.Drawing.Size(331, 64);
            this.symptoms_richtextbox.TabIndex = 1;
            this.symptoms_richtextbox.Text = "";
            // 
            // symptoms_lbl
            // 
            this.symptoms_lbl.AutoSize = true;
            this.symptoms_lbl.Location = new System.Drawing.Point(61, 27);
            this.symptoms_lbl.Name = "symptoms_lbl";
            this.symptoms_lbl.Size = new System.Drawing.Size(88, 20);
            this.symptoms_lbl.TabIndex = 0;
            this.symptoms_lbl.Text = "Symptoms";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.save_btn);
            this.tabPage3.Controls.Add(this.removemedicine_btn);
            this.tabPage3.Controls.Add(this.addmedicine_button);
            this.tabPage3.Controls.Add(this.mwdicines_datagrideview);
            this.tabPage3.Controls.Add(this.treatmentplan_richtextbox);
            this.tabPage3.Controls.Add(this.treatmentplan_lbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(761, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Treatment Details";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_btn.Location = new System.Drawing.Point(536, 272);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(111, 52);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // removemedicine_btn
            // 
            this.removemedicine_btn.BackColor = System.Drawing.Color.Salmon;
            this.removemedicine_btn.Location = new System.Drawing.Point(358, 272);
            this.removemedicine_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removemedicine_btn.Name = "removemedicine_btn";
            this.removemedicine_btn.Size = new System.Drawing.Size(158, 52);
            this.removemedicine_btn.TabIndex = 4;
            this.removemedicine_btn.Text = "Remove medicine";
            this.removemedicine_btn.UseVisualStyleBackColor = false;
            this.removemedicine_btn.Click += new System.EventHandler(this.removemedicine_btn_Click);
            // 
            // addmedicine_button
            // 
            this.addmedicine_button.BackColor = System.Drawing.Color.MistyRose;
            this.addmedicine_button.Location = new System.Drawing.Point(219, 272);
            this.addmedicine_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addmedicine_button.Name = "addmedicine_button";
            this.addmedicine_button.Size = new System.Drawing.Size(118, 52);
            this.addmedicine_button.TabIndex = 3;
            this.addmedicine_button.Text = "Add Medicine";
            this.addmedicine_button.UseVisualStyleBackColor = false;
            this.addmedicine_button.Click += new System.EventHandler(this.addmedicine_button_Click);
            // 
            // mwdicines_datagrideview
            // 
            this.mwdicines_datagrideview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mwdicines_datagrideview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.mwdicines_datagrideview.Location = new System.Drawing.Point(219, 119);
            this.mwdicines_datagrideview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mwdicines_datagrideview.Name = "mwdicines_datagrideview";
            this.mwdicines_datagrideview.RowHeadersWidth = 51;
            this.mwdicines_datagrideview.RowTemplate.Height = 24;
            this.mwdicines_datagrideview.Size = new System.Drawing.Size(428, 70);
            this.mwdicines_datagrideview.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dosage";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // treatmentplan_richtextbox
            // 
            this.treatmentplan_richtextbox.Location = new System.Drawing.Point(219, 16);
            this.treatmentplan_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treatmentplan_richtextbox.Name = "treatmentplan_richtextbox";
            this.treatmentplan_richtextbox.Size = new System.Drawing.Size(428, 80);
            this.treatmentplan_richtextbox.TabIndex = 1;
            this.treatmentplan_richtextbox.Text = "";
            this.treatmentplan_richtextbox.TextChanged += new System.EventHandler(this.treatmentplan_richtextbox_TextChanged);
            // 
            // treatmentplan_lbl
            // 
            this.treatmentplan_lbl.AutoSize = true;
            this.treatmentplan_lbl.Location = new System.Drawing.Point(25, 20);
            this.treatmentplan_lbl.Name = "treatmentplan_lbl";
            this.treatmentplan_lbl.Size = new System.Drawing.Size(123, 20);
            this.treatmentplan_lbl.TabIndex = 0;
            this.treatmentplan_lbl.Text = "Treatment Plan";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Wheat;
            this.back.Location = new System.Drawing.Point(631, 417);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(133, 42);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(829, 468);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiagnosisForm";
            this.Text = "Dignosis Form";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mwdicines_datagrideview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox patientname_textbox;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox patientid_textbox;
        private System.Windows.Forms.Label patientid_lbl;
        private System.Windows.Forms.RichTextBox symptoms_richtextbox;
        private System.Windows.Forms.Label symptoms_lbl;
        private System.Windows.Forms.RichTextBox diagnosis_richtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox treatmentplan_richtextbox;
        private System.Windows.Forms.Label treatmentplan_lbl;
        private System.Windows.Forms.DataGridView mwdicines_datagrideview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button removemedicine_btn;
        private System.Windows.Forms.Button addmedicine_button;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button back;
    }
}