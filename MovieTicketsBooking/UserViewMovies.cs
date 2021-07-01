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
    public partial class UserViewMovies : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
        string cs = @"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataTable dt;
        public UserViewMovies()
        {
            InitializeComponent();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome movie = new UserHome();
            movie.ShowDialog();
        }

        private void UserViewMovies_Load(object sender, EventArgs e)
        {

        }

        private void txtUserViewMName_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where MovieName like '" + txtUserViewMName.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewUserViewMovie.DataSource = dt;
            conn.Close();
        }

        private void dateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where ShowTime like '" + dateTimePickerTime.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewUserViewMovie.DataSource = dt;
            conn.Close();
        }

        private void txtUserViewLang_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Movie where Language like '" + txtUserViewLang.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewUserViewMovie.DataSource = dt;
            conn.Close();
        }

        private void dataGridViewUserViewMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookTickets bt = new BookTickets();
            bt.txtMN.Text = this.dataGridViewUserViewMovie.CurrentRow.Cells[0].Value.ToString();
            bt.txtMT.Text = this.dataGridViewUserViewMovie.CurrentRow.Cells[1].Value.ToString();
            bt.txtMST.Text = this.dataGridViewUserViewMovie.CurrentRow.Cells[2].Value.ToString();
            bt.txtML.Text = this.dataGridViewUserViewMovie.CurrentRow.Cells[3].Value.ToString();
            bt.ShowDialog();
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
            dataGridViewUserViewMovie.DataSource = dt;
            con.Close();
        }
    }
}
