using System.Data;
using System.Data.SqlClient;

namespace DisKlinik
{
    public static class DataAccess
    {
        #region Command Execution Methods

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            ConnectionString cs = new ConnectionString();
            using (SqlConnection connection = cs.GetCon())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static DataSet ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            ConnectionString cs = new ConnectionString();
            using (SqlConnection connection = cs.GetCon())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }

        #endregion
    }
}
