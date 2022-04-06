using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Globalization;
using Dal;

namespace BL
{
    public class TradeArr : ArrayList
    {
        public TradeArr Filter(string clientName, int id)
        {
            TradeArr tradeArr = new TradeArr();
            Trade trade;
            for (int i = 0; i < this.Count; i++)
            {
                trade = (this[i] as Trade);
                if (trade.Id.ToString().Contains(id.ToString()) &&
                trade.Client.ToString().StartsWith(clientName))
                    tradeArr.Add(trade);
            }
            return tradeArr;
        }
        public TradeArr Filter(int year, int month)
        {
            //Filter by year and by month
            TradeArr returnArr = new TradeArr();
            foreach (Trade item in this)
                if (item.Date.Year == year && item.Date.Month == month)
                    returnArr.Add(item);
            return returnArr;
        }
        public Dictionary<string, int> GetDictionary(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, this.Filter(year, i).Count); //Amount of trades per month 
            }
            return dictionary;
        }
        public bool HasTrade(Trade curTrade)
        {

            //Returns whether at least one of the orders is by the client

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Trade).Client.Id == curTrade.Id)
                    return true;

            return false;
        }
        public void Fill()
        {

            //Fills the table from dal


            DataTable dataTable = Trade_Dal.GetDataTable();

            //Move data from dal to trade
            //move each row

            DataRow dataRow;
            Trade curTrade;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curTrade = new Trade(dataRow);
                this.Add(curTrade);
            }
        }
        public Trade GetTradeWithMaxId()
        {
            //Return the city with the highest id
            Trade maxTrade = new Trade();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Trade).Id > maxTrade.Id)
                    maxTrade = this[i] as Trade;

            return maxTrade;
        }

    }
}
