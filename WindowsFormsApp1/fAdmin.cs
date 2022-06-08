using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        BindingSource EmployeeList = new BindingSource();
        BindingSource DriverList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        BindingSource Vehicle = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
            Load_gridview();
        }

        void Load_gridview()
        {
            driverGridView.DataSource = DriverList;
            AccountGridView.DataSource = AccountList;
            employeeGridView.DataSource = EmployeeList;
            vehicleGridView.DataSource = Vehicle;

            loadEmployeeGridView();
            loadVehicleGridView();
            loadDriverGridView();
            loadAccountGridView();

            empAddBind();
            driverAddBind();
            accountAddBind();
            loadVehicleBind();
            
        }
        
        void loadVehicleBind()
        {
            Vnum_Driver_TB.DataBindings.Add(new Binding("TEXT", vehicleGridView.DataSource, "VNUM", true, DataSourceUpdateMode.Never));
            RNUM_DRIVER_TB.DataBindings.Add(new Binding("TEXT", vehicleGridView.DataSource, "RNUM", true, DataSourceUpdateMode.Never));
            TYPE_DRIVER_TB.DataBindings.Add(new Binding("TEXT", vehicleGridView.DataSource, "VTYPE", true, DataSourceUpdateMode.Never));
        }

        void accountAddBind()
        {
            SSN_ACCOUNT_TB.DataBindings.Add(new Binding("TEXT", AccountGridView.DataSource, "SSN", true, DataSourceUpdateMode.Never));
            UserName_ACCOUNT_TB.DataBindings.Add(new Binding("TEXT", AccountGridView.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            TYPE_ACCOUNT_TB.DataBindings.Add(new Binding("TEXT", AccountGridView.DataSource, "ATYPE", true, DataSourceUpdateMode.Never));
            ID_ACCOUNT_TB.DataBindings.Add(new Binding("TEXT", AccountGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        void driverAddBind()
        {
            SSN_DRIVER_TB.DataBindings.Add(new Binding("TEXT", driverGridView.DataSource, "SSN", true, DataSourceUpdateMode.Never));
            LisenceID_DRIVER_TB.DataBindings.Add(new Binding("TEXT", driverGridView.DataSource, "LICENSE_ID", true, DataSourceUpdateMode.Never));
            exp_DRIVER_TB.DataBindings.Add(new Binding("TEXT", driverGridView.DataSource, "EXP", true, DataSourceUpdateMode.Never));
        }


        void empAddBind()
        {
            SSN_EMP_TB.DataBindings.Add(new Binding("TEXT", employeeGridView.DataSource, "SSN", true, DataSourceUpdateMode.Never));
            EID_EMP_TB.DataBindings.Add(new Binding("TEXT", employeeGridView.DataSource, "EID", true, DataSourceUpdateMode.Never));
            DATEBEGIN_EMP_TB.DataBindings.Add(new Binding("TEXT", employeeGridView.DataSource, "DateBegin", true, DataSourceUpdateMode.Never));
            SSSN_EMP_TB.DataBindings.Add(new Binding("TEXT", employeeGridView.DataSource, "SuperSSN", true, DataSourceUpdateMode.Never));
            SALARY_EMP_TB.DataBindings.Add(new Binding("TEXT",employeeGridView.DataSource,"SALARY",true,DataSourceUpdateMode.Never));
            EXP_EMP_TB.DataBindings.Add(new Binding("TEXT", employeeGridView.DataSource, "EXP", true, DataSourceUpdateMode.Never));
        }


        void loadVehicleGridView()
        {
            vehicleGridView.DataSource = VehicleDAO.Instance.getVehicleTable();
        }

        void loadDriverGridView()
        {
            DriverList.DataSource = DriverDAO.Instance.getDriverTable();
        }

        void loadAccountGridView()
        {
            AccountList.DataSource = AccountDAO.Instance.getAccountTable();
        }

        void loadEmployeeGridView()
        {

            EmployeeList.DataSource = EmployeeDAO.Instance.getEmployeeTable();
        } 
       

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadEmployeeGridView();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //here1
            loadVehicleGridView();
            loadDriverGridView();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            loadAccountGridView();
        }

        private void SSN_DRIVER_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void SSN_EMP_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
