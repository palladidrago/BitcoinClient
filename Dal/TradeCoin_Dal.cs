using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Dal
{
    class TradeCoin_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_TradeCoin"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_TradeCoin");
            //Creating a connection
            DataRelation dataRelation = null;
            Trade_Dal.FillDataSet(dataSet); //Add trades to dataset
            //Add data relation
            dataRelation = new DataRelation(
                "TradeCoinTrade", //ChildParent
                dataSet.Tables["Table_Trade"].Columns["Id"], //Parent is trade (isn't aware of all its' tradecoins)
                dataSet.Tables["Table_TradeCoin"].Columns["Trade"]);

            dataSet.Relations.Add(dataRelation);
            Coin_Dal.FillDataSet(dataSet); //Add coins to dataset
            dataRelation = new DataRelation(
                "TradeCoinCoin", //ChildParent
                dataSet.Tables["Table_Coin"].Columns["Id"],
                dataSet.Tables["Table_TradeCoin"].Columns["Coin"]); //Parent is coin (isn't aware of all its' tradecoins)

            dataSet.Relations.Add(dataRelation);

        }
        public static bool Insert(int trade, int coin,long count)
        {
            //Insert TradeCoin into db
            string sql = "INSERT INTO Table_TradeCoin"
            + "("
            + "[Trade],[Coin],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"'{trade}','{coin}','{count}'"
            + ")";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete TradeCoin from db
            return Dal.ExecuteSql($"DELETE FROM Table_TradeCoin WHERE ID = {id}");
        }
    }
}
