using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class Scam
    {
        public string name { get; set; }
        public int id { get; set; }
        public Scam(string scamLevel, int id) { this.name = scamLevel; this.id = id; }
        public Scam() { }
        public Scam(DataRow dataRow)
        {
            this.name = dataRow["ScamLevel"].ToString();
            this.id = (int)dataRow["Id"];
        }
        public bool Insert()
        {
            return Scam_Dal.Insert(name);
        }
        public bool Delete()
        {
            return Scam_Dal.Delete(id);
        }

        public override string ToString()
        {
            return name.Trim();
        }
    }
}
