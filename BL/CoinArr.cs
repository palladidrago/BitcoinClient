using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Dal;

namespace ClientApp.BL
{
    internal class CoinArr : ArrayList
    {
        public bool IsContains(string cityName)
        {
            //Check wether city exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).name == cityName)
                    return true;
            return false;
        }
        public Coin GetCityWithMaxId()
        {
            //Return the city with the highest id
            Coin maxCity = new Coin();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Coin).id > maxCity.id)
                    maxCity = this[i] as Coin;

            return maxCity;
        }
        public void Fill()
        {

            //Table full of cities from dal


            DataTable dataTable = Coin_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Coin curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new Coin(dataRow);
                this.Add(curCity);
            }
        }
        public CoinArr Filter(string name, Scam scam, Valid valid)
        {
            CoinArr coinArr = new CoinArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Coin coin = (this[i] as Coin);
                if (

                //Filter by coin

                coin.name.StartsWith(name)

                //Filter by valid
                && (valid == null || valid.id == -1 || coin.valid.id == valid.id)
                //סינון לפי קטגוריה
                && ( scam == null || scam.id == -1 || coin.scam.id == scam.id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    coinArr.Add(coin);
            }
            return coinArr;
        }
    }
}
