using System;
using System.Windows.Forms;

namespace DisKlinik
{
    public partial class MainMenu : Form
    {
        #region Constructor

        public MainMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Navigation Events

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

        private void PrescriptionsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPrescriptions(this);
        }

        #endregion
    }
}
