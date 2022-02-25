using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;


namespace ClientApp.BL
    {
        public class Valid
        {
            public string validationMethod { get; set; } // Validation method
            public int id { get; set; } //Id
            public Valid(string validationMethod, int id) { this.validationMethod = validationMethod; this.id = id; }
            public Valid() { }
            public Valid(DataRow dataRow)
            {
                this.validationMethod = dataRow["Valid"].ToString();
                this.id = (int)dataRow["Id"];
            }
            public bool Insert()
            {
                return Valid_Dal.Insert(validationMethod);
            }
            public bool Delete()
            {
                return Valid_Dal.Delete(id);
            }

            public override string ToString()
            {
                return validationMethod.Trim();
            }
        }
}
