using System.Data;
using System.Data.SqlClient;

namespace DisKlinik.Repositories
{
    public static class PrescriptionRepository
    {
        #region SQL Queries

        private const string SelectColumns = "SELECT RecId, PatientName AS 'Hasta Adı', TreatmentName AS 'Tedavi', TreatmentCost AS 'Ücret', Medication AS 'İlaç', MedicationQuantity AS 'Miktar'";
        private const string SelectAll = SelectColumns + " FROM ReceteTbl";
        private const string InsertSql = "INSERT INTO ReceteTbl (PatientName, TreatmentName, TreatmentCost, Medication, MedicationQuantity) VALUES (@PatientName, @TreatmentName, @Cost, @Medication, @Quantity)";
        private const string DeleteSql = "DELETE FROM ReceteTbl WHERE RecId=@RecId";

        #endregion

        #region Public Methods

        public static DataTable GetAll()
        {
            var dataSet = DataAccess.ExecuteQuery(SelectAll);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable Search(string searchText)
        {
            string[] searchColumns = { "PatientName", "TreatmentName", "Medication" };
            string whereClause = string.Join(" OR ", System.Array.ConvertAll(searchColumns, c => $"{c} LIKE @s"));
            string sql = $"{SelectColumns} FROM ReceteTbl WHERE {whereClause}";

            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@s", "%" + searchText + "%"));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static int Add(string patientName, string treatmentName, string cost, string medication, string quantity)
        {
            return DataAccess.ExecuteNonQuery(InsertSql,
                DataGridViewHelper.CreateParameter("@PatientName", patientName),
                DataGridViewHelper.CreateParameter("@TreatmentName", treatmentName),
                DataGridViewHelper.CreateParameter("@Cost", cost),
                DataGridViewHelper.CreateParameter("@Medication", medication),
                DataGridViewHelper.CreateParameter("@Quantity", quantity));
        }

        public static int Delete(int id)
        {
            return DataAccess.ExecuteNonQuery(DeleteSql, DataGridViewHelper.CreateParameter("@RecId", id));
        }

        #endregion
    }
}
