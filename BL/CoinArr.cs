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
    public class CoinArr : ArrayList
    {
        public bool IsContains(string coinName)
        {
            //Check wether coin exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Name == coinName)
                    return true;
            return false;
        }
        public Coin GetCoinWithMaxId()
        {
            //Return the coin with the highest id
            Coin maxCoin = new Coin();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Id > maxCoin.Id)
                    maxCoin = this[i] as Coin;

            return maxCoin;
        }
        public void Fill()
        {

            //Table full of coin from dal


            DataTable dataTable = Coin_Dal.GetDataTable();

            //Move the values from the table to the CoinArr
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
        public CoinArr Filter(string name="", Scam scam=null, Valid valid=null,long count=0)
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
                && (scam == null || scam.Id == -1 || coin.Scam.Id == scam.Id)

                && (count == 0 || count <= coin.Supply) //If you have at least that many
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
                this.Remove(coinArr[i] as Coin); //Remove(): Remove from current array given coin
        }
        public void Remove(Coin coin)
        {

            //Remove from current array given coin

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Id == coin.Id)
                {
                    this.RemoveAt(i); return;
                }
            
        }
        public void UpdateSupply()
        {
            //Update(refresh) the supply for every coin

            for (int i = 0; i < this.Count; i++)
                (this[i] as Coin).UpdateSupply();
        }
        public void UpdateSupply(Coin coin)
        {

            //Update specific coin in array

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).Id == coin.Id)
                {
                    this[i] = coin;
                    return;
                }
        }
    }
}
