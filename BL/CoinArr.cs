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
    internal class CoinArr : ArrayList
    {
        public bool IsContains(string cityName)
        {
            //Check wether city exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Name == cityName)
                    return true;
            return false;
        }
        public Coin GetCityWithMaxId()
        {
            //Return the city with the highest id
            Coin maxCity = new Coin();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Id > maxCity.Id)
                    maxCity = this[i] as Coin;

            return maxCity;
        }
        public void Fill()
        {

            //Table full of cities from dal


            DataTable dataTable = Coin_Dal.GetDataTable();

            //Move the values from the table to the TradeCoinArr
            //Line by line


            DataRow dataRow;
            Coin curCoin;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCoin = new Coin(dataRow);
                this.Add(curCoin);
            }
        }
        public CoinArr Filter(string name="", Scam scam=null, Valid valid=null)
        {
            //Does this work with default null Values? 
            CoinArr coinArr = new CoinArr();

            for (int i = 0; i < this.Count; i++)
            {

                //Add the current coin to helper var

                Coin coin = (this[i] as Coin);
                if (

                //Filter by coin

                coin.Name.ToLower().StartsWith(name.ToLower())

                //Filter by valid
                && (valid == null || valid.Id == -1 || coin.Valid.Id == valid.Id)
                //Filter by scam
                && ( scam == null || scam.Id == -1 || coin.Scam.Id == scam.Id)
                )

                    //If coin is valid, add

                    coinArr.Add(coin);
            }
            return coinArr;
        }
        public void Remove(CoinArr coinArr)
        {

            //Remove from current coin array the given array (WOW)

            for (int i = 0; i < coinArr.Count; i++)
                this.Remove(coinArr[i] as Coin); //ArrayList.Remove(): remove specific item from arraylist :O
        }
        public void Remove(Coin coin)
        {

            //Remove from current array given coin

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Id == coin.Id)
                {
                    this.RemoveAt(i); return;
                }
            //Wouldn't it be faster to use Remove(coin)??
        }
    }
}
