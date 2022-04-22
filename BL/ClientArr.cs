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
    public class ClientArr : ArrayList
    {
        public ClientArr Filter(string lastName="",string btcAddress = "",string username = "",Country country = null)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {


                client = (this[i] as Client);
                if
                (client.LastName.ToLower().StartsWith(lastName.ToLower()) &&
                client.BtcAddress.Contains(btcAddress) &&
                client.Login.Username.ToLower().StartsWith(username.ToLower()) &&
                (country == null || country.Id == client.Country.Id)) //If null or there is country with same id

                    clientArr.Add(client);
            }
            return clientArr;
        }
        public CountryArr GetCountryArr()
        {
            //Returns array of all non repeating cities in this arr
            CountryArr countryArr = new CountryArr();
            Country curCountry;
            foreach (Client client in this)
            {
                curCountry = client.Country;
                if (!countryArr.IsContains(curCountry.Name))
                    countryArr.Add(curCountry);
            }
            return countryArr;
        }
        public bool DoesExist(Country curCountry)
        {

            //Returns whether there is at least one client with country

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).Country.Id == curCountry.Id)
                    return true;

            return false;
        }
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות


            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }
        }
        public Client GetClientWithLogin(Login login)
        {
            //Return the client with given login
            foreach (Client c in this)
            {
                if (c.Login.Id == login.Id) return c;
            }
            return null;
        }
        public SortedDictionary<string, int> GetSortedDictionary()
        {

            // Returns sorted dictionary with name and country name and clients per country
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            CountryArr clientsCountryArr = this.GetCountryArr();
            foreach (Country curCountry in clientsCountryArr)
                dictionary.Add(curCountry.Name, this.Filter(country: curCountry).Count); //Country name + clients in the country
            return dictionary;
        }
    }
}
