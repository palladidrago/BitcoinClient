using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class City
    {
        public string name { get; set; } //Name of the city
        public int id { get; set; } //Id of the city
        public City (string name,int id)
        {
            this.name = name;
        }
        public City() { }
        public City (DataRow dataRow)
        {
            this.name = dataRow["Name"].ToString();
            this.id = (int)dataRow["Id"];
        }
        public bool Insert()
        {
            return City_Dal.Insert(name);
        }
        public bool Delete()
        {
            return City_Dal.Delete(id);
        }
    
        public override string ToString()
        {
            return name.Trim();
        }
    }
}
