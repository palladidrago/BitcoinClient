using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Dal;

namespace BL
{
    class TradeCoinArr : ArrayList
    {
        public TradeCoinArr FilterNoDuplicates()
        {
            //Returns a TradeCoinArr where all coins are under one trade //DO NOT INSERT THE TRADE DOES NOT EXIST
            TradeCoinArr tradeCoinArr_New = new TradeCoinArr();
            foreach (TradeCoin tradeCoin in this)
            {
                TradeCoinArr existingCoinTradeCoinArr = tradeCoinArr_New.Filter(tradeCoin.Coin);

                if (existingCoinTradeCoinArr.Count > 0) // If the coin is a duplicate
                {
                    foreach (TradeCoin curTradeCoin in existingCoinTradeCoinArr)
                        //Add the count of the new coin to the old tradecoin
                        (tradeCoinArr_New[tradeCoinArr_New.LastIndexOf(curTradeCoin)] as TradeCoin).Count += tradeCoin.Count; 
                }
                else tradeCoinArr_New.Add(tradeCoin);
            }
            return tradeCoinArr_New;
        }
        public long SumOfAllCounts()
        {
            //Returns the amount of all coins in this tradecoinArr
            long sum = 0;
            foreach (TradeCoin tradeCoin in this)
            {
                sum += tradeCoin.Count;
            }
            return sum;
        }
        public long CoinAmountPerClient(Client cl)
        {
            long sum = 0;
            foreach (TradeCoin tradeCoin in this)
            {
                if (tradeCoin.Trade.Client.Id == cl.Id) sum += tradeCoin.Count;
            }
            return sum;
        }
        public void Fill()
        {
            //Table full of TradeCoin from dal


            DataTable dataTable = TradeCoin_Dal.GetDataTable();

            //Move the values from the table to the TradeCoinArr
            //Line by line

            DataRow dataRow;
            TradeCoin curTradeCoin;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curTradeCoin = new TradeCoin(dataRow);
                this.Add(curTradeCoin);
            }
        }
        public TradeCoinArr Filter(Trade t)
        {
            //Filter TradeCoinArr by trade and return a TradeCoinArr
            TradeCoinArr tArrNew = new TradeCoinArr();
            if (t == null) return tArrNew; //If t is null return empty TradeCoinArr
            for (int i = 0; i < this.Count; i++)
            {
                if (t.Id == (this[i] as TradeCoin).Trade.Id) tArrNew.Add(this[i]);
            }
            return tArrNew;
        }
        public TradeCoinArr Filter(Client cl)
        {
            //Filter TradeCoinArr by trade and return a TradeCoinArr
            TradeCoinArr tArrNew = new TradeCoinArr();
            if (cl == null) return tArrNew; //If t is null return empty TradeCoinArr
            for (int i = 0; i < this.Count; i++)
            {
                if (cl.Id == (this[i] as TradeCoin).Trade.Client.Id) tArrNew.Add(this[i]);
            }
            return tArrNew;
        }
        public TradeCoinArr Filter(Coin c) //Polymorphism :)
        {
            TradeCoinArr tArrNew = new TradeCoinArr();
            if (c == null) return tArrNew;

            for (int i = 0; i < this.Count; i++)
            {
                if (c.Id == (this[i] as TradeCoin).Coin.Id) tArrNew.Add(this[i]);
            }
            return tArrNew;
        
        }

        public TradeCoinArr GetTop3TradeCoinForClient(Client cl)
        {
            TradeCoinArr tArr = this.Filter(cl);

            TradeCoin maxTradeCoin = new TradeCoin();  maxTradeCoin.Count = 0;
            TradeCoinArr tcArrNew = new TradeCoinArr();
            if (tArr.Count == 0) { return tcArrNew; }
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > maxTradeCoin.Count) { maxTradeCoin = tCoin; }
                
            }
            tArr.Remove(maxTradeCoin);

            tcArrNew.Add(maxTradeCoin)   ;
            if (tArr.Count == 0) { return tcArrNew; }

            TradeCoin secondMaxTradeCoin = new TradeCoin();
            secondMaxTradeCoin.Count = 0;
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > secondMaxTradeCoin.Count) { secondMaxTradeCoin = tCoin; }

            }
            tArr.Remove(secondMaxTradeCoin);
            tcArrNew.Add(secondMaxTradeCoin);

            if (tArr.Count == 0) { return tcArrNew; }

            TradeCoin thirdMaxTradeCoin = new TradeCoin(); thirdMaxTradeCoin.Count = 0;
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > thirdMaxTradeCoin.Count) { thirdMaxTradeCoin = tCoin; }
            }
            tcArrNew.Add(thirdMaxTradeCoin);
            return tcArrNew;
        }

        public CoinArr GetCoinArr()
        {

            //Return all the coins from the current TradeCoinArr

            CoinArr coinArr = new CoinArr();
            for (int i = 0; i < this.Count; i++)
                coinArr.Add((this[i] as TradeCoin).Coin);
            return coinArr;
        }
        public bool Insert()
        {

            // Add coins from trade to database
            TradeCoin tradeCoin = null;
            for (int i = 0; i < this.Count; i++)
            {
                tradeCoin = (this[i] as TradeCoin);
                if (!tradeCoin.Insert())
                    return false;
            }
            return true;
        }
        public bool Delete()
        {

            //Delete this TradeCoinArr from database

            for (int i = 0; i < this.Count; i++)
                (this[i] as TradeCoin).Delete();
            return true;
        }
    }
}
