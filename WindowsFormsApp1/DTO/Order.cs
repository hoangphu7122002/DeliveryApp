using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DTO
{
    public class Order
    {
        private string orderid;
        private string ssn_cs;
        private string ssn_cr;
        private string ssn_emp;
        private string status;
        private string time;
        private List<Package> packages;
        private string paymentType;
        public string Orderid { get => orderid; set => orderid = value; }
        public string Ssn_cs { get => ssn_cs; set => ssn_cs = value; }
        public string Ssn_cr { get => ssn_cr; set => ssn_cr = value; }
        public string Time { get => time; set => time = value; }
       
        public string Ssn_emp { get => ssn_emp; set => ssn_emp = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public List<Package> Package { get => packages; set => packages = value; }
        public string Status { get => status; set => status = value; }

        public Order(string id, string orderid, string ssn_cs, string ssn_cr, string ssn_emp, string time, string paymentType, string status, List<Package> package)
        {
            Orderid = orderid;
            Ssn_cs = ssn_cs;
            Ssn_cr = ssn_cr;
            Time = time;
            this.packages = package;
            Ssn_emp = ssn_emp;
            PaymentType = paymentType;
            Status = status;
        }

        Order()
        {

        }

        public Order(DataRow row, DataTable packages)
        {
            Orderid = row["ORDERID"].ToString();
            Ssn_cr = row["SSN_CR"].ToString();
            Ssn_cs = row["SSN_CS"].ToString();
            Ssn_emp = row["SSN_EMP"].ToString();
            Time = row["OTIME"].ToString();
            PaymentType = row["PaymentType"].ToString();
            this.packages = new List<Package>();
            Status = row["STATUS"].ToString();
            foreach (DataRow row1 in packages.Rows)
            {
                Package package = new Package(row1);
                this.packages.Add(package);
            }
        }
    }
}
