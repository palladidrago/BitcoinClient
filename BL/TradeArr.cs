﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
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
