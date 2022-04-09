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
    class TradeCoinArr : ArrayList
    {

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
        public CoinArr GetTop3CoinsForClient(Client cl)
        {
            TradeCoinArr tArr = this.Filter(cl);
            TradeCoin maxTradeCoin = new TradeCoin();
            maxTradeCoin.Count = 0;
            int iMax = 0;
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > maxTradeCoin.Count) { maxTradeCoin = tCoin; iMax = i; }
                
            }
            tArr.RemoveAt(iMax);

            TradeCoin secondMaxTradeCoin = new TradeCoin();
            secondMaxTradeCoin.Count = 0;
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > secondMaxTradeCoin.Count) { secondMaxTradeCoin = tCoin; iMax = i; }

            }
            tArr.RemoveAt(iMax);
            TradeCoin thirdMaxTradeCoin = new TradeCoin();
            thirdMaxTradeCoin.Count = 0;
            for (int i = 0; i < tArr.Count; i++)
            {
                TradeCoin tCoin = tArr[i] as TradeCoin;
                if (tCoin.Count > thirdMaxTradeCoin.Count) { thirdMaxTradeCoin = tCoin; iMax = i; }
            }
            CoinArr cArrNew = new CoinArr();
            cArrNew.Add(maxTradeCoin.Coin);
            cArrNew.Add(secondMaxTradeCoin.Coin);
            cArrNew.Add(thirdMaxTradeCoin.Coin);
            return cArrNew;
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
