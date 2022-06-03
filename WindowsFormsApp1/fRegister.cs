using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool checkSSN(string ssn)
        {
            //check length
            if (ssn.Length != 9)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{9}");
            var result = r.Match("191973998");
            return result.Success;
        }

        bool checkGender(char g)
        {
            if (g != 'M' && g != 'F'){
                return false;
            }
            return true;
        }

        bool checkFirstName(string fName)
        {
            if (fName.Length == 0 || fName == "") return false;
            return Regex.Match(fName, "^[A-Z][a-zA-Z]*$").Success;
        }

        bool checkLastName(string lName)
        {
            if (lName.Length == 0 || lName == "") return false;
            return Regex.Match(lName, "^[A-Z][a-zA-Z]*$").Success;
        }

        bool checkPhone(string phone)
        {
            if (phone.Length != 10) return false;
            Regex r = new Regex(@"^[0-9]{10}");
            return r.Match(phone).Success;
        }

        bool checkMail(string mail)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            return Regex.IsMatch(mail, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = fNameTextbox.Text;
            string lName = lNameTextbox.Text;
            string ssn = SSNTextbox.Text;
            char gender = GenderComboBox.Text[0];

            if (checkFirstName(fName) == false)
            {
                MessageBox.Show("INVALID FIRST NAME!!!");
                return;
            } 

            if (checkLastName(lName) == false)
            {
                MessageBox.Show("INVALID LAST NAME!!!");
                return;
            }

            if (checkSSN(ssn) == false)
            {
                MessageBox.Show("INVALID SSN");
                return;
            }

            if (checkGender(gender) == false)
            {
                MessageBox.Show("INVALID GENDER");
                return;
            }
            string[] phone = phoneTextBox.Text.Split('\r');
            HashSet<string> phone_set = new HashSet<string>();

            for (int i = 0; i < phone.Length; ++i)
            {

                if (checkPhone(phone[i]) == false)
                {
                    MessageBox.Show("invalid phone " + phone[i]);
                    return;
                }
                if (phone_set.Contains(phone[i])) 
                {
                    MessageBox.Show("Duplicate phone " + phone[i]);
                    return;
                }
                else
                {
                    phone_set.Add(phone[i]);
                }
            }
            HashSet<string> mail_set = new HashSet<string>();
            string[] mail = mailTextbox.Text.Split('\r');
            for (int i = 0; i < mail.Length; ++i)
            {
                if (checkMail(mail[i]) == false)
                {
                    MessageBox.Show("invalid mail " + mail[i]) ;
                    return;
                }
                if (mail_set.Contains(mail[i]))
                {
                    MessageBox.Show("invavlid phone " + mail[i]);
                }
                else
                {
                    mail_set.Add(mail[i]);
                }
            }
            //check ssn in database
            if (checkSSNinDB(ssn))
            {
                MessageBox.Show("SSN is exist, please retype another!!");
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure to go next step Yes/No", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Person p = new Person(ssn,fName,lName,gender,phone.Length,mail.Length,phone,mail);
                fRegisterAccount f = new fRegisterAccount(p);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

        }

        bool checkSSNinDB(string ssn)
        {
            return PersonDAO.Instance.customerInDatabase(ssn);
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
