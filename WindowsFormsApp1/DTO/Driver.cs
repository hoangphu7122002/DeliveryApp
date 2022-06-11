using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DTO
{
    public class Driver
    {
        private string ssn;
        private string lisenceID;
        private byte exp;
        private List<Vehicle> vehicles;
        private string salary;

        public Driver(string ssn, string lisenceID, byte exp, List<Vehicle> vehicles, string salary)
        {
            this.ssn = ssn;
            this.lisenceID = lisenceID;
            this.exp = exp;
            this.vehicles = vehicles;
            this.salary = salary;
        }

        public string Ssn { get => ssn; set => ssn = value; }
        public string LisenceID { get => lisenceID; set => lisenceID = value; }
        public byte Exp { get => exp; set => exp = value; }
        public List<Vehicle> Vehicles { get => vehicles; set => vehicles = value; }
        public string Salary { get => salary; set => salary = value; }

        public Driver(string ssn,string lisenceID,byte exp)
        {
            Ssn = ssn;
            LisenceID = lisenceID;
            Exp = exp;
        }

        public Driver(DataRow data)
        {
            Ssn = data["SSN"].ToString();
            LisenceID = data["LICENSE_ID"].ToString();
            Exp = (byte)data["EXP"];
            Vehicles = new List<Vehicle>();
            DataTable dataTable = VehicleDAO.Instance.getVehicle(this.ssn);
            foreach(DataRow row in dataTable.Rows)
            {
                Vehicle vehicle = new Vehicle(row);
                Vehicles.Add(vehicle);
            }
            Salary = DriverDAO.Instance.getSalary(this.ssn);
        }
    }
}
