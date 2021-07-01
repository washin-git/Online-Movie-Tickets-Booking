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
    public partial class UserEditProfile : Form
    {
        public UserEditProfile()
        {
            InitializeComponent();
        }

        private void btnUserEditsave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty )
            {
                MessageBox.Show("All Fiealds are Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
                con.Open();
                String quary = "Insert INTO [Login] ([username],[password]) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(quary, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Chaneged Successfully!!!");

                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            

        }

        private void btnUserEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome movie = new UserHome();
            movie.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
