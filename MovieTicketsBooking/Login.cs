using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketsBooking
{
    public partial class LoginPage : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLoginok_Click(object sender, EventArgs e)
        {
            if (txtLoginPass.Text != string.Empty || txtLoginUname.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Login where username='" + txtLoginUname.Text + "' and password='" + txtLoginPass.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    UserHome userhome = new UserHome();
                    userhome.ShowDialog();
                }
                else if(txtLoginUname.Text == "Admin" || txtLoginPass.Text == "Admin")
                {
                    dr.Close();
                    this.Hide();
                    AdminHome login = new AdminHome();
                    login.ShowDialog();

                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
            cn.Open();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void txtLoginUname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
