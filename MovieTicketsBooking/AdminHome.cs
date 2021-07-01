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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnAddmovie_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddMovies movies = new AdminAddMovies();
            movies.ShowDialog();
        }

        private void btnAdminViewMovies_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView_Movie adminhome = new AdminView_Movie();
            adminhome.ShowDialog();
        }

        private void btnAdminViewUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewUsers adminhome = new AdminViewUsers();
            adminhome.ShowDialog();
        }

        private void btnAdminhomeCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage adminhome = new LoginPage();
            adminhome.ShowDialog();
        }
    }
}
