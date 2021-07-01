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
    public partial class BookTickets : Form
    {
        public BookTickets()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtTik.Text == string.Empty || txtMT.Text == string.Empty || txtMST.Text == string.Empty || txtMN.Text == string.Empty || txtML.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                MessageBox.Show("All Fiealds are Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Theatre;Integrated Security=True");
                con.Open();
                String quary = "Insert INTO [Ticket] ([MovieName],[MovieType],[ShowTime],[Language],[NoOfTickets],[Total]) VALUES('" + txtMN.Text + "','" + txtMT.Text + "','" + txtMST.Text + "','" + txtML.Text + "','" + txtTik.Text + "','" + txtAmount.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(quary, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reserved Successfully Need to pay");

                txtTik.Text = "";
                txtMT.Text = "";
                txtMST.Text = "";
                txtMN.Text = "";
                txtML.Text = "";
                txtAmount.Text = "";
                this.Hide();
                Payment uv = new Payment();
                uv.ShowDialog();
            }
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserViewMovies uv = new UserViewMovies();
            uv.ShowDialog();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
        private double calculatRetail(double ticketPrice, double qty)
        {
            double total;  
            total = ticketPrice * qty;
            return total;
        }

        private void txtTik_TextChanged(object sender, EventArgs e)
        {
            double ticketPrice;
            double qty;

            if(double.TryParse(txtTik.Text, out qty) && double.TryParse(lblPrice.Text, out ticketPrice))
            {
                double total;
                total = calculatRetail(ticketPrice, qty);
                txtAmount.Text = total.ToString("");
            }
            //else
            
              // MessageBox.Show("Re-Enter");
           
        }
        
    }
}
