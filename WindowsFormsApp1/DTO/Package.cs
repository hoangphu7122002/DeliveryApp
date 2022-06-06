using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Package
    {
        private string pid;
        private float weight;
        private string type;
        private byte typeLevel;
        private string ssnDriver;
        private string location;
        private string orderId;
        private string time;

        public string Pid { get => pid; set => pid = value; }
        public float Weight { get => weight; set => weight = value; }
        public string Type { get => type; set => type = value; }
        public byte TypeLevel { get => typeLevel; set => typeLevel = value; }
        public string SsnDriver { get => ssnDriver; set => ssnDriver = value; }
        public string Location { get => location; set => location = value; }
        public string OrderId { get => orderId; set => orderId = value; }
        public string Time { get => time; set => time = value; }

        public Package()
        {

        }

        public Package(string pid, float weight, string type, byte typeLevel, string ssnDriver, string location, string orderId, string time)
        {
            this.pid = pid;
            this.weight = weight;
            this.type = type;
            this.typeLevel = typeLevel;
            this.ssnDriver = ssnDriver;
            this.location = location;
            this.orderId = orderId;
            this.time = time;
        }

        public Package(DataRow row)
        {
            this.pid = row["PID"].ToString();
            this.weight = (float)row["PWEIGHT"];
            this.type = row["TypeName"].ToString();
            this.typeLevel = (byte)row["TypeLevel"];
            this.ssnDriver = row["SSN"].ToString();
            this.location = row["LOCATION"].ToString();
            this.orderId = row["ORDERID"].ToString();
            this.time = row["TIME"].ToString();
        }

        public void setPackage(DataRow row)
        {
            this.pid = row["PID"].ToString();
            this.weight = (int)row["PWEIGHT"];
            this.type = row["TypeName"].ToString();
            this.typeLevel = (byte)row["TypeLevel"];
            this.ssnDriver = row["SSN"].ToString();
            this.location = row["LOCATION"].ToString();
            this.orderId = row["ORDERID"].ToString();
            this.time = row["TIME"].ToString();
        }
    }
}
