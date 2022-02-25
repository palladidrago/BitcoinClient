using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace ClientApp.BL
{
    public class Coin
    {
        public string name { get; set; }
        public int id { get; set; }
        public Valid valid { get; set; }
        public Scam scam { get; set; }
        public Coin() { }
        public Coin(string name, int id)
        {
            this.id = id;
            this.name = name;
            this.valid = new Valid();
            this.scam = new Scam();
        }
        public Coin(DataRow dataRow)
        {   
            name = dataRow["Name"].ToString();
            id = (int)dataRow["id"];
            
        }
        public bool Insert()
        {
            return Coin_Dal.Insert(name,valid.id,scam.id);
        }
        public bool Delete()
        {
            return Coin_Dal.Delete(id);
        }

        public override string ToString()
        {
            return name.Trim();
        }
    }
}
