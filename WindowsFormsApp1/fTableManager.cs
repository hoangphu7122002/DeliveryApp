using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }

        public fTableManager(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();

            changeAccount();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        
        void changeAccount()
        {
            adminToolStripMenuItem.Enabled = loginAccount.Type == "ADMIN";
            if (adminToolStripMenuItem.Enabled == false) { 
                employeeToolStripMenuItem.Enabled = loginAccount.Type == "EMPLOYEE";
                driverToolStripMenuItem.Enabled = loginAccount.Type == "DRIVER";
                customerToolStripMenuItem.Enabled = loginAccount.Type == "CUSTOMER";
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
