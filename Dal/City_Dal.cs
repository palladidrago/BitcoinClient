using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class City_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_City"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_City"))
            {
                Dal.FillDataSet(dataSet, "Table_City","[Name]");

            }

        }
        public static bool Insert(string name)
        {
            string sql = $"INSERT INTO Table_City ([Name]) VALUES ('{name}')";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete the city from database

            string str = "DELETE FROM Table_City WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }

    }
}
