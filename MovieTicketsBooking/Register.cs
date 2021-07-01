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
    public partial class Register : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
            cn.Open();
        }

        private void btnRegsave_Click(object sender, EventArgs e)
        {
            if (txtCPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtUname.Text != string.Empty)
            {
                if (txtPassword.Text == txtCPassword.Text)
                {
                    cmd = new SqlCommand("select * from Login where username='" + txtUname.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Login values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtUname.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginPage login = new LoginPage();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage cancel = new LoginPage();
            cancel.ShowDialog();
        }
    }
}
