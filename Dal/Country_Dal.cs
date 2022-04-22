using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class Country_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Country"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Country"))
            {
                Dal.FillDataSet(dataSet, "Table_Country","[Name]");

            }

        }
        public static bool Insert(string name)
        {
            string sql = $"INSERT INTO Table_Country ([Name]) VALUES ('{name}')";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete the Country from database

            string str = "DELETE FROM Table_Country WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }

    }
}
