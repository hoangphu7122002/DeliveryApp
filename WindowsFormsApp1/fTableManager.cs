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
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }

        public fTableManager(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();

            changeAccount();
            loadOrder();
        }


        void loadOrder()
        {
            List<Order> orders = OrderDAO.Instance.loadOrderList();
            foreach (Order order in orders)
            {
                Button button = new Button() { Width = OrderDAO.OrderWidth, Height = OrderDAO.OrderHeight };
                button.Text = "Order" + Environment.NewLine + order.Orderid;
                button.Tag = order;

                button.Click += myButton_Click;
                
                if (order.Status == "PROGRESS")
                {
                    button.BackColor = Color.Aqua;
                }
                else
                {
                    button.BackColor = Color.LightPink;
                }
                flipTable.Controls.Add(button);
            }
        }

        void myButton_Click(object sender, EventArgs e)
        {
            Order order = ((sender as Button).Tag as Order);
            showListView(order);

        }

        void showListView(Order order)
        {
            string order_id = order.Orderid.ToString();
            SSN_CS.Text = order.Ssn_cr.ToString();
            SSN_CR.Text = order.Ssn_cs.ToString();
            SSN_EMP.Text = order.Ssn_emp.ToString();
            TYPEPAY.Text = order.PaymentType.ToString();

            string ssn_cr = order.Ssn_cr.ToString();
            string add_cr = PersonDAO.Instance.get_address(ssn_cr);

            LOC_TO.Text = add_cr;
            PRICE.Text = (OrderDAO.Instance.getCost(add_cr, order_id) * 15).ToString();


            listViewAdmin.Items.Clear();
            List<Package>packages = PackageDAO.Instance.loadPackageList(order_id);
            foreach (Package item in packages)
            {
                ListViewItem listViewItem = new ListViewItem(item.Pid.ToString());
                listViewItem.SubItems.Add(item.Type.ToString());
                listViewItem.SubItems.Add(item.TypeLevel.ToString());
                listViewItem.SubItems.Add(item.Weight.ToString());
                listViewItem.SubItems.Add(item.SsnDriver.ToString());
                listViewItem.SubItems.Add(item.Time.ToString());
                listViewItem.SubItems.Add(item.Location.ToString());

                listViewAdmin.Items.Add(listViewItem);
            } 
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
            fUpdateAccount f = new fUpdateAccount(loginAccount);
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
                /*employeeToolStripMenuItem.Enabled = loginAccount.Type == "EMPLOYEE";
                driverToolStripMenuItem.Enabled = loginAccount.Type == "DRIVER";
                customerToolStripMenuItem.Enabled = loginAccount.Type == "CUSTOMER";*/
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flipTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TYPEPAY_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //
            string answer = textBoxAdmin.Text;
            if (answer == "")
            {
                MessageBox.Show("Invalid Input OrderID!!!");
            }
            else if (OrderDAO.Instance.orderIDinDB(answer) == false)
            {
                MessageBox.Show("OrderID not in DB"); 
            }
            else {
                //delete order
                string status = OrderDAO.Instance.getStatus(answer);
                if (status == "CLOSE")
                {
                    if (OrderDAO.Instance.deleteOrder(answer) > 0)
                    {
                        MessageBox.Show("DELETE SUCCESS!!!");
                        this.Close();
                        fTableManager f = new fTableManager(this.loginAccount);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("SOME ERROR MAY EXIST!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Order IN PROGRESS, NOT FOLLOW DELETE");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string answer = textBoxAdmin.Text;
            if (answer == "")
            {
                MessageBox.Show("Invalid Input OrderID!!!");
            }
            else if (OrderDAO.Instance.orderIDinDB(answer) == false)
            {
                MessageBox.Show("OrderID not in DB");
            }
            else
            {
                //delete order
                string status = OrderDAO.Instance.getStatus(answer);
                if (status != "CLOSE")
                {
                    if (OrderDAO.Instance.changeStatus(answer) > 0)
                    {
                        MessageBox.Show("CHANGE STATUS SUCCESS!!!");
                        this.Close();
                        fTableManager f = new fTableManager(this.loginAccount);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("SOME ERROR MAY EXIST!!!");
                    }
                }
            }
        }

        private void LOC_TO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
