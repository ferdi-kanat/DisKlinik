using DisKlinik.Repositories;
using System;

namespace DisKlinik.Business
{
    /// <summary>
    /// Tedavi (Treatment) business logic and validation layer.
    /// Handles all business rules, validations, and coordinates repository operations.
    /// </summary>
    public class TreatmentManager
    {
        #region Validation Methods

        /// <summary>
        /// Validates treatment data before save/update operations.
        /// </summary>
        private void ValidateTreatmentData(string name, string cost, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tedavi adı boş olamaz");

            if (string.IsNullOrWhiteSpace(cost))
                throw new ArgumentException("Ücret boş olamaz");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Açıklama boş olamaz");

            // Cost validation: must be numeric and positive
            if (!decimal.TryParse(cost, out decimal costValue))
                throw new ArgumentException("Ücret geçerli bir sayı olmalıdır");

            if (costValue <= 0)
                throw new ArgumentException("Ücret sıfırdan büyük olmalıdır");
        }

        #endregion

        #region CRUD Operations

        /// <summary>
        /// Saves a new treatment to the database after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int SaveTreatment(string name, string cost, string description)
        {
            ValidateTreatmentData(name, cost, description);

            return TreatmentRepository.Add(name, cost, description);
        }

        /// <summary>
        /// Updates an existing treatment after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int UpdateTreatment(int id, string name, string cost, string description)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz tedavi ID");

            ValidateTreatmentData(name, cost, description);

            return TreatmentRepository.Update(id, name, cost, description);
        }

        /// <summary>
        /// Deletes a treatment from the database.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int DeleteTreatment(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz tedavi ID");

            return TreatmentRepository.Delete(id);
        }

        #endregion
    }
}
