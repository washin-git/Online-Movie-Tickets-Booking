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
    public partial class AdminView_Movie : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
        string cs = @"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataTable dt;
        public AdminView_Movie()
        {
            InitializeComponent();
        }

        private void btnAdminCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome payment = new AdminHome();
            payment.ShowDialog();
        }

        private void AdminView_Movie_Load(object sender, EventArgs e)
        {

        }

        private void txtAdminViewMName_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where MovieName like '" + txtAdminViewMName.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewAdminViewMovie.DataSource = dt;
            conn.Close();
        }

        private void dateTimePickerShow_ValueChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where ShowTime like '" + dateTimePickerShow.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewAdminViewMovie.DataSource = dt;
            conn.Close();
        }

        private void txtAdminViewLang_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where Language like '" + txtAdminViewLang.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewAdminViewMovie.DataSource = dt;
            conn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            display_data();
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Movie";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter dataadap = new SqlDataAdapter(cmd);
            dataadap.Fill(dt);
            dataGridViewAdminViewMovie.DataSource = dt;
            con.Close();
        }
    }
}
