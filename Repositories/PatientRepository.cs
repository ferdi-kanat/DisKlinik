using System.Data;
using System.Data.SqlClient;

namespace DisKlinik.Repositories
{
    public static class PatientRepository
    {
        #region SQL Queries

        private const string SelectColumns = "SELECT HId, PatientName, Phone, Address, BirthDate, Gender, Allergy";
        private const string SelectAll = SelectColumns + " FROM HastaTbl";
        private const string InsertSql = "INSERT INTO HastaTbl (PatientName, Phone, Address, BirthDate, Gender, Allergy) VALUES (@Name, @Phone, @Address, @BirthDate, @Gender, @Allergy)";
        private const string UpdateSql = "UPDATE HastaTbl SET PatientName=@Name, Phone=@Phone, Address=@Address, BirthDate=@BirthDate, Gender=@Gender, Allergy=@Allergy WHERE HId=@Id";
        private const string DeleteSql = "DELETE FROM HastaTbl WHERE HId=@Id";

        #endregion

        #region Public Methods

        public static DataTable GetAll()
        {
            var dataSet = DataAccess.ExecuteQuery(SelectAll);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable Search(string searchText)
        {
            string[] searchColumns = { "PatientName", "Phone", "Address" };
            string whereClause = string.Join(" OR ", System.Array.ConvertAll(searchColumns, c => $"{c} LIKE @s"));
            string sql = $"{SelectColumns} FROM HastaTbl WHERE {whereClause}";

            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@s", "%" + searchText + "%"));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable GetPatientNames()
        {
            const string sql = "SELECT PatientName FROM HastaTbl";
            var dataSet = DataAccess.ExecuteQuery(sql);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static int Add(string name, string phone, string address, string birthDate, string gender, string allergy)
        {
            return DataAccess.ExecuteNonQuery(InsertSql,
                DataGridViewHelper.CreateParameter("@Name", name),
                DataGridViewHelper.CreateParameter("@Phone", phone),
                DataGridViewHelper.CreateParameter("@Address", address),
                DataGridViewHelper.CreateParameter("@BirthDate", birthDate),
                DataGridViewHelper.CreateParameter("@Gender", gender),
                DataGridViewHelper.CreateParameter("@Allergy", allergy));
        }

        public static int Update(int id, string name, string phone, string address, string birthDate, string gender, string allergy)
        {
            return DataAccess.ExecuteNonQuery(UpdateSql,
                DataGridViewHelper.CreateParameter("@Name", name),
                DataGridViewHelper.CreateParameter("@Phone", phone),
                DataGridViewHelper.CreateParameter("@Address", address),
                DataGridViewHelper.CreateParameter("@BirthDate", birthDate),
                DataGridViewHelper.CreateParameter("@Gender", gender),
                DataGridViewHelper.CreateParameter("@Allergy", allergy),
                DataGridViewHelper.CreateParameter("@Id", id));
        }

        public static int Delete(int id)
        {
            return DataAccess.ExecuteNonQuery(DeleteSql, DataGridViewHelper.CreateParameter("@Id", id));
        }

        #endregion
    }
}
