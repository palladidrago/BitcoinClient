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
        public City City { get; set; }
        public Login Login { get; set; } //The client's login
        public int Id { get; set; } //Id of the client
        public string FirstName { get; set; } // First name of the client
        public string LastName { get; set; } // Last name of the client
        public double BtcAmount { get; set; } //Amount of bitcoinz
        public int BirthYear { get; set; } //Age
        public string PhoneNumber { get; set; } //Phone number
        public string BtcAddress { get; set; } //His bitcoin address

        public int ShoeSize { get; set; } //Shoe Size
        
        public Client() { }
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
            City = new City(dataRow.GetParentRow("ClientCity"));
            Login = new Login(dataRow.GetParentRow("ClientLogin"));

        }


        public override string ToString()
        { return $"{LastName.Trim()} {FirstName.Trim()}"; }
        public bool Insert()
        {
            //Insert this client into database
            return Client_Dal.Insert(FirstName, LastName, BirthYear, PhoneNumber, BtcAmount, BtcAddress, ShoeSize,City.Id,Login.Id);
        }
        public bool Update()
        {
            //Update client at given id in database
            return Client_Dal.Update(Id, FirstName, LastName, BirthYear, PhoneNumber, BtcAmount, BtcAddress, ShoeSize,City.Id,Login.Id);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(Id);
        }

    }
}
    
