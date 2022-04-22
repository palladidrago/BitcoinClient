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
        public Country Country { get; set; }
        public Login Login { get; set; } //The client's login
        public int Id { get; set; } //Id of the client
        public string FirstName { get; set; } // First name of the client
        public string LastName { get; set; } // Last name of the client
        public double BtcAmount { get; set; } //Amount of bitcoinz
        public int BirthYear { get; set; } //Age
        public string Mail { get; set; } //Phone number
        public string BtcAddress { get; set; } //His bitcoin address

        
        public Client() { }
        public Client(DataRow dataRow)
        {

            //Creates a client from a client row

            Id = (int)dataRow["ID"];
            FirstName = dataRow["FirstName"].ToString();
            LastName = dataRow["LastName"].ToString();
            BirthYear = (int)dataRow["BirthYear"];
            Mail = dataRow["Mail"].ToString();
            BtcAmount = (double)dataRow["BtcAmount"];
            BtcAddress = dataRow["BtcAddress"].ToString();
            Country = new Country(dataRow.GetParentRow("ClientCountry"));
            Login = new Login(dataRow.GetParentRow("ClientLogin"));

        }


        public override string ToString()
        { return $"{LastName.Trim()} {FirstName.Trim()}"; }
        public bool Insert()
        {
            //Insert this client into database
            return Client_Dal.Insert(FirstName, LastName, BirthYear, Mail, BtcAmount, BtcAddress,Country.Id,Login.Id);
        }
        public bool Update()
        {
            //Update client at given id in database
            return Client_Dal.Update(Id, FirstName, LastName, BirthYear, Mail, BtcAmount, BtcAddress,Country.Id,Login.Id);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(Id);
        }

    }
}
    
