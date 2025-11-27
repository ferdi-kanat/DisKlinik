namespace DisKlinik
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.CostLabel = new System.Windows.Forms.Label();
            this.MedicationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MedicationLabel = new System.Windows.Forms.Label();
            this.TreatmentTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.PatientComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CostTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PrintButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.QuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PrescriptionDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PrintPreviewDialogReceteler = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocReceteler = new System.Drawing.Printing.PrintDocument();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CostLabel.Location = new System.Drawing.Point(60, 306);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(50, 19);
            this.CostLabel.TabIndex = 89;
            this.CostLabel.Text = "Tutar:";
            // 
            // MedicationTextBox
            // 
            this.MedicationTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.MedicationTextBox.BorderRadius = 10;
            this.MedicationTextBox.BorderThickness = 3;
            this.MedicationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicationTextBox.DefaultText = "";
            this.MedicationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedicationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedicationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicationTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MedicationTextBox.ForeColor = System.Drawing.Color.Black;
            this.MedicationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicationTextBox.Location = new System.Drawing.Point(124, 262);
            this.MedicationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedicationTextBox.Name = "MedicationTextBox";
            this.MedicationTextBox.PlaceholderText = "";
            this.MedicationTextBox.SelectedText = "";
            this.MedicationTextBox.Size = new System.Drawing.Size(172, 32);
            this.MedicationTextBox.TabIndex = 88;
            // 
            // MedicationLabel
            // 
            this.MedicationLabel.AutoSize = true;
            this.MedicationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedicationLabel.Location = new System.Drawing.Point(48, 268);
            this.MedicationLabel.Name = "MedicationLabel";
            this.MedicationLabel.Size = new System.Drawing.Size(68, 19);
            this.MedicationLabel.TabIndex = 87;
            this.MedicationLabel.Text = "�la�lar:";
            // 
            // TreatmentTextBox
            // 
            this.TreatmentTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.TreatmentTextBox.BorderRadius = 10;
            this.TreatmentTextBox.BorderThickness = 3;
            this.TreatmentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TreatmentTextBox.DefaultText = "";
            this.TreatmentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TreatmentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TreatmentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TreatmentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TreatmentTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TreatmentTextBox.ForeColor = System.Drawing.Color.Black;
            this.TreatmentTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TreatmentTextBox.Location = new System.Drawing.Point(124, 224);
            this.TreatmentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TreatmentTextBox.Name = "TreatmentTextBox";
            this.TreatmentTextBox.PlaceholderText = "";
            this.TreatmentTextBox.SelectedText = "";
            this.TreatmentTextBox.Size = new System.Drawing.Size(172, 32);
            this.TreatmentTextBox.TabIndex = 86;
            this.TreatmentTextBox.TextChanged += new System.EventHandler(this.TreatmentTextBox_TextChanged);
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
            this.SearchTextBox.Location = new System.Drawing.Point(387, 134);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 32);
            this.SearchTextBox.TabIndex = 83;
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
            this.DeleteButton.Location = new System.Drawing.Point(221, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 31);
            this.DeleteButton.TabIndex = 82;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.SaveButton.Location = new System.Drawing.Point(124, 403);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 31);
            this.SaveButton.TabIndex = 79;
            this.SaveButton.Text = "Kaydet";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TreatmentNameLabel
            // 
            this.TreatmentNameLabel.AutoSize = true;
            this.TreatmentNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreatmentNameLabel.Location = new System.Drawing.Point(14, 230);
            this.TreatmentNameLabel.Name = "TreatmentNameLabel";
            this.TreatmentNameLabel.Size = new System.Drawing.Size(102, 19);
            this.TreatmentNameLabel.TabIndex = 78;
            this.TreatmentNameLabel.Text = "Tedavi Ad�:";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderLabel.Location = new System.Drawing.Point(293, 103);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(198, 18);
            this.HeaderLabel.TabIndex = 77;
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
            this.TopPanel.TabIndex = 76;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackLabel.Location = new System.Drawing.Point(21, 9);
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
            this.TreatmentButton.Location = new System.Drawing.Point(410, 40);
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
            this.PrescriptionsButton.FillColor2 = System.Drawing.Color.Red;
            this.PrescriptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrescriptionsButton.ForeColor = System.Drawing.Color.White;
            this.PrescriptionsButton.Location = new System.Drawing.Point(596, 40);
            this.PrescriptionsButton.Name = "PrescriptionsButton";
            this.PrescriptionsButton.Size = new System.Drawing.Size(180, 45);
            this.PrescriptionsButton.TabIndex = 6;
            this.PrescriptionsButton.Text = "Re�eteler";
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
            this.AppointmentButton.Location = new System.Drawing.Point(212, 40);
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
            this.PatientButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PatientButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PatientButton.ForeColor = System.Drawing.Color.White;
            this.PatientButton.Location = new System.Drawing.Point(13, 40);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(180, 45);
            this.PatientButton.TabIndex = 3;
            this.PatientButton.Text = "Hasta";
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
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
            this.PatientComboBox.Location = new System.Drawing.Point(124, 182);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(172, 36);
            this.PatientComboBox.TabIndex = 91;
            this.PatientComboBox.SelectionChangeCommitted += new System.EventHandler(this.PatientComboBox_SelectionChangeCommitted);
            // 
            // CostTextBox
            // 
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
            this.CostTextBox.Location = new System.Drawing.Point(124, 300);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.PlaceholderText = "";
            this.CostTextBox.SelectedText = "";
            this.CostTextBox.Size = new System.Drawing.Size(172, 32);
            this.CostTextBox.TabIndex = 90;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientNameLabel.Location = new System.Drawing.Point(21, 192);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(89, 19);
            this.PatientNameLabel.TabIndex = 92;
            this.PatientNameLabel.Text = "Ad Soyad:";
            // 
            // PrintButton
            // 
            this.PrintButton.BorderRadius = 10;
            this.PrintButton.BorderThickness = 3;
            this.PrintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintButton.FillColor = System.Drawing.Color.Indigo;
            this.PrintButton.FillColor2 = System.Drawing.Color.Purple;
            this.PrintButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Location = new System.Drawing.Point(542, 466);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(91, 31);
            this.PrintButton.TabIndex = 93;
            this.PrintButton.Text = "Yazd�r";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.QuantityTextBox.BorderRadius = 10;
            this.QuantityTextBox.BorderThickness = 3;
            this.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextBox.DefaultText = "";
            this.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.QuantityTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.Location = new System.Drawing.Point(124, 340);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PlaceholderText = "";
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.Size = new System.Drawing.Size(172, 32);
            this.QuantityTextBox.TabIndex = 95;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuantityLabel.Location = new System.Drawing.Point(50, 346);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(60, 19);
            this.QuantityLabel.TabIndex = 94;
            this.QuantityLabel.Text = "Miktar:";
            // 
            // PrescriptionDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrescriptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PrescriptionDataGridView.ColumnHeadersHeight = 25;
            this.PrescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrescriptionDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.PrescriptionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDataGridView.Location = new System.Drawing.Point(323, 171);
            this.PrescriptionDataGridView.Name = "PrescriptionDataGridView";
            this.PrescriptionDataGridView.RowHeadersVisible = false;
            this.PrescriptionDataGridView.RowTemplate.Height = 20;
            this.PrescriptionDataGridView.Size = new System.Drawing.Size(465, 288);
            this.PrescriptionDataGridView.TabIndex = 96;
            this.PrescriptionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PrescriptionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PrescriptionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PrescriptionDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.PrescriptionDataGridView.ThemeStyle.ReadOnly = false;
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.Height = 20;
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PrescriptionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionDataGridView_CellClick);
            // 
            // PrintPreviewDialogReceteler
            // 
            this.PrintPreviewDialogReceteler.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogReceteler.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogReceteler.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialogReceteler.Document = this.PrintDocReceteler;
            this.PrintPreviewDialogReceteler.Enabled = true;
            this.PrintPreviewDialogReceteler.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialogReceteler.Icon")));
            this.PrintPreviewDialogReceteler.Name = "printPreviewDialog1";
            this.PrintPreviewDialogReceteler.Text = "Bask� �nizleme";
            this.PrintPreviewDialogReceteler.Visible = false;
            // 
            // PrintDocReceteler
            // 
            this.PrintDocReceteler.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocReceteler_PrintPage);
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.PrescriptionDataGridView);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MedicationTextBox);
            this.Controls.Add(this.MedicationLabel);
            this.Controls.Add(this.TreatmentTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TreatmentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receteler";
            this.Load += new System.EventHandler(this.Receteler_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CostLabel;
        private Guna.UI2.WinForms.Guna2TextBox MedicationTextBox;
        private System.Windows.Forms.Label MedicationLabel;
        private Guna.UI2.WinForms.Guna2TextBox TreatmentTextBox;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton SaveButton;
        private System.Windows.Forms.Label TreatmentNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ExitLabel;
        private Guna.UI2.WinForms.Guna2ComboBox PatientComboBox;
        private Guna.UI2.WinForms.Guna2TextBox CostTextBox;
        private System.Windows.Forms.Label PatientNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton PrintButton;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label BackLabel;
        private Guna.UI2.WinForms.Guna2GradientButton TreatmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PrescriptionsButton;
        private Guna.UI2.WinForms.Guna2GradientButton AppointmentButton;
        private Guna.UI2.WinForms.Guna2GradientButton PatientButton;
        private Guna.UI2.WinForms.Guna2DataGridView PrescriptionDataGridView;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialogReceteler;
        private System.Drawing.Printing.PrintDocument PrintDocReceteler;
    }
}
