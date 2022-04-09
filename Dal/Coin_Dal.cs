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
        public static bool Insert(string name,string symbol,long supply,int valid, int scam,int CMC_Id, string logoURL)
        {
            string sql = "INSERT INTO Table_Coin"
            + "("
            + "[Name],[Symbol],[Supply],[Valid],[Scam],[CMC_Id],[LogoUrl]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}','{symbol}','{supply}','{valid}','{scam}',{CMC_Id},'{logoURL}'"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Update(int id, string name, string symbol, long supply, int valid, int scam,int CMC_Id,string logoURL)
        {
            //Update the Coin in database

            string str = "UPDATE Table_Coin SET"

            + $" [Name] = '{name}'"
            + $",[Symbol] = '{symbol}'"
            + $",[Supply] = {supply}"
            + $",[Valid] = {valid}"
            + $",[Scam] = {scam}"

            + $",[CMC_Id] = {CMC_Id}"
            + $",[LogoUrl] = '{logoURL}'"

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
        public static bool UpdateSupply(int id, long supply)
        {

            // Update the coin supply in table
            string str = $"UPDATE Table_Coin SET [Supply] = {supply} WHERE ID = {id}";
            //Return success
            return Dal.ExecuteSql(str);
        }
    }
}

