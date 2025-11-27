namespace DisKlinik
{
    partial class MainMenu
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TreatmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PrescriptionsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppointmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // TopPanel
            //
            this.TopPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.TopPanel.Controls.Add(this.TreatmentButton);
            this.TopPanel.Controls.Add(this.PrescriptionsButton);
            this.TopPanel.Controls.Add(this.AppointmentButton);
            this.TopPanel.Controls.Add(this.PatientButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 0;
            //
            // TreatmentButton
            //
            this.TreatmentButton.BorderRadius = 10;
            this.TreatmentButton.BorderThickness = 3;
            this.TreatmentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TreatmentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TreatmentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TreatmentButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TreatmentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TreatmentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TreatmentButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TreatmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TreatmentButton.ForeColor = System.Drawing.Color.White;
            this.TreatmentButton.Location = new System.Drawing.Point(422, 26);
            this.TreatmentButton.Name = "TreatmentButton";
            this.TreatmentButton.Size = new System.Drawing.Size(180, 45);
            this.TreatmentButton.TabIndex = 1;
            this.TreatmentButton.Text = "Tedavi";
            this.TreatmentButton.Click += new System.EventHandler(this.TreatmentButton_Click);
            //
            // PrescriptionsButton
            //
            this.PrescriptionsButton.BorderRadius = 10;
            this.PrescriptionsButton.BorderThickness = 3;
            this.PrescriptionsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrescriptionsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrescriptionsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrescriptionsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrescriptionsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrescriptionsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PrescriptionsButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrescriptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrescriptionsButton.ForeColor = System.Drawing.Color.White;
            this.PrescriptionsButton.Location = new System.Drawing.Point(608, 26);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(180, 45);
            this.PrescriptionsButton.TabIndex = 2;
            this.PrescriptionsButton.Text = "Re�eteler";
            this.PrescriptionsButton.Click += new System.EventHandler(this.PrescriptionsButton_Click);
            //
            // AppointmentButton
            //
            this.AppointmentButton.BorderRadius = 10;
            this.AppointmentButton.BorderThickness = 3;
            this.AppointmentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppointmentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppointmentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppointmentButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppointmentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppointmentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppointmentButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AppointmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AppointmentButton.ForeColor = System.Drawing.Color.White;
            this.AppointmentButton.Location = new System.Drawing.Point(224, 26);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(180, 45);
            this.AppointmentButton.TabIndex = 1;
            this.AppointmentButton.Text = "Randevu";
            this.AppointmentButton.Click += new System.EventHandler(this.AppointmentButton_Click);
            //
            // PatientButton
            //
            this.PatientButton.BorderRadius = 10;
            this.PatientButton.BorderThickness = 3;
            this.PatientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PatientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PatientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PatientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PatientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PatientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PatientButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PatientButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PatientButton.ForeColor = System.Drawing.Color.White;
            this.PatientButton.Location = new System.Drawing.Point(25, 26);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(180, 45);
            this.PatientButton.TabIndex = 0;
            this.PatientButton.Text = "Hasta";
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            //
            // HeaderLabel
            //
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.Location = new System.Drawing.Point(306, 117);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(192, 18);
            this.HeaderLabel.TabIndex = 7;
            this.HeaderLabel.Text = "BURSA DENTAL KL�N�K";
            //
            // pictureBox1
            //
            this.pictureBox1.Image = global::DisKlinik.Properties.Resources.Love_That_Design_Serenity_Dental_Clinic_Dubai_4_1728x1152_2675435435;
            this.pictureBox1.Location = new System.Drawing.Point(0, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            //
            // Anasayfa
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2GradientButton PatientButton;
        private Guna.UI2.WinForms.Guna2GradientButton TreatmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PrescriptionsButton;
        private Guna.UI2.WinForms.Guna2GradientButton AppointmentButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
