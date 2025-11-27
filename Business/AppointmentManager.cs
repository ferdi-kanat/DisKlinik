using DisKlinik.Repositories;
using System;

namespace DisKlinik.Business
{
    /// <summary>
    /// Randevu (Appointment) business logic and validation layer.
    /// Handles all business rules, validations, and coordinates repository operations.
    /// </summary>
    public class AppointmentManager
    {
        #region Validation Methods

        /// <summary>
        /// Validates appointment data before save/update operations.
        /// </summary>
        private void ValidateAppointmentData(string patientName, string treatmentName, string time)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Hasta seçilmelidir");

            if (string.IsNullOrWhiteSpace(treatmentName))
                throw new ArgumentException("Tedavi seçilmelidir");

            if (string.IsNullOrWhiteSpace(time))
                throw new ArgumentException("Randevu saati seçilmelidir");
        }

        #endregion

        #region CRUD Operations

        /// <summary>
        /// Saves a new appointment to the database after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int SaveAppointment(string patientName, string treatmentName, DateTime date, string time)
        {
            ValidateAppointmentData(patientName, treatmentName, time);

            // Business rule: Cannot create appointment for past dates
            if (date.Date < DateTime.Now.Date)
                throw new ArgumentException("Geçmiş tarihe randevu oluşturulamaz");

            return AppointmentRepository.Add(patientName, treatmentName, date, time);
        }

        /// <summary>
        /// Updates an existing appointment after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int UpdateAppointment(int id, string patientName, string treatmentName, DateTime date, string time)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz randevu ID");

            ValidateAppointmentData(patientName, treatmentName, time);

            return AppointmentRepository.Update(id, patientName, treatmentName, date, time);
        }

        /// <summary>
        /// Deletes an appointment from the database.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int DeleteAppointment(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz randevu ID");

            return AppointmentRepository.Delete(id);
        }

        #endregion
    }
}
