using DisKlinik.Business;
using DisKlinik.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DisKlinik
{
    public partial class PrescriptionForm : Form
    {
        #region Fields & Constants

        private int? _selectedPrescriptionId;
        private readonly PrescriptionManager _prescriptionManager;
        Bitmap bitmap;

        #endregion

        #region Constructor

        public PrescriptionForm()
        {
            InitializeComponent();
            _prescriptionManager = new PrescriptionManager();
        }

        #endregion

        #region Form Events

        private void Receteler_Load(object sender, EventArgs e)
        {
            LoadPatientComboBox();
            LoadPrescriptions();
        }

        private void PatientComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTreatmentComboBox();
        }

        private void TreatmentTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadTreatmentPrice();
        }

        #endregion

        #region CRUD Operations

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _prescriptionManager.SavePrescription(
                    PatientComboBox.SelectedValue?.ToString(),
                    TreatmentTextBox.Text,
                    CostTextBox.Text,
                    MedicationTextBox.Text,
                    QuantityTextBox.Text);
                MessageBox.Show("Reçete başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrescriptions();
                ClearInputFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedPrescriptionId is null)
            {
                MessageBox.Show("Silinecek reçeteyi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bu reçeteyi silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                _prescriptionManager.DeletePrescription(_selectedPrescriptionId.Value);
                MessageBox.Show("Reçete başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrescriptions();
                ClearInputFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Grid Events

        private void PrescriptionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || PrescriptionDataGridView.SelectedRows.Count == 0) return;

            var row = PrescriptionDataGridView.SelectedRows[0];
            PatientComboBox.Text = row.Cells[1].Value?.ToString() ?? "";      // HasAd
            TreatmentTextBox.Text = row.Cells[2].Value?.ToString() ?? "";       // TedaviAd
            CostTextBox.Text = row.Cells[3].Value?.ToString() ?? "";        // TedaviUcret
            MedicationTextBox.Text = row.Cells[4].Value?.ToString() ?? "";      // Ilac
            QuantityTextBox.Text = row.Cells[5].Value?.ToString() ?? "";       // IlacMiktar

            _selectedPrescriptionId = DataGridViewHelper.GetSelectedRecordId(PrescriptionDataGridView, "RecId");
        }

        #endregion

        #region Search & Filter

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyPrescriptionFilter();
        }

        #endregion

        #region Print Functionality

        private void PrintButton_Click(object sender, EventArgs e)
        {
            int height = PrescriptionDataGridView.Height;
            PrescriptionDataGridView.Height = PrescriptionDataGridView.RowCount * PrescriptionDataGridView.RowTemplate.Height + PrescriptionDataGridView.ColumnHeadersHeight;
            bitmap = new Bitmap(PrescriptionDataGridView.Width, PrescriptionDataGridView.Height);
            PrescriptionDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 10, PrescriptionDataGridView.Width, PrescriptionDataGridView.Height));
            PrescriptionDataGridView.Height = height;
            PrintPreviewDialogReceteler.ShowDialog();
        }

        private void PrintDocReceteler_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        #endregion

        #region Helper Methods

        private void LoadPatientComboBox()
        {
            DataTable dt = PatientRepository.GetPatientNames();
            if (dt.Rows.Count > 0)
            {
                PatientComboBox.DisplayMember = "PatientName";
                PatientComboBox.ValueMember = "PatientName";
                PatientComboBox.DataSource = dt;
                PatientComboBox.SelectedIndex = -1;
            }
        }

        private void LoadTreatmentComboBox()
        {
            if (string.IsNullOrEmpty(PatientComboBox.Text))
            {
                return;
            }
            DataTable dt = AppointmentRepository.GetTreatmentsByPatient(PatientComboBox.Text);
            if (dt.Rows.Count > 0)
            {
                TreatmentTextBox.Text = dt.Rows[0]["TreatmentName"].ToString();
            }
            else
            {
                TreatmentTextBox.Text = string.Empty;
            }
        }

        private void LoadTreatmentPrice()
        {
            if (string.IsNullOrWhiteSpace(TreatmentTextBox.Text))
            {
                CostTextBox.Text = string.Empty;
                return;
            }
            DataTable dt = TreatmentRepository.GetTreatmentCostByName(TreatmentTextBox.Text);
            if (dt.Rows.Count > 0)
            {
                CostTextBox.Text = dt.Rows[0]["Cost"].ToString();
            }
            else
            {
                CostTextBox.Text = string.Empty;
            }
        }

        private void LoadPrescriptions()
        {
            PrescriptionDataGridView.DataSource = PrescriptionRepository.GetAll();
        }

        private void ClearInputFields()
        {
            PatientComboBox.SelectedIndex = -1;
            TreatmentTextBox.Text = "";
            CostTextBox.Text = "";
            QuantityTextBox.Text = "";
            MedicationTextBox.Text = "";
            _selectedPrescriptionId = null;
        }

        void ApplyPrescriptionFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                LoadPrescriptions();
            }
            else
            {
                PrescriptionDataGridView.DataSource = PrescriptionRepository.Search(SearchTextBox.Text);
            }
        }

        #endregion

        #region Navigation Events

        private void BackLabel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToMainMenu(this);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            NavigationHelper.ExitApplication();
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPatients(this);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToAppointments(this);
        }

        private void TreatmentButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToTreatments(this);
        }

        #endregion
    }
}

