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
    public partial class AdminAddMovies : Form
    {
        public AdminAddMovies()
        {
            InitializeComponent();
        }

        private void btnAdminSave_Click(object sender, EventArgs e)
        {
            if (txtAdminAddLanguage.Text == string.Empty || txtAdminAddMName.Text == string.Empty || txtAdminAddMType.Text == string.Empty || dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("All Fiealds are Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
                con.Open();
                String quary = "Insert INTO [Movie] ([MovieName],[MovieType],[ShowTime],[Language]) VALUES('" + txtAdminAddMName.Text + "','" + txtAdminAddMType.Text + "','" + dateTimePicker1.Text + "','" + txtAdminAddLanguage.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(quary, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Successfully!!!");

                txtAdminAddMName.Text = "";
                txtAdminAddMType.Text = "";
                dateTimePicker1.Text = "";
                txtAdminAddLanguage.Text = "";
                
            }
           

        }

        private void btnAdminMovieCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome movie = new AdminHome();
            movie.ShowDialog();
        }

        private void btnAdminEditMovie_Click(object sender, EventArgs e)
        {
            if (txtAdminAddLanguage.Text == string.Empty || txtAdminAddMName.Text == string.Empty || txtAdminAddMType.Text == string.Empty || dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("All Fiealds are Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Movie] set MovieType = '" + txtAdminAddMType.Text + "',ShowTime = '" + dateTimePicker1.Text + "',Language = '" + txtAdminAddLanguage.Text + "'where [MovieName] ='" + txtAdminAddMName.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Update Successfully!");
                txtAdminAddMName.Text = "";
                txtAdminAddMType.Text = "";
                dateTimePicker1.Text = "";
                txtAdminAddLanguage.Text = "";
            }
        }

        private void btnAdminnAddMDelete_Click(object sender, EventArgs e)
        {
            if (txtAdminAddMName.Text == string.Empty)
            {
                MessageBox.Show("Movie name is Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
                con.Open();
                String quary = "DELETE FROM  [Movie] where MovieName ='" + txtAdminAddMName.Text + "' ";
                SqlCommand command = new SqlCommand(quary, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Sucessfully");
                txtAdminAddMName.Text = "";
                txtAdminAddMType.Text = "";
                dateTimePicker1.Text = "";
                txtAdminAddLanguage.Text = "";
            }
        }

        private void AdminAddMovies_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAdminAddMType_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminAddLanguage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdminAddMName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
