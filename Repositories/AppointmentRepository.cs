using System;
using System.Data;
using System.Data.SqlClient;

namespace DisKlinik.Repositories
{
    public static class AppointmentRepository
    {
        #region SQL Queries

        private const string SelectColumns = "SELECT RId, PatientName AS 'Hasta Adı', TreatmentName AS 'Tedavi', AppointmentDate AS 'Tarih', AppointmentTime AS 'Saat'";
        private const string SelectAll = SelectColumns + " FROM RandevuTbl";
        private const string InsertSql = "INSERT INTO RandevuTbl (PatientName, TreatmentName, AppointmentDate, AppointmentTime) VALUES (@PatientName, @TreatmentName, @Date, @Time)";
        private const string UpdateSql = "UPDATE RandevuTbl SET PatientName=@PatientName, TreatmentName=@TreatmentName, AppointmentDate=@Date, AppointmentTime=@Time WHERE RId=@Id";
        private const string DeleteSql = "DELETE FROM RandevuTbl WHERE RId=@Id";

        #endregion

        #region Public Methods

        public static DataTable GetAll()
        {
            var dataSet = DataAccess.ExecuteQuery(SelectAll);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable Search(string searchText)
        {
            string[] searchColumns = { "PatientName", "TreatmentName" };
            string whereClause = string.Join(" OR ", Array.ConvertAll(searchColumns, c => $"{c} LIKE @s"));
            string sql = $"{SelectColumns} FROM RandevuTbl WHERE {whereClause}";

            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@s", "%" + searchText + "%"));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable GetTreatmentsByPatient(string patientName)
        {
            const string sql = "SELECT TreatmentName FROM RandevuTbl WHERE PatientName=@PatientName";
            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@PatientName", patientName));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static int Add(string patientName, string treatmentName, DateTime date, string time)
        {
            return DataAccess.ExecuteNonQuery(InsertSql,
                DataGridViewHelper.CreateParameter("@PatientName", patientName),
                DataGridViewHelper.CreateParameter("@TreatmentName", treatmentName),
                DataGridViewHelper.CreateParameter("@Date", date),
                DataGridViewHelper.CreateParameter("@Time", time));
        }

        public static int Update(int id, string patientName, string treatmentName, DateTime date, string time)
        {
            return DataAccess.ExecuteNonQuery(UpdateSql,
                DataGridViewHelper.CreateParameter("@PatientName", patientName),
                DataGridViewHelper.CreateParameter("@TreatmentName", treatmentName),
                DataGridViewHelper.CreateParameter("@Date", date),
                DataGridViewHelper.CreateParameter("@Time", time),
                DataGridViewHelper.CreateParameter("@Id", id));
        }

        public static int Delete(int id)
        {
            return DataAccess.ExecuteNonQuery(DeleteSql, DataGridViewHelper.CreateParameter("@Id", id));
        }

        #endregion
    }
}
