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
using System.Text.RegularExpressions;
using WindowsFormsApp1.DTO;
using System.Numerics;

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

            notWrite();
            
        }
        
        void notWrite()
        {
            SSN_ACCOUNT_TB.Enabled = false;
            SSN_DRIVER_TB.Enabled = false;
            SSN_EMP_TB.Enabled = false;
            Vnum_Driver_TB.Enabled = false;
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

        bool checkSSN(string ssn)
        {
            //check length
            if (ssn.Length != 9)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{9}");
            var result = r.Match(ssn);
            return result.Success;
        }

        bool checkEXP(byte exp)
        {
            //check length
            
            Regex r = new Regex(@"^[1-9]");
            var result = r.Match(exp.ToString().Trim());
            return result.Success;
        }

        bool checkDateBegin(string dateBegin)
        {
            Regex r = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
            var result = r.Match(dateBegin);
            return result.Success;
        }

        bool checkEID(string eid)
        {
            //check length
            if (eid.Length != 7)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{7}");
            var result = r.Match(eid);
            return result.Success;
        }

        bool checkLisenceID(string lisenceID)
        {
            //check length
            if (lisenceID.Length != 9)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{9}");
            var result = r.Match(lisenceID);
            return result.Success;
        }


        bool checkRNUM(string rnum)
        {
            if (rnum.Length != 8)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{8}");
            var result = r.Match(rnum);
            return result.Success;
        }

        bool checkTypeDriver(string type)
        {
            List<string> drivers = new List<string>() { "MOTOR", "BIKE", "CAR", "TRUCK" };

            foreach(string driver in drivers)
            {
                if (type == driver)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update employee button
            string ssn = SSN_EMP_TB.Text.Trim();
            string eid = EID_EMP_TB.Text.Trim();
            string dateBegin = DATEBEGIN_EMP_TB.Text.Trim();
            byte exp = (byte)(EXP_EMP_TB.Text.Trim()[0] - 48);
            string supperSSN = SSSN_EMP_TB.Text.Trim();

            //check valid
            //check eid with valid format and unique

            //check datebegin with valid format ../../....
            //check exp > 0
            //check supperSSN != ssn and supperSSN is valid format, and supperSSN is Unique
            if (supperSSN != "")
            {
                if (!checkSSN(supperSSN) || supperSSN == ssn)
                {
                    MessageBox.Show("INVALID FORMAT SUPPER SSN");
                    return;
                }
                if (!EmployeeDAO.Instance.checkInSupperSSN(supperSSN))
                {
                    MessageBox.Show("SUPPER SSN INVALID WITH DATABASE");
                    return;
                }
            }
            if (!checkEXP(exp))
            {
                MessageBox.Show("INVALID FORMAT EXP");
                return;
            }   
            if (!checkDateBegin(dateBegin))
            {
                MessageBox.Show("Invalid DateBegin");
                return;
            }
            if (!checkEID(eid))
            {
                MessageBox.Show("INVALID EID");
                return;
            }
            
            if (!EmployeeDAO.Instance.uniqueEID(eid,ssn))
            {
                MessageBox.Show("INVALID EID IN DATABASE");
                return;
            }
            Employee emp = new Employee(ssn,eid,dateBegin,exp,supperSSN);
            if (EmployeeDAO.Instance.updateEmp(emp))
            {
                MessageBox.Show("UPDATE SUCCESS!!!");
            }
            else
            {
                MessageBox.Show("SOME ERROR EXIST WHEN UPDATING");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ssn = SSN_EMP_TB.Text.Trim();
            if (ssn == "")
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show(string.Format("DO YOU WANT TO DELETE {0}",ssn), "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (EmployeeDAO.Instance.deleteEmp(ssn))
                {
                    MessageBox.Show("DELETE SUCCESS!!!");
                }
                else
                {
                    MessageBox.Show("SOME ERROR EXIST WHEN DELETING");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //updateDriver

            //driver
            string ssn = SSN_DRIVER_TB.Text.Trim();
            string lisence_id = LisenceID_DRIVER_TB.Text.Trim();
            byte exp = (byte)(exp_DRIVER_TB.Text.Trim()[0] - 48);

            //vehicle
            string vnum = Vnum_Driver_TB.Text.Trim();
            string rnum = RNUM_DRIVER_TB.Text.Trim();
            string type = TYPE_DRIVER_TB.Text.Trim();

            if (!checkEXP(exp))
            {
                MessageBox.Show("INVALID FORMAT EXP");
                return;
            }

            //09j2/14250
            if (!checkLisenceID(lisence_id))
            {
                MessageBox.Show("INVALID FORMAT LISENCE_ID");
                return;
            }
            
            if (!checkRNUM(rnum))
            {
                MessageBox.Show("INVALID FORMAT RNUM");
                return;
            }
            if (!checkTypeDriver(type))
            {
                MessageBox.Show("INVLAID TYPE VEHICLE");
                return;
            }

            Vehicle vehicle = new Vehicle(vnum, rnum, type);
            Driver driver = new Driver(ssn, lisence_id, exp);

            if (DriverDAO.Instance.updateDriverVehicle(driver,vehicle))
            {
                MessageBox.Show("UPDATE SUCCESS!!!");
            }
            else
            {
                MessageBox.Show("SOME ERROR MAY HAVE EXIST!!!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //DELETE BUTTON
            string ssn = SSN_DRIVER_TB.Text.Trim();
            string vnum = Vnum_Driver_TB.Text.Trim();
            DialogResult dialogResult1 = MessageBox.Show(string.Format("DO YOU WANT TO DELETE {0}", ssn), "Exit", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                if (DriverDAO.Instance.deleteDriver(ssn))
                {
                    MessageBox.Show("DELETE SUCCESS!!!");
                }
                else
                {
                    MessageBox.Show("SOME ERROR EXIST WHEN DELETING");
                }
            }
            DialogResult dialogResult2 = MessageBox.Show(string.Format("DO YOU WANT TO DELETE {0}", vnum), "Exit", MessageBoxButtons.YesNo);
            if (dialogResult2 == DialogResult.Yes)
            {
                if (VehicleDAO.Instance.deleteVehicle(vnum))
                {
                    MessageBox.Show("DELETE SUCCESS!!!");
                }
                else
                {
                    MessageBox.Show("SOME ERROR EXIST WHEN DELETING");
                }
            }
        }

        bool checkID(string id)
        {
            if (id.Length != 10)
            {
                return false;
            }
            Regex r = new Regex(@"^[0-9]{10}");
            var result = r.Match(id);
            return result.Success;
        }

        bool checkType(string type_msg)
        {
            List<String> types = new List<String> { "ADMIN", "CUSTOMER", "DRIVER", "EMPLOYEE" };
            foreach (string type in types)
            {
                if (type_msg == type)
                {
                    return true;
                }
            }
            return false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string ssn = SSN_ACCOUNT_TB.Text.Trim();
            string id = ID_ACCOUNT_TB.Text.Trim();
            string type = TYPE_ACCOUNT_TB.Text.Trim();

            if (!checkID(id))
            {
                MessageBox.Show("INVALID FORMAT ID");
                return;
            }
            if (!checkType(type))
            {
                MessageBox.Show("INVALID TYPE");
                return;
            }

            //check id giu nguyen
            string id_ = AccountDAO.Instance.getIDBySSN(ssn);
            if (id != id_)
            {
                if (AccountDAO.Instance.checkINDB(id))
                {
                    MessageBox.Show("ID HAS ALREADY EXIST");
                    return;
                }
            }

            if (AccountDAO.Instance.UpdateAccount(ssn,id,type))
            {
                MessageBox.Show("UPDATE SUCCESS!!!");
            }
            else
            {
                MessageBox.Show("ERROR IN UPDATE DATABASE");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string ssn = SSN_ACCOUNT_TB.Text.Trim();
            if (AccountDAO.Instance.deleteAccount(ssn))
            {
                MessageBox.Show("DELETE SUCCESS!!");
            }
            else
            {
                MessageBox.Show("ERROR IN PROCESSING!!");
            }
        }
    }
}
