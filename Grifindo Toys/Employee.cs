using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        String Eid, Fn, Ln, Eaddress, Emobile, Gender;
        int Msalary, Orate, Ohours, Allowances, Salary;
        private void txtEmp_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string search = "select * from Employee Where Emp_ID = '" + Eid + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtEmp_ID.Text = read["Emp_ID"].ToString();
                    txtF_Name.Text = read["F_Name"].ToString();
                    txtL_Name.Text = read["L_Name"].ToString();
                    txtAddress.Text = read["Emp_Address"].ToString();
                    txtMobile.Text = read["Emp_Mobile"].ToString();

                    if (read["Gender"].ToString() == "Male")
                    {
                        rdbMale.Checked = true;
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                    }

                    txtMonthly_Salary.Text = read["Monthly_Salary"].ToString();
                    txtOT_Rate.Text = read["OT_Rate"].ToString();
                    txtOT_Hours.Text = read["OT_Hours"].ToString();
                    txtAllowances.Text = read["Allowances"].ToString();
                    txtSalary.Text = read["Salary"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Search" + ex);
            }
            finally
            {
                con.Close();

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtAllowances_TextChanged(object sender, EventArgs e)
        {
            Loaddata();
            Salary = Msalary + (Orate * Ohours) + Allowances;
            txtSalary.Text = Salary.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string update = "update Employee set F_Name ='" + Fn + "',L_Name ='" + Ln + "' , Emp_Address ='" + Eaddress + "' ,Emp_mobile ='" + Emobile + "' ,Gender ='" + Gender + "',Monthly_Salary ='" + Msalary + "',OT_Rate ='" + Orate + "' ,OT_Hours ='" + Ohours + "', Allowances ='" + Allowances + "',Salary ='" + Salary + "' where  Emp_ID ='" + Eid + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Clear();
                Loadgridview();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string insert = "insert into Employee values ('" + Eid + "','" + Fn + "','" + Ln + "','" + Eaddress + "','" + Emobile + "','" + Gender + "','" + Msalary + "','" + Orate + "','" + Ohours + "','" + Allowances + "','" + Salary + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Loadgridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While inserting" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Pannel admin_Pannel = new Admin_Pannel();
            this.Close();
            admin_Pannel.Show();
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_ToysDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.grifindo_ToysDataSet2.Employee);
        }
        public Employee()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string delete = "Delete From Employee where Emp_ID = '" + Eid + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Clear();
                Loadgridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While deleting" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void Loaddata()
        {
            Eid = txtEmp_ID.Text;
            Fn = txtF_Name.Text;
            Ln = txtL_Name.Text;
            Eaddress = txtAddress.Text;
            Emobile = txtMobile.Text;

            if (rdbMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            /*Msalary = int.Parse(txtMonthly_Salary.Text);
            Orate = int.Parse(txtOT_Rate.Text);
            Ohours = int.Parse(txtOT_Hours.Text);
            Allowances = int.Parse(txtAllowances.Text);
            Salary = int.Parse(txtSalary.Text);*/

            Int32.TryParse(txtMonthly_Salary.Text, out Msalary);
            Int32.TryParse(txtOT_Rate.Text, out Orate);
            Int32.TryParse(txtOT_Hours.Text, out Ohours);
            Int32.TryParse(txtAllowances.Text, out Allowances);
            Int32.TryParse(txtSalary.Text, out Salary);
        }
        private void Loadgridview()
        {
            con.Open();
            string data = "select * from Employee";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvEmployee_Details.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
        private void Clear()
        {
            txtEmp_ID.Clear();
            txtF_Name.Clear();
            txtL_Name.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtMonthly_Salary.Clear();
            txtOT_Rate.Clear();
            txtOT_Hours.Clear();
            txtAllowances.Clear();
            txtSalary.Clear();
            txtEmp_ID.Focus();
        }
    }

}
