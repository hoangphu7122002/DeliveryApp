using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1.DTO
{
    public class Person
    {
        private string fName;
        private string lName;
        private string SSN;
        private char gender;
        private int numberPhone;
        private int numberMail;
        private string[] phone = new string[5];
        private string[] mail = new string[5];

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string SSN1 { get => SSN; set => SSN = value; }
        public char Gender { get => gender; set => gender = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int NumberMail { get => numberMail; set => numberMail = value; }
        public string[] Phone { get => phone; set => phone = value; }
        public string[] Mail { get => mail; set => mail = value; }

        public Person(string SSN, string fName, string lName, char gender, int numberPhone, int numberMail, string[] phone, string[] mail)
        {
            this.SSN = SSN;
            this.fName = fName;
            this.lName = lName;
            this.gender = gender;
            this.numberPhone = numberPhone;
            this.numberPhone = numberMail;
            for (int i = 0; i < this.numberPhone; ++i)
            {
                this.phone[i] = phone[i];
            }
            for (int i = 0; i < this.numberMail; ++i)
            {
                this.mail[i] = mail[i];
            }
        }

        public Person(DataRow rowPerson, DataTable tablePhone, DataTable tableMail)
        {
            this.SSN = rowPerson["SSN"].ToString();
            this.fName = rowPerson["FirstName"].ToString();
            this.lName = rowPerson["LastName"].ToString();
            this.gender = (char)rowPerson["Gender"];
            this.numberPhone = tablePhone.Rows.Count;
            this.numberMail = tableMail.Rows.Count;
            int i = 0;
            int j = 0;
            foreach (DataRow row in tablePhone.Rows)
            {
                if (i == 5)
                {
                    break;
                }
                this.phone[i] = row["PHONE"].ToString();
                i++;
            }
            foreach (DataRow row in tableMail.Rows)
            {
                if (j == 5)
                {
                    break;
                }
                this.mail[j] = row["MAIL"].ToString();
                j++;
            }
        }
    }


}
