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
        public string Name { get; set; }
        public int Id { get; set; }
        public Scam(string scamLevel, int Id) { this.Name = scamLevel; this.Id = Id; }
        public Scam() { }
        public Scam(DataRow dataRow)
        {
            this.Name = dataRow["ScamLevel"].ToString().Trim();
            this.Id = (int)dataRow["Id"];
        }
        public bool Insert()
        {
            return Scam_Dal.Insert(Name);
        }
        public bool Delete()
        {
            return Scam_Dal.Delete(Id);
        }

        public override string ToString()
        {
            return Name.Trim();
        }
    }
}
