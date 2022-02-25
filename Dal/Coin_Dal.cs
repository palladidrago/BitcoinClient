using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;

namespace Dal
{
    class Coin_Dal
        {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Coin"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Coin"))
            {
                Dal.FillDataSet(dataSet, "Table_Coin", "[Name]");

            }

        }
        public static bool Insert(string name,int valid, int scam)
        {
            string sql = "INSERT INTO Table_Coin"
            + "("
            + "[Name],[Valid],[Scam]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{name}',N'{valid}',{scam}"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete the Coin from database

            string str = "DELETE FROM Table_Coin WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }

    }
}

