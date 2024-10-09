using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class Admin_Pannel : Form
    {
        public Admin_Pannel()
        {
            InitializeComponent();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Close();
            employee.Show();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            this.Close();
            salary.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            this.Close();
            setting.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
