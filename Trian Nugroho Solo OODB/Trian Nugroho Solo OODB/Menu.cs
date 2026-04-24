using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trian_Nugroho_Solo_OODB
{
    public partial class Menu : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        ChangePassword cp = new ChangePassword();
        public Menu()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().Show();
            //if (cp == null || cp.IsDisposed)
            //{
            //    cp = new ChangePassword();
            //    cp.MdiParent = this;
            //    cp.Show();
            //}
 
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Master_Book().Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Genre1().Show(); 
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Master_User().Show();
        }

        private void buyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Buy_Book().Show();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Transaction().Show();
        }
    }
}
