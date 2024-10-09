using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Programming
{
    public partial class Login : Form
    {
        string Username , Password ;
        public Login()
        {
            InitializeComponent();
        }
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            loaddata();
            if (Username != "Admin" && Password != "1234")
            {
                MessageBox.Show("Your username or password is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else if (Username == "Admin" && Password != "1234")
            {
                MessageBox.Show("Your password is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else if (Username != "Admin" && Password == "1234")
            {
                MessageBox.Show("Your username is incorrect", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                MessageBox.Show("Login Success!", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_Pannel admin = new Admin_Pannel();
                this.Hide();
                admin.Show();
            }
        }
        private void loaddata()
        {
            Username = txtUN.Text;
            Password = txtPW.Text;
        }
        private void clear()
        {
            txtUN.Clear();
            txtPW.Clear();
            txtUN.Focus();
        }
    }
}
