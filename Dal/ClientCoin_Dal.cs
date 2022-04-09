using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Dal
{
    class CoinQuote_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_CoinQuote"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_CoinQuote");
            //Creating a connection
            DataRelation dataRelation = null;
            Coin_Dal.FillDataSet(dataSet); //Add clients to dataset
            //Add data relation
            dataRelation = new DataRelation(
                "CoinQuoteCoin", //ChildParent
                dataSet.Tables["Table_Coin"].Columns["Id"], //Parent is coin (isn't aware of all its' ClientCoins)
                dataSet.Tables["Table_CoinQuote"].Columns["Coin"]);

            dataSet.Relations.Add(dataRelation);
            Quote_Dal.FillDataSet(dataSet); //Add coins to dataset
            dataRelation = new DataRelation(
                "CoinQuoteQuote", //ChildParent
                dataSet.Tables["Table_Quote"].Columns["Id"],
                dataSet.Tables["Table_CoinQuote"].Columns["Quote"]); //Parent is Quote (isn't aware of all its' ClientCoins)

            dataSet.Relations.Add(dataRelation);

        }
        public static bool Insert(int coin, int quote)
        {
            //Insert ClientCoin into db
            string sql = "INSERT INTO Table_CoinQuote"
            + "("
            + "[Coin],[Quote]"
            + ")"
            + " VALUES "
            + "("
            + $"'{coin}','{quote}'"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete ClientCoin from db
            return Dal.ExecuteSql($"DELETE FROM Table_CoinQuote WHERE ID = {id}");
        }
    }
}
