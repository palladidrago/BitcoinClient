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
    class ScamArr : ArrayList
    {
        public bool IsContains(string scamLevel)
        {
            //Check wether city exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Scam).name == scamLevel)
                    return true;
            return false;
        }
        public City GetCityWithMaxId()
        {
            //Return the city with the highest id
            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as City).id > maxCity.id)
                    maxCity = this[i] as City;

            return maxCity;
        }
        public void Fill()
        {

            //Table full of cities from dal


            DataTable dataTable = City_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            City curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new City(dataRow);
                this.Add(curCity);
            }
        }
    }
}