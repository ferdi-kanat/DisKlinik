using DisKlinik.Business;
using DisKlinik.Repositories;
using System;
using System.Windows.Forms;

namespace DisKlinik
{
    public partial class TreatmentForm : Form
    {
        #region Fields & Constants

        private int? _selectedTreatmentId;
        private readonly TreatmentManager _treatmentManager;

        #endregion

        #region Constructor

        public TreatmentForm()
        {
            InitializeComponent();
            _treatmentManager = new TreatmentManager();
        }

        #endregion

        #region Form Events

        private void Tedavi_Load(object sender, EventArgs e)
        {
            LoadTreatments();
        }

        #endregion

        #region CRUD Operations

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _treatmentManager.SaveTreatment(
                    TreatmentNameTextBox.Text,
                    CostTextBox.Text,
                    DescriptionTextBox.Text);

                MessageBox.Show("Tedavi başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreatments();
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
            if (_selectedTreatmentId == null)
            {
                MessageBox.Show("Düzenlenecek tedaviyi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _treatmentManager.UpdateTreatment(
                    _selectedTreatmentId.Value,
                    TreatmentNameTextBox.Text,
                    CostTextBox.Text,
                    DescriptionTextBox.Text);

                MessageBox.Show("Tedavi başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreatments();
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
            if (_selectedTreatmentId == null)
            {
                MessageBox.Show("Silinecek tedaviyi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bu tedaviyi silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                _treatmentManager.DeleteTreatment(_selectedTreatmentId.Value);

                MessageBox.Show("Tedavi başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreatments();
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

        private void TreatmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TreatmentDataGridView.Rows[e.RowIndex];
                _selectedTreatmentId = Convert.ToInt32(row.Cells[0].Value);
                TreatmentNameTextBox.Text = row.Cells[1].Value.ToString();
                CostTextBox.Text = row.Cells[2].Value.ToString();
                DescriptionTextBox.Text = row.Cells[3].Value.ToString();
            }
        }

        #endregion

        #region Search & Filter

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyTreatmentFilter();
        }

        #endregion

        #region Helper Methods

        private void LoadTreatments()
        {
            TreatmentDataGridView.DataSource = TreatmentRepository.GetAll();
        }

        private void ClearInputFields()
        {
            TreatmentNameTextBox.Text = "";
            CostTextBox.Text = "";
            DescriptionTextBox.Text = "";
            _selectedTreatmentId = null;
        }

        private void ApplyTreatmentFilter()
        {
            string searchText = SearchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTreatments();
            }
            else
            {
                TreatmentDataGridView.DataSource = TreatmentRepository.Search(searchText);
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

        private void PrescriptionsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPrescriptions(this);
        }

        #endregion
    }
}

