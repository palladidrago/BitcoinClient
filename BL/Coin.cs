using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class Coin
    {
        public string name { get; set; }
        public int id { get; set; }
        public string symbol { get; set; }
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
            id = (int)dataRow["id"];
            name = dataRow["Name"].ToString().Trim();
            symbol = dataRow["Symbol"].ToString().Trim();

            valid = new Valid(dataRow.GetParentRow("CoinValid"));
            scam = new Scam(dataRow.GetParentRow("CoinScam"));

        }
        public bool Insert()
        {
            return Coin_Dal.Insert(name,symbol,valid.id,scam.id);
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
