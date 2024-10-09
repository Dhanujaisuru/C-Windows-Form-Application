using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class Setting : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8I464NC;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        String Seid, Eid, Dscycle, No_of_Leves;
        DateTime Scbdate, Scedate;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDscycle.Text == "30")
            {
                try
                {
                    con.Open();
                    Loaddata();
                    string insert = "insert into Setting values ('" + Seid + "','" + Eid + "','" + Dscycle + "','" + Scbdate + "','" + Scedate + "','" + No_of_Leves + "')";
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
            else
            {
                MessageBox.Show("Error While inserting");
            }
       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDscycle.Text == "30")
            {
                try
                {
                    con.Open();
                    Loaddata();
                    string update = "update Setting set Emp_ID ='" + Eid + "',Dates_for_Salary_cycle ='" + Dscycle + "' , Salary_cycle_begin_Date  ='" + Scbdate + "' ,Salary_cycle_end_Date ='" + Scedate + "' ,NO_of_leaves_for_Year ='" + No_of_Leves + "' where  Setting_ID ='" + Seid + "'";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Setting Update successfully", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Error While Updating");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string delete = "Delete From Setting where Setting_ID = '" + Seid + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Setting delete Successfully", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public Setting()
        {
            InitializeComponent();
        }

        private void txtSetting_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string search = "select * from Setting Where Setting_ID = '" + Seid + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    txtSetting_ID.Text = read["Setting_ID"].ToString();
                    txtEmp_ID.Text = read["Emp_ID"].ToString();
                    txtDscycle.Text = read["Dates_for_Salary_cycle"].ToString();
                    dtpSalary_Sart_Day.Text = read["Salary_cycle_begin_Date"].ToString();
                    dtpSalary_End_Date.Text = read["Salary_cycle_end_Date"].ToString();
                    txtNo_of_Leves.Text = read["No_of_leaves_for_Year"].ToString();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Pannel admin_Pannel = new Admin_Pannel();
            this.Close();
            admin_Pannel.Show();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_ToysDataSet4.Setting' table. You can move, or remove it, as needed.
            this.settingTableAdapter.Fill(this.grifindo_ToysDataSet4.Setting);

        }

        private void Loaddata()
        {
            Seid = txtSetting_ID.Text;
            Eid = txtEmp_ID.Text;
            Dscycle = txtDscycle.Text;
            Scbdate = dtpSalary_Sart_Day.Value.Date;
            Scedate = dtpSalary_End_Date.Value.Date;
            No_of_Leves = txtNo_of_Leves.Text;
        }

        private void Loadgridview()
        {
            con.Open();
            string data = "select * from Setting";
            SqlDataAdapter adpt = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dgvSetting_Details.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void Clear()
        {
            txtSetting_ID.Clear();
            txtEmp_ID.Clear();
            txtDscycle.Clear();
            dtpSalary_Sart_Day.ResetText();
            dtpSalary_End_Date.ResetText();
            txtNo_of_Leves.Clear();
            txtSetting_ID.Focus();
        }

    }
}
