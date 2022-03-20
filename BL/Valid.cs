using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;


namespace BL
    {
        public class Valid
        {
            public string name { get; set; } // Validation method
            public int id { get; set; } //Id
            public Valid(string validationMethod, int id) { this.name = validationMethod; this.id = id; }
            public Valid() { }
            public Valid(DataRow dataRow)
            {
                this.name = dataRow["Name"].ToString();
                this.id = (int)dataRow["Id"];
            }
            public bool Insert()
            {
                return Valid_Dal.Insert(name);
            }
            public bool Delete()
            {
                return Valid_Dal.Delete(id);
            }

            public override string ToString()
            {
                return name.Trim();
            }
        }
}
