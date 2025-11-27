using DisKlinik.Business;
using DisKlinik.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace DisKlinik
{
    public partial class AppointmentForm : Form
    {
        #region Fields & Constants

        private int? _selectedAppointmentId;
        private readonly AppointmentManager _appointmentManager;

        #endregion

        #region Constructor

        public AppointmentForm()
        {
            InitializeComponent();
            _appointmentManager = new AppointmentManager();
        }

        #endregion

        #region Form Events

        private void Randevu_Load(object sender, EventArgs e)
        {
            LoadPatientComboBox();
            LoadTreatmentComboBox();
            LoadAppointments();
            ClearInputFields();
        }

        #endregion

        #region CRUD Operations

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _appointmentManager.SaveAppointment(
                    PatientComboBox.SelectedValue?.ToString(),
                    TreatmentComboBox.SelectedValue?.ToString(),
                    AppointmentDatePicker.Value,
                    AppointmentTimeComboBox.Text);
                MessageBox.Show("Randevu başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
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
            if (_selectedAppointmentId is null)
            {
                MessageBox.Show("Güncellenecek randevuyu seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _appointmentManager.UpdateAppointment(
                    _selectedAppointmentId.Value,
                    PatientComboBox.SelectedValue?.ToString(),
                    TreatmentComboBox.SelectedValue?.ToString(),
                    AppointmentDatePicker.Value,
                    AppointmentTimeComboBox.Text);
                MessageBox.Show("Randevu başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
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
            if (_selectedAppointmentId is null)
            {
                MessageBox.Show("Silinecek randevuyu seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bu randevuyu silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                _appointmentManager.DeleteAppointment(_selectedAppointmentId.Value);
                MessageBox.Show("Randevu başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
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

        private void AppointmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || AppointmentDataGridView.SelectedRows.Count == 0) return;

            var row = AppointmentDataGridView.SelectedRows[0];
            PatientComboBox.SelectedValue = row.Cells[1].Value?.ToString();
            TreatmentComboBox.SelectedValue = row.Cells[2].Value?.ToString();
            AppointmentDatePicker.Text = row.Cells[3].Value?.ToString();
            AppointmentTimeComboBox.Text = row.Cells[4].Value?.ToString();

            _selectedAppointmentId = DataGridViewHelper.GetSelectedRecordId(AppointmentDataGridView, "RId");
        }

        #endregion

        #region Search & Filter

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyAppointmentFilter();
        }

        #endregion

        #region Helper Methods

        private void LoadPatientComboBox()
        {
            DataTable dt = PatientRepository.GetPatientNames();
            if (dt.Rows.Count > 0)
            {
                PatientComboBox.ValueMember = "PatientName";
                PatientComboBox.DataSource = dt;
            }
        }

        private void LoadTreatmentComboBox()
        {
            DataTable dt = TreatmentRepository.GetTreatmentNames();
            if (dt.Rows.Count > 0)
            {
                TreatmentComboBox.ValueMember = "TreatmentName";
                TreatmentComboBox.DataSource = dt;
            }
        }

        private void LoadAppointments()
        {
            AppointmentDataGridView.DataSource = AppointmentRepository.GetAll();
        }

        private void ClearInputFields()
        {
            PatientComboBox.SelectedIndex = -1;
            TreatmentComboBox.SelectedIndex = -1;
            AppointmentDatePicker.Value = DateTime.Now;
            AppointmentTimeComboBox.SelectedIndex = -1;
            _selectedAppointmentId = null;
        }

        private void ApplyAppointmentFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                LoadAppointments();
            }
            else
            {
                AppointmentDataGridView.DataSource = AppointmentRepository.Search(SearchTextBox.Text);
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

