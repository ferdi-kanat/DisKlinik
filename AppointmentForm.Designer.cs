namespace DisKlinik
{
    partial class AppointmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SaveButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AppointmentDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.TreatmentLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BackLabel = new System.Windows.Forms.Label();
            this.TreatmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PrescriptionsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppointmentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppointmentTimeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TreatmentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AppointmentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.SearchTextBox.Location = new System.Drawing.Point(384, 135);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 32);
            this.SearchTextBox.TabIndex = 48;
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
            this.DeleteButton.TabIndex = 47;
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
            this.UpdateButton.TabIndex = 46;
            this.UpdateButton.Text = "Düzenle";
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
            this.SaveButton.Location = new System.Drawing.Point(93, 430);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 31);
            this.SaveButton.TabIndex = 44;
            this.SaveButton.Text = "Kaydet";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PatientComboBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PatientComboBox.BorderRadius = 10;
            this.PatientComboBox.BorderThickness = 3;
            this.PatientComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.PatientComboBox.ForeColor = System.Drawing.Color.Black;
            this.PatientComboBox.ItemHeight = 30;
            this.PatientComboBox.Items.AddRange(new object[] {
            "Kad�n",
            "Erkek"});
            this.PatientComboBox.Location = new System.Drawing.Point(93, 192);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(172, 36);
            this.PatientComboBox.TabIndex = 39;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentDatePicker.BorderColor = System.Drawing.Color.CadetBlue;
            this.AppointmentDatePicker.BorderRadius = 10;
            this.AppointmentDatePicker.BorderThickness = 3;
            this.AppointmentDatePicker.Checked = true;
            this.AppointmentDatePicker.FillColor = System.Drawing.Color.White;
            this.AppointmentDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AppointmentDatePicker.ForeColor = System.Drawing.Color.Black;
            this.AppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppointmentDatePicker.Location = new System.Drawing.Point(93, 235);
            this.AppointmentDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AppointmentDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(172, 36);
            this.AppointmentDatePicker.TabIndex = 37;
            this.AppointmentDatePicker.Value = new System.DateTime(2024, 6, 6, 1, 20, 12, 815);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateLabel.Location = new System.Drawing.Point(37, 244);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 19);
            this.DateLabel.TabIndex = 36;
            this.DateLabel.Text = "Tarih:";
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientLabel.Location = new System.Drawing.Point(2, 201);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(89, 19);
            this.PatientLabel.TabIndex = 32;
            this.PatientLabel.Text = "Ad Soyad:";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.Location = new System.Drawing.Point(294, 103);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(192, 18);
            this.HeaderLabel.TabIndex = 31;
            this.HeaderLabel.Text = "BURSA DENTAL KLİNİK";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitLabel.Location = new System.Drawing.Point(757, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 28);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // TreatmentLabel
            // 
            this.TreatmentLabel.AutoSize = true;
            this.TreatmentLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreatmentLabel.Location = new System.Drawing.Point(21, 330);
            this.TreatmentLabel.Name = "TreatmentLabel";
            this.TreatmentLabel.Size = new System.Drawing.Size(65, 19);
            this.TreatmentLabel.TabIndex = 38;
            this.TreatmentLabel.Text = "Tedavi:";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.TopPanel.Controls.Add(this.BottomPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 100);
            this.TopPanel.TabIndex = 30;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.BottomPanel.Controls.Add(this.BackLabel);
            this.BottomPanel.Controls.Add(this.ExitLabel);
            this.BottomPanel.Controls.Add(this.TreatmentButton);
            this.BottomPanel.Controls.Add(this.PrescriptionsButton);
            this.BottomPanel.Controls.Add(this.AppointmentButton);
            this.BottomPanel.Controls.Add(this.PatientButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 100);
            this.BottomPanel.TabIndex = 1;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackLabel.Location = new System.Drawing.Point(12, 12);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(49, 23);
            this.BackLabel.TabIndex = 7;
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
            this.TreatmentButton.Location = new System.Drawing.Point(431, 25);
            this.TreatmentButton.Name = "TreatmentButton";
            this.TreatmentButton.Size = new System.Drawing.Size(150, 45);
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
            this.PrescriptionsButton.Location = new System.Drawing.Point(600, 25);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(150, 45);
            this.PrescriptionsButton.TabIndex = 2;
            this.PrescriptionsButton.Text = "Reçeteler";
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
            this.AppointmentButton.FillColor2 = System.Drawing.Color.Red;
            this.AppointmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AppointmentButton.ForeColor = System.Drawing.Color.White;
            this.AppointmentButton.Location = new System.Drawing.Point(256, 25);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(150, 45);
            this.AppointmentButton.TabIndex = 1;
            this.AppointmentButton.Text = "Randevu";
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
            this.PatientButton.Location = new System.Drawing.Point(73, 25);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(150, 45);
            this.PatientButton.TabIndex = 0;
            this.PatientButton.Text = "Hasta";
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // AppointmentTimeComboBox
            // 
            this.AppointmentTimeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentTimeComboBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.AppointmentTimeComboBox.BorderRadius = 10;
            this.AppointmentTimeComboBox.BorderThickness = 3;
            this.AppointmentTimeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AppointmentTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppointmentTimeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppointmentTimeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppointmentTimeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.AppointmentTimeComboBox.ForeColor = System.Drawing.Color.Black;
            this.AppointmentTimeComboBox.ItemHeight = 30;
            this.AppointmentTimeComboBox.Items.AddRange(new object[] {
            "09.00-10.00",
            "10.30-11.30",
            "12.00-13.00",
            "13.30-14.30"});
            this.AppointmentTimeComboBox.Location = new System.Drawing.Point(93, 277);
            this.AppointmentTimeComboBox.Name = "AppointmentTimeComboBox";
            this.AppointmentTimeComboBox.Size = new System.Drawing.Size(172, 36);
            this.AppointmentTimeComboBox.TabIndex = 51;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeLabel.Location = new System.Drawing.Point(39, 290);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(47, 19);
            this.TimeLabel.TabIndex = 52;
            this.TimeLabel.Text = "Saat:";
            // 
            // TreatmentComboBox
            // 
            this.TreatmentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TreatmentComboBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.TreatmentComboBox.BorderRadius = 10;
            this.TreatmentComboBox.BorderThickness = 3;
            this.TreatmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TreatmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TreatmentComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.TreatmentComboBox.ForeColor = System.Drawing.Color.Black;
            this.TreatmentComboBox.ItemHeight = 30;
            this.TreatmentComboBox.Items.AddRange(new object[] {
            "Dolgu",
            "�ekim",
            "Kanal Tedavi",
            "Di� Ta�� Temizleme"});
            this.TreatmentComboBox.Location = new System.Drawing.Point(93, 319);
            this.TreatmentComboBox.Name = "TreatmentComboBox";
            this.TreatmentComboBox.Size = new System.Drawing.Size(172, 36);
            this.TreatmentComboBox.TabIndex = 53;
            // 
            // AppointmentDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentDataGridView.ColumnHeadersHeight = 25;
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentDataGridView.Location = new System.Drawing.Point(323, 174);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.RowHeadersVisible = false;
            this.AppointmentDataGridView.RowTemplate.Height = 20;
            this.AppointmentDataGridView.Size = new System.Drawing.Size(465, 288);
            this.AppointmentDataGridView.TabIndex = 77;
            this.AppointmentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AppointmentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AppointmentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AppointmentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AppointmentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AppointmentDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.AppointmentDataGridView.ThemeStyle.ReadOnly = false;
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.Height = 20;
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AppointmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellClick);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.AppointmentDataGridView);
            this.Controls.Add(this.TreatmentComboBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.AppointmentTimeComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PatientLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TreatmentLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateButton;
        private Guna.UI2.WinForms.Guna2GradientButton SaveButton;
        private Guna.UI2.WinForms.Guna2ComboBox PatientComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label TreatmentLabel;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ComboBox AppointmentTimeComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox TreatmentComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Panel BottomPanel;
        private Guna.UI2.WinForms.Guna2GradientButton TreatmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PrescriptionsButton;
        private Guna.UI2.WinForms.Guna2GradientButton AppointmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PatientButton;
        private System.Windows.Forms.Label BackLabel;
    }
}
