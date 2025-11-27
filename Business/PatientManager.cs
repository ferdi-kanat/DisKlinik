using DisKlinik.Repositories;
using System;

namespace DisKlinik.Business
{
    /// <summary>
    /// Hasta (Patient) business logic and validation layer.
    /// Handles all business rules, validations, and coordinates repository operations.
    /// </summary>
    public class PatientManager
    {
        #region Validation Methods

        /// <summary>
        /// Validates patient data before save/update operations.
        /// </summary>
        private void ValidatePatientData(string name, string phone, string address, string birthDate, string gender)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Hasta adı boş olamaz");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Telefon numarası boş olamaz");

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Adres boş olamaz");

            if (string.IsNullOrWhiteSpace(birthDate))
                throw new ArgumentException("Doğum tarihi boş olamaz");

            if (string.IsNullOrWhiteSpace(gender))
                throw new ArgumentException("Cinsiyet seçilmelidir");

            // Phone validation: must be numeric and reasonable length
            if (phone.Length < 10 || phone.Length > 15)
                throw new ArgumentException("Telefon numarası 10-15 karakter arasında olmalıdır");
        }

        #endregion

        #region CRUD Operations

        /// <summary>
        /// Saves a new patient to the database after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int SavePatient(string name, string phone, string address, string birthDate, string gender, string allergy)
        {
            ValidatePatientData(name, phone, address, birthDate, gender);

            return PatientRepository.Add(name, phone, address, birthDate, gender, allergy ?? "");
        }

        /// <summary>
        /// Updates an existing patient after validation.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int UpdatePatient(int id, string name, string phone, string address, string birthDate, string gender, string allergy)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz hasta ID");

            ValidatePatientData(name, phone, address, birthDate, gender);

            return PatientRepository.Update(id, name, phone, address, birthDate, gender, allergy ?? "");
        }

        /// <summary>
        /// Deletes a patient from the database.
        /// </summary>
        /// <returns>Number of affected rows</returns>
        public int DeletePatient(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz hasta ID");

            return PatientRepository.Delete(id);
        }

        #endregion
    }
}
