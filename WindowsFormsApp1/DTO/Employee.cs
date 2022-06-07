using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DTO
{
    public class Employee
    {
        private string ssn;
        private string eID;
        private string dateBegin;
        private byte EXP;
        private string superSSN;
        private string salary;

        public string Ssn { get => ssn; set => ssn = value; }
        public string EID { get => eID; set => eID = value; }
        public string DateBegin { get => dateBegin; set => dateBegin = value; }
        public byte EXP1 { get => EXP; set => EXP = value; }
        public string SuperSSN { get => superSSN; set => superSSN = value; }
        public string Salary { get => salary; set => salary = value; }

        public Employee(string ssn, string eID, string dataBegin, byte eXP, string superSSN, string salary)
        {
            Ssn = ssn;
            EID = eID;
            DateBegin = dataBegin;
            EXP1 = eXP;
            SuperSSN = superSSN;
            Salary = salary;
        }

        public Employee(DataRow data)
        {
            Ssn = data["SSN"].ToString();
            EID = data["EID"].ToString();
            DateBegin = data["DateBegin"].ToString();
            EXP1 = (byte)data["EXP"];
            SuperSSN = data["SuperSSN"].ToString();
            Salary = EmployeeDAO.Instance.getSalaryEmp(this.ssn);

        }
    }
}
