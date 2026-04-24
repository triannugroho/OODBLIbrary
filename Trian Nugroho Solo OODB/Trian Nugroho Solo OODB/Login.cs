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
    public partial class Login : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLEmail.Text;
            string pass = txtLPassword.Text;

            var id = (from x in dc.Users
                      where x.Email == email &&
                      x.Password == pass
                      select x).FirstOrDefault();

            if (email == "")
            {
                MessageBox.Show("Email must be filled!");
            }
            else if (pass == "")
            {
                MessageBox.Show("Password must be filled!");
            }
            //You are not registered as a member
            else if (id == null)
            {
                MessageBox.Show("User not registered");
            }
            else
            {
                MessageBox.Show("You are register as member");
                this.Hide();
                new Menu().Show();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}
