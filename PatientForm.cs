using DisKlinik.Business;
using DisKlinik.Repositories;
using System;
using System.Windows.Forms;

namespace DisKlinik
{
    public partial class PatientForm : Form
    {
        #region Fields & Constants

        private int? _selectedPatientId;
        private readonly PatientManager _patientManager;

        #endregion

        #region Constructor

        public PatientForm()
        {
            InitializeComponent();
            _patientManager = new PatientManager();
        }

        #endregion

        #region Form Events

        private void Hasta_Load(object sender, EventArgs e)
        {
            LoadPatients();
            ClearInputFields();
        }

        #endregion

        #region CRUD Operations

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _patientManager.SavePatient(
                    PatientNameTextBox.Text,
                    PhoneTextBox.Text,
                    AddressTextBox.Text,
                    BirthDatePicker.Text,
                    GenderComboBox.SelectedItem?.ToString(),
                    AllergyTextBox.Text);
                MessageBox.Show("Hasta başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_selectedPatientId is null)
            {
                MessageBox.Show("Güncellenecek hastayı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _patientManager.UpdatePatient(
                    _selectedPatientId.Value,
                    PatientNameTextBox.Text,
                    PhoneTextBox.Text,
                    AddressTextBox.Text,
                    BirthDatePicker.Text,
                    GenderComboBox.SelectedItem?.ToString(),
                    AllergyTextBox.Text);
                MessageBox.Show("Hasta başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
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
            if (_selectedPatientId is null)
            {
                MessageBox.Show("Silinecek hastayı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bu hastayı silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                _patientManager.DeletePatient(_selectedPatientId.Value);
                MessageBox.Show("Hasta başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
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

        private void PatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || PatientDataGridView.SelectedRows.Count == 0) return;

            var row = PatientDataGridView.SelectedRows[0];
            PatientNameTextBox.Text = row.Cells[1].Value?.ToString() ?? "";
            PhoneTextBox.Text = row.Cells[2].Value?.ToString() ?? "";
            AddressTextBox.Text = row.Cells[3].Value?.ToString() ?? "";
            BirthDatePicker.Text = row.Cells[4].Value?.ToString() ?? "";
            GenderComboBox.SelectedItem = row.Cells[5].Value?.ToString() ?? "";
            AllergyTextBox.Text = row.Cells[6].Value?.ToString() ?? "";

            _selectedPatientId = DataGridViewHelper.GetSelectedRecordId(PatientDataGridView, "HId");
        }

        #endregion

        #region Search & Filter

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyPatientFilter();
        }

        #endregion

        #region Helper Methods

        void LoadPatients()
        {
            PatientDataGridView.DataSource = PatientRepository.GetAll();
        }

        void ApplyPatientFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                LoadPatients();
            }
            else
            {
                PatientDataGridView.DataSource = PatientRepository.Search(SearchTextBox.Text);
            }
        }

        void ClearInputFields()
        {
            PatientNameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            BirthDatePicker.Text = "";
            GenderComboBox.SelectedIndex = -1;
            AllergyTextBox.Text = "";
            _selectedPatientId = null;
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

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToAppointments(this);
        }

        private void TreatmentButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToTreatments(this);
        }

        private void PrescriptionsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPrescriptions(this);
        }

        #endregion
    }
}

