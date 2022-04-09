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
        public ClientArr Filter(string lastName="",string btcAddress = "",string username = "",City city = null)
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
                (city == null || city.Id == client.City.Id)) //If null or there is city with same id

                    clientArr.Add(client);
            }
            return clientArr;
        }
        public CityArr GetCityArr()
        {
            //Returns array of all non repeating cities in this arr
            CityArr cityArr = new CityArr();
            City curCity;
            foreach (Client client in this)
            {
                curCity = client.City;
                if (!cityArr.IsContains(curCity.Name))
                    cityArr.Add(curCity);
            }
            return cityArr;
        }
        public bool DoesExist(City curCity)
        {

            //Returns whether there is at least one client with city

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).City.Id == curCity.Id)
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

            // Returns sorted dictionary with name and city name and clients per city
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            CityArr clientsCityArr = this.GetCityArr();
            foreach (City curCity in clientsCityArr)
                dictionary.Add(curCity.Name, this.Filter(city: curCity).Count); //City name + clients in the city
            return dictionary;
        }
    }
}
