using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        String Sid, Eid;
        int Salary1, Adays, Leves, PdSalary, Gtax, Gpay;

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public Salary()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string delete = "Delete From Salary where Salary_ID = '" + Sid + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string update = "update Salary set Emp_ID ='" + Eid + "',Salary ='" + Salary1 + "' , Absent_Days ='" + Adays + "' ,Leves ='" + Leves + "' ,Per_Day_Salary ='" + PdSalary + "',Gov_Tax_Rate ='" + Gtax + "' ,Gross_Pay ='" + Gpay +"' where  Salary_ID ='" + Sid + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void txtSalary_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string search = "select * from Salary Where Salary_ID = '" + Sid + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtSalary_ID.Text = read["Salary_ID"].ToString();
                    txtEmp_ID.Text = read["Emp_ID"].ToString();
                    txtSalary.Text = read["Salary"].ToString();
                    txtAbsent_Days.Text = read["Absent_Days"].ToString();
                    txtLeves.Text = read["Leves"].ToString();
                    txtPer_Day_Salary.Text = read["Per_Day_Salary"].ToString();
                    txtGov_Tax_Rate.Text = read["Gov_Tax_Rate"].ToString();
                    txtGross_Pay.Text = read["Gross_Pay"].ToString();
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

        private void txtGov_Tax_Rate_TextChanged(object sender, EventArgs e)
        {
            Loaddata();
            Gpay = (Salary1 + ((30 - Adays) + Leves) * PdSalary) - (Salary1 + ((30 - Adays) + Leves) * PdSalary)*Gtax/100;
            txtGross_Pay.Text = Gpay.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string insert = "insert into Salary values ('" + Sid + "','" + Eid + "','" + Salary1 + "','" + Adays + "','" + Leves + "','" + PdSalary + "','" + Gtax + "','" + Gpay + "')";
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

        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_ToysDataSet3.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.grifindo_ToysDataSet3.Salary);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Pannel admin_Pannel = new Admin_Pannel();
            this.Close();
            admin_Pannel.Show();
        }

        private void Clear()
        {
            txtSalary_ID.Clear();
            txtEmp_ID.Clear();
            txtSalary.Clear();
            txtAbsent_Days.Clear();
            txtLeves.Clear();
            txtPer_Day_Salary.Clear();
            txtGov_Tax_Rate.Clear();
            txtGross_Pay.Clear();
            txtSalary_ID.Focus();
        }

        private void Loaddata()
        {
            Sid = txtSalary_ID.Text;
            Eid = txtEmp_ID.Text;

            Int32.TryParse(txtSalary.Text, out Salary1);
            Int32.TryParse(txtAbsent_Days.Text, out Adays);
            Int32.TryParse(txtLeves.Text, out Leves);
            Int32.TryParse(txtPer_Day_Salary.Text, out PdSalary);
            Int32.TryParse(txtGov_Tax_Rate.Text, out Gtax);
            Int32.TryParse(txtGross_Pay.Text, out Gpay);
        }

        private void Loadgridview()
        {
            con.Open();
            string data = "select * from Salary";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvSalary_Details.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
