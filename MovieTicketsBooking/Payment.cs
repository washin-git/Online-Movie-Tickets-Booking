using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketsBooking
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void txtCardName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            txtCardNumber.GotFocus += new EventHandler(this.TextGotFocus);
            txtCardNumber.LostFocus += new EventHandler(this.TextLostFocus);
            txtCVN.GotFocus += new EventHandler(this.TextGotFocus);
            txtCVN.LostFocus += new EventHandler(this.TextLostFocus);
            txtYYYY.GotFocus += new EventHandler(this.TextGotFocus);
            txtMM.LostFocus += new EventHandler(this.TextLostFocus);
            txtMM.GotFocus += new EventHandler(this.TextGotFocus);
            txtYYYY.LostFocus += new EventHandler(this.TextLostFocus);
        }

        public void TextGotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "0000 0000 0000 0000")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            else if(tb.Text == "MM")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            else if (tb.Text == "YYYY")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            else if (tb.Text == "XXX")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        public void TextLostFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            
            if (tb.Text == "")
            {
                tb.Text = "0000 0000 0000 0000";
                tb.ForeColor = Color.LightGray;
            }
            else if(tb.Text == "")
            {
                tb.Text = "MM";
                tb.ForeColor = Color.LightGray;
            }
            else if (tb.Text == "")
            {
                tb.Text = "YYYY";
                tb.ForeColor = Color.LightGray;
            }
            else if (tb.Text == "")
            {
                tb.Text = "XXX";
                tb.ForeColor = Color.LightGray;
            }
        }

        private void btnPayCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome payment = new UserHome();
            payment.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == string.Empty || txtCVN.Text == string.Empty || txtMM.Text == string.Empty || txtYYYY.Text == string.Empty)
            {
                MessageBox.Show("All Fiealds are Required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Succsessfully Tickets Booked");
                this.Hide();
                UserHome movie = new UserHome();
                movie.ShowDialog(); 
                
            }
            
        }

        private void radioButtonmaster_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
