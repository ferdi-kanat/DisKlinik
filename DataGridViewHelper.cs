using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DisKlinik
{
    public static class DataGridViewHelper
    {
        #region Data Loading

        public static void LoadData(DataGridView gridView, string sql, params SqlParameter[] parameters)
        {
            var dataSet = DataAccess.ExecuteQuery(sql, parameters);
            gridView.DataSource = dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
        }

        public static void ApplyMultiColumnFilter(DataGridView gridView, string selectClause, string tableName, string[] searchColumns, string searchText)
        {
            if (searchText == null) searchText = string.Empty;
            if (searchColumns == null || searchColumns.Length == 0)
            {
                LoadData(gridView, $"{selectClause} FROM {tableName}");
                return;
            }
            string whereClause = string.Join(" OR ", searchColumns.Select(c => $"{c} LIKE @s"));
            string sql = $"{selectClause} FROM {tableName} WHERE {whereClause}";
            LoadData(gridView, sql, new SqlParameter("@s", "%" + searchText + "%"));
        }

        #endregion

        #region Grid Selection

        public static int? GetSelectedRecordId(DataGridView gridView, string idColumnName = "Id")
        {
            if (gridView.SelectedRows.Count == 0) return null;
            var selectedRow = gridView.SelectedRows[0];

            // Önce sütun adıyla dene
            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                if (cell.OwningColumn.Name == idColumnName)
                {
                    if (int.TryParse(cell.Value?.ToString(), out int parsedId))
                        return parsedId;
                }
            }

            // Yoksa ilk hücreyi dene
            if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int firstCellId))
                return firstCellId;

            return null;
        }

        #endregion

        #region Parameter Creation

        public static SqlParameter CreateParameter(string parameterName, object value) =>
            new SqlParameter(parameterName, value ?? DBNull.Value);

        #endregion
    }
}
