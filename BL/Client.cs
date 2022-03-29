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
        public int Id { get; set; } //Id of the client
        public string FirstName { get; set; } // First name of the client
        public string LastName { get; set; } // Last name of the client
        public double BtcAmount { get; set; } //Amount of bitcoinz
        public int BirthYear { get; set; } //Age
        public string PhoneNumber { get; set; } //Phone number
        public string BtcAddress { get; set; } //His bitcoin address

        public int ShoeSize { get; set; } //Shoe Size
        public Client() { }
        public Client(string FirstName, string LastName, int BirthYear, string PhoneNumber, double BtcAmount, string BtcAddress, int ShoeSize)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BtcAmount = BtcAmount;
            this.BirthYear = BirthYear;
            this.PhoneNumber = PhoneNumber;
            this.BtcAddress = BtcAddress;
            this.ShoeSize = ShoeSize;
        }
        public Client(DataRow dataRow)
        {

            //Creates a client from a client row

            Id = (int)dataRow["ID"];
            FirstName = dataRow["FirstName"].ToString();
            LastName = dataRow["LastName"].ToString();
            BirthYear = (int)dataRow["BirthYear"];
            PhoneNumber = dataRow["PhoneNumber"].ToString();
            BtcAmount = (double)dataRow["BtcAmount"];
            BtcAddress = dataRow["BtcAddress"].ToString();
            ShoeSize = (int)dataRow["ShoeSize"];
            city = new City(dataRow.GetParentRow("ClientCity"));

        }


        public override string ToString()
        { return $"{LastName.Trim()} {FirstName.Trim()}"; }
        public bool Insert()
        {
            //Insert this client into database
            return Client_Dal.Insert(FirstName, LastName, BirthYear, PhoneNumber, BtcAmount, BtcAddress, ShoeSize,city.Id);
        }
        public bool Update()
        {
            //Update client at given id in database
            return Client_Dal.Update(Id, FirstName, LastName, BirthYear, PhoneNumber, BtcAmount, BtcAddress, ShoeSize,city.Id);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(Id);
        }

    }
}
    
