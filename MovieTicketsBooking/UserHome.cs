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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void btnUserViewmovie_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserViewMovies movie = new UserViewMovies();
            movie.ShowDialog();
        }

        private void btnUserEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEditProfile movie = new UserEditProfile();
            movie.ShowDialog();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage movie = new LoginPage();
            movie.ShowDialog();
        }
    }
}
