using DisKlinik.Repositories;
using System;

namespace DisKlinik.Business
{
    /// <summary>
    /// Reçete (Prescription) business logic and validation layer.
    /// Handles all business rules, validations, and coordinates repository operations.
    /// </summary>
    public class PrescriptionManager
    {
        #region Validation Methods

        /// <summary>
        /// Validates prescription data before save operations.
        /// </summary>
        private void ValidatePrescriptionData(string patientName, string treatmentName, string cost, string medication, string quantity)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Hasta seçilmelidir");

            if (string.IsNullOrWhiteSpace(treatmentName))
                throw new ArgumentException("Tedavi boş olamaz");

            if (string.IsNullOrWhiteSpace(cost))
                throw new ArgumentException("Ücret boş olamaz");

            // Cost validation: must be numeric and positive
            if (!decimal.TryParse(cost, out decimal costValue))
                throw new ArgumentException("Ücret geçerli bir sayı olmalıdır");

            if (costValue <= 0)
                throw new ArgumentException("Ücret sıfırdan büyük olmalıdır");

            // Optional fields validation
            if (!string.IsNullOrWhiteSpace(quantity))
            {
                if (!int.TryParse(quantity, out int quantityValue))
                    throw new ArgumentException("İlaç miktarı geçerli bir sayı olmalıdır");

                if (quantityValue <= 0)
                    throw new ArgumentException("İlaç miktarı sıfırdan büyük olmalıdır");
            }
        }

        #endregion

        #region CRUD Operations

        /// <summary>
        /// Saves a new prescription to the database after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int SavePrescription(string patientName, string treatmentName, string cost, string medication, string quantity)
        {
            ValidatePrescriptionData(patientName, treatmentName, cost, medication, quantity);

            return PrescriptionRepository.Add(patientName, treatmentName, cost, medication ?? "", quantity ?? "");
        }

        /// <summary>
        /// Deletes a prescription from the database.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int DeletePrescription(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz reçete ID");

            return PrescriptionRepository.Delete(id);
        }

        #endregion
    }
}
