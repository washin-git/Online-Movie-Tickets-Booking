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
    public partial class AdminViewUsers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
        string cs = @"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataTable dt;
        public AdminViewUsers()
        {
            InitializeComponent();
        }

        private void txtAdminVUsername_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Login where username like '" + txtAdminVUsername.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewAdminVUser.DataSource = dt;
            conn.Close();
        }

        private void btnAdminUserCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome vu = new AdminHome();
            vu.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void AdminViewUsers_Load(object sender, EventArgs e)
        {
            
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(dt);
            dataGridViewAdminVUser.DataSource = dt;
            con.Close();
        }
    }
}
