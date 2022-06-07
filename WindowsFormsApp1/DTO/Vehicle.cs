using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Vehicle
    {
        private string vnum;
        private string rnum;
        private string vtype;

        public string Vnum { get => vnum; set => vnum = value; }
        public string Rnum { get => rnum; set => rnum = value; }
        public string Vtype { get => vtype; set => vtype = value; }

        public Vehicle(string vnum, string rnum, string vtype)
        {
            Vnum = vnum;
            Rnum = rnum;
            Vtype = vtype;
        }

        public Vehicle(DataRow data)
        {
            Vnum = data["VNUM"].ToString();
            Rnum = data["RNUM"].ToString();
            Vtype = data["VTYPE"].ToString();
        }
    }
}
