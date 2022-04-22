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
    public class CountryArr : ArrayList
    {
        public bool IsContains(string countryName)
        {
            //Check wether country exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Country).Name == countryName)
                    return true;
            return false;
        }
        public Country GetCountryWithMaxId()
        {
            //Return the country with the highest id
            Country maxCountry = new Country();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Country).Id > maxCountry.Id)
                    maxCountry = this[i] as Country;

            return maxCountry;
        }
        
        public void Fill()
        {

            //Table full of cities from dal


            DataTable dataTable = Country_Dal.GetDataTable();

            //Move the clients from datatable to arr
            //Move every line

            DataRow dataRow;
            Country curCountry;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCountry = new Country(dataRow);
                this.Add(curCountry);
            }
        }
    }
}
