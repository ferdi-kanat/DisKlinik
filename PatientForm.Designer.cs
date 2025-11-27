namespace DisKlinik
{
    partial class PatientForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BackLabel = new System.Windows.Forms.Label();
            this.TreatmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PrescriptionsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppointmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AllergyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AllergyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.TopPanel.TabIndex = 1;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackLabel.Location = new System.Drawing.Point(12, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(49, 23);
            this.BackLabel.TabIndex = 30;
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
            this.TreatmentButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TreatmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TreatmentButton.ForeColor = System.Drawing.Color.White;
            this.TreatmentButton.Location = new System.Drawing.Point(410, 34);
            this.TreatmentButton.Name = "TreatmentButton";
            this.TreatmentButton.Size = new System.Drawing.Size(180, 45);
            this.TreatmentButton.TabIndex = 4;
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
            this.PrescriptionsButton.Location = new System.Drawing.Point(596, 34);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(180, 45);
            this.PrescriptionsButton.TabIndex = 6;
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
            this.AppointmentButton.Location = new System.Drawing.Point(212, 34);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(180, 45);
            this.AppointmentButton.TabIndex = 5;
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
            this.PatientButton.FillColor2 = System.Drawing.Color.Red;
            this.PatientButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PatientButton.ForeColor = System.Drawing.Color.White;
            this.PatientButton.Location = new System.Drawing.Point(13, 34);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(180, 45);
            this.PatientButton.TabIndex = 3;
            this.PatientButton.Text = "Hasta";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitLabel.Location = new System.Drawing.Point(766, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 28);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.Location = new System.Drawing.Point(297, 103);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(198, 18);
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "BURSA DENTAL KL�N�K";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PatientNameTextBox.BorderRadius = 10;
            this.PatientNameTextBox.BorderThickness = 3;
            this.PatientNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTextBox.DefaultText = "";
            this.PatientNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.PatientNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(123, 185);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.PlaceholderText = "";
            this.PatientNameTextBox.SelectedText = "";
            this.PatientNameTextBox.Size = new System.Drawing.Size(172, 32);
            this.PatientNameTextBox.TabIndex = 10;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.Location = new System.Drawing.Point(27, 192);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(89, 19);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Ad Soyad:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PhoneTextBox.BorderRadius = 10;
            this.PhoneTextBox.BorderThickness = 3;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.DefaultText = "";
            this.PhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PhoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Location = new System.Drawing.Point(123, 224);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PlaceholderText = "";
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.Size = new System.Drawing.Size(172, 32);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneLabel.Location = new System.Drawing.Point(48, 230);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(68, 19);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Telefon:";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirthDateLabel.Location = new System.Drawing.Point(0, 273);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(115, 19);
            this.BirthDateLabel.TabIndex = 13;
            this.BirthDateLabel.Text = "Do�um Tarihi:";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.BirthDatePicker.BorderColor = System.Drawing.Color.CadetBlue;
            this.BirthDatePicker.BorderRadius = 10;
            this.BirthDatePicker.BorderThickness = 3;
            this.BirthDatePicker.Checked = true;
            this.BirthDatePicker.FillColor = System.Drawing.Color.White;
            this.BirthDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BirthDatePicker.ForeColor = System.Drawing.Color.Black;
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(123, 263);
            this.BirthDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(172, 36);
            this.BirthDatePicker.TabIndex = 15;
            this.BirthDatePicker.Value = new System.DateTime(2025, 11, 19, 10, 36, 46, 896);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderLabel.Location = new System.Drawing.Point(48, 316);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(72, 19);
            this.GenderLabel.TabIndex = 16;
            this.GenderLabel.Text = "Cinsiyet:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderComboBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.GenderComboBox.BorderRadius = 10;
            this.GenderComboBox.BorderThickness = 3;
            this.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.GenderComboBox.ForeColor = System.Drawing.Color.Black;
            this.GenderComboBox.ItemHeight = 30;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Kadin",
            "Erkek"});
            this.GenderComboBox.Location = new System.Drawing.Point(123, 306);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(172, 36);
            this.GenderComboBox.TabIndex = 17;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.AddressTextBox.BorderRadius = 10;
            this.AddressTextBox.BorderThickness = 3;
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.DefaultText = "";
            this.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Location = new System.Drawing.Point(123, 388);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PlaceholderText = "";
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.Size = new System.Drawing.Size(172, 32);
            this.AddressTextBox.TabIndex = 19;
            // 
            // AllergyTextBox
            // 
            this.AllergyTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.AllergyTextBox.BorderRadius = 10;
            this.AllergyTextBox.BorderThickness = 3;
            this.AllergyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AllergyTextBox.DefaultText = "";
            this.AllergyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AllergyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AllergyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AllergyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AllergyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllergyTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AllergyTextBox.ForeColor = System.Drawing.Color.Black;
            this.AllergyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllergyTextBox.Location = new System.Drawing.Point(123, 349);
            this.AllergyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllergyTextBox.Name = "AllergyTextBox";
            this.AllergyTextBox.PlaceholderText = "";
            this.AllergyTextBox.SelectedText = "";
            this.AllergyTextBox.Size = new System.Drawing.Size(172, 32);
            this.AllergyTextBox.TabIndex = 18;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressLabel.Location = new System.Drawing.Point(59, 396);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(57, 19);
            this.AddressLabel.TabIndex = 21;
            this.AddressLabel.Text = "Adres:";
            // 
            // AllergyLabel
            // 
            this.AllergyLabel.AutoSize = true;
            this.AllergyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllergyLabel.Location = new System.Drawing.Point(64, 358);
            this.AllergyLabel.Name = "AllergyLabel";
            this.AllergyLabel.Size = new System.Drawing.Size(52, 19);
            this.AllergyLabel.TabIndex = 20;
            this.AllergyLabel.Text = "Alerji:";
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
            this.SaveButton.Location = new System.Drawing.Point(10, 442);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 31);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Kaydet";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.UpdateButton.Location = new System.Drawing.Point(107, 442);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(91, 31);
            this.UpdateButton.TabIndex = 24;
            this.UpdateButton.Text = "D�zenle";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // PatientDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.PatientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PatientDataGridView.ColumnHeadersHeight = 25;
            this.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.PatientDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGridView.Location = new System.Drawing.Point(325, 185);
            this.PatientDataGridView.Name = "PatientDataGridView";
            this.PatientDataGridView.RowHeadersVisible = false;
            this.PatientDataGridView.RowTemplate.Height = 20;
            this.PatientDataGridView.Size = new System.Drawing.Size(465, 288);
            this.PatientDataGridView.TabIndex = 25;
            this.PatientDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.PatientDataGridView.ThemeStyle.ReadOnly = false;
            this.PatientDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDataGridView.ThemeStyle.RowsStyle.Height = 20;
            this.PatientDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PatientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDataGridView_CellClick);
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
            this.DeleteButton.Location = new System.Drawing.Point(204, 442);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 31);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchTextBox
            // 
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
            this.SearchTextBox.Location = new System.Drawing.Point(418, 135);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 32);
            this.SearchTextBox.TabIndex = 27;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PatientDataGridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AllergyLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AllergyTextBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private Guna.UI2.WinForms.Guna2TextBox PatientNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label GenderLabel;
        private Guna.UI2.WinForms.Guna2ComboBox GenderComboBox;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AllergyTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label AllergyLabel;
        private Guna.UI2.WinForms.Guna2GradientButton SaveButton;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateButton;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDataGridView;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteButton;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton TreatmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PrescriptionsButton;
        private Guna.UI2.WinForms.Guna2GradientButton AppointmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PatientButton;
        private System.Windows.Forms.Label BackLabel;
    }
}

