using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanVeXemPhim
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();

            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            frmAddStaffs1.Hide();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaffs1.Show();
            dashboard1.Hide();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            addMovieForm1.Show();
            frmAddStaffs1.Hide();
        }
    }
}
