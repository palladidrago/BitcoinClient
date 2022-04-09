using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{

    class Quote_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Quote"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_Quote");

        }
        public static bool Insert(double price, long volume,long marketCap, DateTime lastUpdated, double percentChange)
        {
            string sql = "INSERT INTO Table_Quote"
            + "("
            + "[Price],[Volume],[MarketCap],[LastUpdated],[PercentChange]"
            + ")"
            + " VALUES "
            + "("
            + $"'{price}','{volume}','{marketCap}','{lastUpdated:yyyy-MM-dd}','{percentChange}'"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Update(int id, double price, long volume, long marketCap, DateTime lastUpdated, double percentChange)
        {
            //Update the Quote in database

            string str = "UPDATE Table_Quote SET"

            + $" [Price] = '{price}'"
            + $",[Volume] = '{volume}'"
            + $",[MarketCap] = '{marketCap}'"
            + $",[lastUpdated] = '{lastUpdated::yyyy-MM-dd}'"
            + $",[percentChange] = '{percentChange}'"
            + $" WHERE [Id] = {id}";
            //Return if success
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //Delete the Quote from database

            string str = "DELETE FROM Table_Quote WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }
    }
}
