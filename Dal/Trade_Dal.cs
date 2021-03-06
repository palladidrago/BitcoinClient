using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class Trade_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Trade"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_Trade");
            //Creating a connection
            DataRelation dataRelation = null;
            Client_Dal.FillDataSet(dataSet);
            //Add data relation
            dataRelation = new DataRelation(
                "TradeClient",
                dataSet.Tables["Table_Client"].Columns["Id"],
                dataSet.Tables["Table_Trade"].Columns["Client"]);
            dataSet.Relations.Add(dataRelation);

        }
        public static bool Insert(int client,DateTime date,String Memo) // Date might not work
        {

            string sql = $"INSERT INTO Table_Trade ([Client],[Date],[Memo]) VALUES ({client},'{date:yyyy-MM-dd}','{Memo}')";
            return Dal.ExecuteSql(sql);
        }
        public static bool Update(int id, int client,DateTime date )
        {

            //Updates the client in the database

            string str = "UPDATE Table_Trade SET"

            + $" [Client] = '{client}'"
            + $",[Date] = '{date:yyyy-MM-dd}'"
            + $" WHERE [Id] = {id}";

            //Return success
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //Delete the country from database

            string str = "DELETE FROM Table_Trade WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }

    }
}
