using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Dal;
using System.Data;

namespace BL
{
    public class Client
    {
        public City city { get; set; }
        public int id { get; set; } //Id of the client
        public string firstName { get; set; } // First name of the client
        public string lastName { get; set; } // Last name of the client
        public double btcAmount { get; set; } //Amount of bitcoinz
        public int birthYear { get; set; } //Age
        public string phoneNumber { get; set; } //Phone number
        public string btcAddress { get; set; } //His bitcoin address

        public int shoeSize { get; set; } //Shoe Size
        
        public Client() { }
        public Client(string firstName, string lastName, int birthYear, string phoneNumber, double btcAmount, string btcAddress, int shoeSize)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.btcAmount = btcAmount;
            this.birthYear = birthYear;
            this.phoneNumber = phoneNumber;
            this.btcAddress = btcAddress;
        }
        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            id = (int)dataRow["ID"];
            firstName = dataRow["FirstName"].ToString();
            lastName = dataRow["LastName"].ToString();
            birthYear = (int)dataRow["BirthYear"];
            phoneNumber = dataRow["PhoneNumber"].ToString();
            btcAmount = (double)dataRow["BtcAmount"];
            btcAddress = dataRow["BtcAddress"].ToString();
            shoeSize = (int)dataRow["ShoeSize"];
            city = new City(dataRow.GetParentRow("ClientCity"));

        }


        public override string ToString()
        { return $"{lastName.Trim()} {firstName.Trim()}"; }
        public bool Insert()
        {
            //Insert this client into database
            return Client_Dal.Insert(firstName, lastName, birthYear, phoneNumber, btcAmount, btcAddress, shoeSize,city.id);
        }
        public bool Update()
        {
            //Update client at given id in database
            return Client_Dal.Update(id, firstName, lastName, birthYear, phoneNumber, btcAmount, btcAddress, shoeSize,city.id);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(id);
        }

    }
}
    
