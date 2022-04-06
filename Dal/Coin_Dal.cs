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

            Dal.FillDataSet(dataSet, "Table_Coin");
            //Creating a connection
            DataRelation dataRelation = null;
            Valid_Dal.FillDataSet(dataSet);
            Scam_Dal.FillDataSet(dataSet);
            //Add data relation (Valid is parent, Coin is child)
            dataRelation = new DataRelation(
                "CoinValid",
                dataSet.Tables["Table_Valid"].Columns["Id"],
                dataSet.Tables["Table_Coin"].Columns["Valid"]);
            dataSet.Relations.Add(dataRelation);
            //Add data relation (Scam is parent, Coin is child)

            dataRelation = new DataRelation(
                 "CoinScam",
                 dataSet.Tables["Table_Scam"].Columns["Id"],
                 dataSet.Tables["Table_Coin"].Columns["Scam"]);
            dataSet.Relations.Add(dataRelation);

        }
        public static bool Insert(string name,string symbol,long count,int valid, int scam)
        {
            string sql = "INSERT INTO Table_Coin"
            + "("
            + "[Name],[Symbol],[Count],[Valid],[Scam]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}','{symbol}','{count}','{valid}','{scam}'"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Update(int id, string name, string symbol, long count, int valid, int scam)
        {
            //Update the Coin in database

            string str = "UPDATE Table_Coin SET"

            + $" [Name] = '{name}'"
            + $",[Symbol] = '{symbol}'"
            + $",[Count] = {count}"
            + $",[Valid] = {valid}"
            + $",[Scam] = {scam}"
            + $" WHERE [Id] = {id}";
            //Return if success
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //Delete the Coin from database

            string str = "DELETE FROM Table_Coin WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }
        public static bool UpdateCount(int id, long count)
        {

            // Update the coin supply in table
            string str = $"UPDATE Table_Product SET [Count] = {count} WHERE ID = {id}";
            //Return success
            return Dal.ExecuteSql(str);
        }
    }
}

