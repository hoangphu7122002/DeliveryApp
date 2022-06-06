using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fUpdateAccount : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount; set => loginAccount = value;
        }

        public fUpdateAccount(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            changeAccount();
        }

        void changeAccount()
        {
            textBoxName.Text = this.LoginAccount.Name;
            textBoxUsername.Text = this.LoginAccount.Username;

        }

        void updateAccount()
        {
            string password = textBoxPassword.Text;
            string username = textBoxUsername.Text;
            string newPassword = textBoxNewPassword.Text;

            string retypePassword = textBoxRetypePassword.Text;

            if (newPassword != retypePassword)
            {
                MessageBox.Show("newPassword is different with retypePassword");
            }
            else
            {
                if (AccountDAO.Instance.updateAccount(username, password, newPassword))
                {
                    MessageBox.Show("update success!!!");
                }
                else
                {
                    MessageBox.Show("Please retype your password");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateAccount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRetypePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
