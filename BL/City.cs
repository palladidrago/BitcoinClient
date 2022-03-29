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
        public string Name { get; set; } //Name of the city
        public int Id { get; set; } //Id of the city
        public City (string Name)
        {
            this.Name = Name;
        }
        public City() { }
        public City (DataRow dataRow)
        {
            this.Name = dataRow["Name"].ToString();
            this.Id = (int)dataRow["Id"];
        }
        public bool Insert()
        {
            return City_Dal.Insert(Name);
        }
        public bool Delete()
        {
            return City_Dal.Delete(Id);
        }
    
        public override string ToString()
        {
            return Name.Trim();
        }
    }
}
