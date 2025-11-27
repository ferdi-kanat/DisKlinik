using System.Data;
using System.Data.SqlClient;

namespace DisKlinik.Repositories
{
    public static class TreatmentRepository
    {
        #region SQL Queries

        private const string SelectColumns = "SELECT TId, TreatmentName AS 'Tedavi Adı', Cost AS 'Ücret', Description AS 'Açıklama'";
        private const string SelectAll = SelectColumns + " FROM TedaviTbl";
        private const string InsertSql = "INSERT INTO TedaviTbl(TreatmentName, Cost, Description) VALUES(@Name, @Cost, @Description)";
        private const string UpdateSql = "UPDATE TedaviTbl SET TreatmentName=@Name, Cost=@Cost, Description=@Description WHERE TId=@Id";
        private const string DeleteSql = "DELETE FROM TedaviTbl WHERE TId=@Id";

        #endregion

        #region Public Methods

        public static DataTable GetAll()
        {
            var dataSet = DataAccess.ExecuteQuery(SelectAll);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable Search(string searchText)
        {
            string[] searchColumns = { "TreatmentName", "Cost", "Description" };
            string whereClause = string.Join(" OR ", System.Array.ConvertAll(searchColumns, c => $"{c} LIKE @s"));
            string sql = $"{SelectColumns} FROM TedaviTbl WHERE {whereClause}";

            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@s", "%" + searchText + "%"));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable GetTreatmentNames()
        {
            const string sql = "SELECT TreatmentName FROM TedaviTbl";
            var dataSet = DataAccess.ExecuteQuery(sql);
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static DataTable GetTreatmentCostByName(string treatmentName)
        {
            const string sql = "SELECT Cost FROM TedaviTbl WHERE TreatmentName=@Name";
            var dataSet = DataAccess.ExecuteQuery(sql, new SqlParameter("@Name", treatmentName));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public static int Add(string name, string cost, string description)
        {
            return DataAccess.ExecuteNonQuery(InsertSql,
                DataGridViewHelper.CreateParameter("@Name", name),
                DataGridViewHelper.CreateParameter("@Cost", cost),
                DataGridViewHelper.CreateParameter("@Description", description));
        }

        public static int Update(int id, string name, string cost, string description)
        {
            return DataAccess.ExecuteNonQuery(UpdateSql,
                DataGridViewHelper.CreateParameter("@Name", name),
                DataGridViewHelper.CreateParameter("@Cost", cost),
                DataGridViewHelper.CreateParameter("@Description", description),
                DataGridViewHelper.CreateParameter("@Id", id));
        }

        public static int Delete(int id)
        {
            return DataAccess.ExecuteNonQuery(DeleteSql, DataGridViewHelper.CreateParameter("@Id", id));
        }

        #endregion
    }
}
