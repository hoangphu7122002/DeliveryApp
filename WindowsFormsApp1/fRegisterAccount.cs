using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class fRegisterAccount : Form
    {
        private Person per;

        public Person Per { get => per; set => per = value; }


        public fRegisterAccount(Person p)
        {
            InitializeComponent();
            this.per = p;
        }

        public String generateRandomString()
        {
            Random res = new Random();

            // String that contain both alphabets and numbers
            String str = "0123456789";
            int size = 10;

            // Initializing the empty string
            String randomstring = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(str.Length);

                // Appending the character at the 
                // index to the random alphanumeric string.
                randomstring = randomstring + str[x];
            }
            return randomstring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextbox.Text;
            string retypePassword = RetypePassTextbox.Text;
            if (password != retypePassword)
            {
                MessageBox.Show("UNMATCH PASSWORD AND RETYPE PASSWORD!!");
                return;
            }
            if (username.Length > 32 || Regex.Match(username, "^[a-z0-9][-a-z0-9._]+@test.com").Success == false)
            {
                MessageBox.Show("InvalidUsername!!");
                return;
            }
            if (password.Length > 32 || password == "")
            {
                MessageBox.Show("InvalidPassword!!");
                return;
            }

            //check username in database
            if (checkUsernameinDB(username))
            {
                MessageBox.Show("ACCOUNT EXIST, PLEASE RETYPE ANOTHER!!");
            }

            //insert person - ssn, fname, lname, gender
            PersonDAO.Instance.insertPepole(this.per);

            //insert personPhone
            PersonDAO.Instance.insertPhone(this.per);

            //insert personMail
            PersonDAO.Instance.insertMail(this.per);

            //insert account require genID
            bool result = PersonDAO.Instance.insertAccount(username, password, this.per.SSN1);
            if (result == false)
            {
                MessageBox.Show("INSERT FAIL!!!");
            }
        }

        bool checkUsernameinDB(string username)
        {
            return PersonDAO.Instance.checkExistAccout(username);
        }


        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
