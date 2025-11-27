using System.Windows.Forms;

namespace DisKlinik
{
    /// <summary>
    /// Provides centralized navigation between forms using Show/Hide pattern
    /// </summary>
    public static class NavigationHelper
    {
        #region Generic Navigation

        /// <summary>
        /// Generic form navigation method - creates new form instance and hides current
        /// </summary>
        /// <typeparam name="TForm">Target form type</typeparam>
        /// <param name="currentForm">Current form to hide</param>
        public static void NavigateTo<TForm>(Form currentForm) where TForm : Form, new()
        {
            TForm targetForm = new TForm();
            targetForm.Show();
            currentForm.Hide();
        }

        #endregion

        #region Specific Form Navigation

        /// <summary>
        /// Navigate to main menu (Anasayfa)
        /// </summary>
        public static void NavigateToMainMenu(Form currentForm)
        {
            NavigateTo<MainMenu>(currentForm);
        }

        /// <summary>
        /// Navigate to patients form (Hasta)
        /// </summary>
        public static void NavigateToPatients(Form currentForm)
        {
            NavigateTo<PatientForm>(currentForm);
        }

        /// <summary>
        /// Navigate to appointments form (Randevu)
        /// </summary>
        public static void NavigateToAppointments(Form currentForm)
        {
            NavigateTo<AppointmentForm>(currentForm);
        }

        /// <summary>
        /// Navigate to treatments form (Tedavi)
        /// </summary>
        public static void NavigateToTreatments(Form currentForm)
        {
            NavigateTo<TreatmentForm>(currentForm);
        }

        /// <summary>
        /// Navigate to prescriptions form (Receteler)
        /// </summary>
        public static void NavigateToPrescriptions(Form currentForm)
        {
            NavigateTo<PrescriptionForm>(currentForm);
        }

        #endregion

        #region Application Lifecycle

        /// <summary>
        /// Exit application with confirmation dialog
        /// </summary>
        public static void ExitApplication()
        {
            var result = MessageBox.Show(
                "Uygulamadan çıkmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}