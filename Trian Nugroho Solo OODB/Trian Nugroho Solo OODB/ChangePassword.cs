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
    public partial class ChangePassword : Form
    {
        ChangePassword passnew2;
        private User cUser;
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(User user)
        {
            InitializeComponent();
            cUser = user;
        }

        private void btnCPChangePassword_Click(object sender, EventArgs e)
        {
            User user = new User();
            string pass = txtCPPassword.Text;
            string passnew = txtCPNewPassword.Text;
            string passcon = txtCPConfirmPassword.Text;

            var pes = (from x in dc.Users
                       where x.Password == txtCPPassword.Text
                       select x).FirstOrDefault();


            if (pass == "")
            {
                MessageBox.Show("Password must be filled");
            }
            else if (pes == null) 
            {
                MessageBox.Show("Incorrect Password");
            }
            else if (passcon == "")
            {
                MessageBox.Show("Confirm password must be filled");
            }
            else if (passnew == "")
            {
                MessageBox.Show("password must be filled");
            }
            else if (passcon == "")
            {
                MessageBox.Show("confirm password must be filled ");
            }
            else if (passcon != passnew)
            {
                MessageBox.Show("password does not match ");
            }
            else if (passnew == pass)
            {
                MessageBox.Show("New Password can’t be the same as your previous password");
            }
            else
            {
                MessageBox.Show("Your Password has been changed");
            }
            dc.Users.InsertOnSubmit(user);
            dc.SubmitChanges();
            this.Hide();
            new Menu().Show();
        }
    }
}