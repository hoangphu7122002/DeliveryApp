using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Account
    {
        public Account(string username, string type, string name, string password = null)
        {
            this.username = username;
            this.type = type;
            this.password = password;
            this.name = name;
        }

        public Account(DataRow row,string name)
        {
            this.username = row["UserName"].ToString();
            this.password = row["PASS"].ToString();
            this.type = row["ATYPE"].ToString();
            this.name = name;
        }

        private string username;
        private string password;
        private string type;
        private string name;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
    }
}
