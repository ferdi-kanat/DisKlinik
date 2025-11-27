namespace DisKlinik
{
    partial class TreatmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SaveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TreatmentNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BackLabel = new System.Windows.Forms.Label();
            this.TreatmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PrescriptionsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppointmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.TreatmentNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CostTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TreatmentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.SearchTextBox.BorderRadius = 10;
            this.SearchTextBox.BorderThickness = 3;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(384, 135);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 32);
            this.SearchTextBox.TabIndex = 65;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.BorderThickness = 3;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(202, 430);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 31);
            this.DeleteButton.TabIndex = 64;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BorderRadius = 10;
            this.UpdateButton.BorderThickness = 3;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(105, 430);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(91, 31);
            this.UpdateButton.TabIndex = 62;
            this.UpdateButton.Text = "D�zenle";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BorderRadius = 10;
            this.SaveButton.BorderThickness = 3;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(8, 430);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 31);
            this.SaveButton.TabIndex = 61;
            this.SaveButton.Text = "Kaydet";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TreatmentNameLabel
            // 
            this.TreatmentNameLabel.AutoSize = true;
            this.TreatmentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TreatmentNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreatmentNameLabel.Location = new System.Drawing.Point(9, 229);
            this.TreatmentNameLabel.Name = "TreatmentNameLabel";
            this.TreatmentNameLabel.Size = new System.Drawing.Size(102, 19);
            this.TreatmentNameLabel.TabIndex = 56;
            this.TreatmentNameLabel.Text = "Tedavi Ad�:";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.Location = new System.Drawing.Point(294, 103);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(198, 18);
            this.HeaderLabel.TabIndex = 55;
            this.HeaderLabel.Text = "BURSA DENTAL KL�N�K";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.TopPanel.Controls.Add(this.BackLabel);
            this.TopPanel.Controls.Add(this.TreatmentButton);
            this.TopPanel.Controls.Add(this.PrescriptionsButton);
            this.TopPanel.Controls.Add(this.AppointmentButton);
            this.TopPanel.Controls.Add(this.PatientButton);
            this.TopPanel.Controls.Add(this.ExitLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 54;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackLabel.Location = new System.Drawing.Point(12, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(49, 23);
            this.BackLabel.TabIndex = 77;
            this.BackLabel.Text = "<<<";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
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
            this.TreatmentButton.FillColor2 = System.Drawing.Color.Red;
            this.TreatmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TreatmentButton.ForeColor = System.Drawing.Color.White;
            this.TreatmentButton.Location = new System.Drawing.Point(407, 36);
            this.TreatmentButton.Name = "TreatmentButton";
            this.TreatmentButton.Size = new System.Drawing.Size(180, 45);
            this.TreatmentButton.TabIndex = 5;
            this.TreatmentButton.Text = "Tedavi";
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
            this.PrescriptionsButton.Location = new System.Drawing.Point(593, 36);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(180, 45);
            this.PrescriptionsButton.TabIndex = 7;
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
            this.AppointmentButton.Location = new System.Drawing.Point(209, 36);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(180, 45);
            this.AppointmentButton.TabIndex = 6;
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
            this.PatientButton.Location = new System.Drawing.Point(10, 36);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(180, 45);
            this.PatientButton.TabIndex = 4;
            this.PatientButton.Text = "Hasta";
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitLabel.Location = new System.Drawing.Point(766, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 28);
            this.ExitLabel.TabIndex = 3;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // TreatmentNameTextBox
            // 
            this.TreatmentNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TreatmentNameTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.TreatmentNameTextBox.BorderRadius = 10;
            this.TreatmentNameTextBox.BorderThickness = 3;
            this.TreatmentNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TreatmentNameTextBox.DefaultText = "";
            this.TreatmentNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TreatmentNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TreatmentNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TreatmentNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TreatmentNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TreatmentNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.TreatmentNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentNameTextBox.Location = new System.Drawing.Point(121, 225);
            this.TreatmentNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TreatmentNameTextBox.Name = "TreatmentNameTextBox";
            this.TreatmentNameTextBox.PlaceholderText = "";
            this.TreatmentNameTextBox.SelectedText = "";
            this.TreatmentNameTextBox.Size = new System.Drawing.Size(172, 32);
            this.TreatmentNameTextBox.TabIndex = 71;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CostTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.CostTextBox.BorderRadius = 10;
            this.CostTextBox.BorderThickness = 3;
            this.CostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostTextBox.DefaultText = "";
            this.CostTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CostTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CostTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostTextBox.Location = new System.Drawing.Point(121, 263);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.PlaceholderText = "";
            this.CostTextBox.SelectedText = "";
            this.CostTextBox.Size = new System.Drawing.Size(172, 32);
            this.CostTextBox.TabIndex = 73;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CostLabel.Location = new System.Drawing.Point(55, 274);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(50, 19);
            this.CostLabel.TabIndex = 72;
            this.CostLabel.Text = "Tutar:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.DescriptionTextBox.BorderRadius = 10;
            this.DescriptionTextBox.BorderThickness = 3;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTextBox.DefaultText = "";
            this.DescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTextBox.Location = new System.Drawing.Point(121, 301);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PlaceholderText = "";
            this.DescriptionTextBox.SelectedText = "";
            this.DescriptionTextBox.Size = new System.Drawing.Size(172, 32);
            this.DescriptionTextBox.TabIndex = 75;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DescriptionLabel.Location = new System.Drawing.Point(15, 305);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(96, 19);
            this.DescriptionLabel.TabIndex = 74;
            this.DescriptionLabel.Text = "A��klama:";
            // 
            // TreatmentDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TreatmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TreatmentDataGridView.ColumnHeadersHeight = 25;
            this.TreatmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TreatmentDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.TreatmentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TreatmentDataGridView.Location = new System.Drawing.Point(311, 174);
            this.TreatmentDataGridView.Name = "TreatmentDataGridView";
            this.TreatmentDataGridView.RowHeadersVisible = false;
            this.TreatmentDataGridView.RowTemplate.Height = 20;
            this.TreatmentDataGridView.Size = new System.Drawing.Size(465, 288);
            this.TreatmentDataGridView.TabIndex = 76;
            this.TreatmentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TreatmentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TreatmentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TreatmentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TreatmentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TreatmentDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.TreatmentDataGridView.ThemeStyle.ReadOnly = false;
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.Height = 20;
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TreatmentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.TreatmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TreatmentDataGridView_CellClick);
            // 
            // Tedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.TreatmentDataGridView);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.TreatmentNameTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TreatmentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tedavi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedavi";
            this.Load += new System.EventHandler(this.Tedavi_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateButton;
        private Guna.UI2.WinForms.Guna2GradientButton SaveButton;
        private System.Windows.Forms.Label TreatmentNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2TextBox TreatmentNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private Guna.UI2.WinForms.Guna2TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private Guna.UI2.WinForms.Guna2DataGridView TreatmentDataGridView;
        private System.Windows.Forms.Label ExitLabel;
        private Guna.UI2.WinForms.Guna2GradientButton TreatmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PrescriptionsButton;
        private Guna.UI2.WinForms.Guna2GradientButton AppointmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PatientButton;
        private System.Windows.Forms.Label BackLabel;
    }
}
