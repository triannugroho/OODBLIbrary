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
    public partial class Register : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Register()
        {
            InitializeComponent();
        }
        public Register(User user)
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            string name = txtRName.Text;
            string email = txtREmail.Text;
            string pass = txtRPassword.Text;
            string pass2 = txtRConfirmPassword.Text;
            string phone = txtRPhone.Text;
            string add = txtRAddress.Text;
            string gender = "";
            if (rbtMale.Checked)
            {
                gender = "Male";

            }
            else if (rbtFamele.Checked)
            {

                gender = "Female";
            }

            var id = (from x in dc.Users
                      select x.UserId).Count() + 1;

            user.UserId = "US" + id.ToString("000");
            user.Name = name;
            user.Email = email;
            user.Password = pass;
            user.Phone = phone;
            user.Address = add;
            user.Role = "User";
            user.Gender = gender;
            dc.Users.InsertOnSubmit(user);
            dc.SubmitChanges();

            string valid = validate();

            if (!(valid == ""))
            {
                MessageBox.Show(valid);
            }
            else
            {
                MessageBox.Show(valid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string validate()
        {
            User user = new User();
            string name = txtRName.Text;
            string email = txtREmail.Text;
            string pass = txtRPassword.Text;
            string pass2 = txtRConfirmPassword.Text;
            string phone = txtRPhone.Text;
            string add = txtRAddress.Text;
            

            long temp;


            if (name == "")
            {
                return "Name must be filled";
            }
            else if (email == "")
            {
                return "email must be filled";
            }
            else if (!(email.Length >= 5 && email.Length <= 30))
            {
                return "Email must be between 5 – 30 characters";
            }
            else if (!(email.Contains("@") && email.Contains(".")))
            {
                return "Email is not valid";
            }
            else if (email.StartsWith("@") || email.EndsWith("."))
            {
                return "Email is not valid";
            }
            //Email has been used
            else if (pass == "")
            {
                return "Password must be filled";
            }
            else if (pass.Length < 6 && pass.Length > 50)
            {
                return "Password must be between 6 – 50 characters";
            }
            //else if(char.IsDigit(string[i]))
            //{
            //    return "Password must contain at least 1 number";   
            //}
            else if (pass2 == "")
            {
                return "Confirm Password must be filled";
            }
            else if (!(pass2 == pass))
            {
                return "Password does not match";
            }
            else if (phone == "")
            {
                return "Phone Number must be filled";
            }
            else if (!(phone.Length >= 9 && phone.Length <= 12))
            {
                return "Password must be between 6 – 50 characters";
            }
            else if (!(Int64.TryParse(phone.Substring(1), out temp)))
            {
                return "Phone number must be constains only '+' and digits";
            }
            else if (rbtMale.Checked == false && rbtFamele.Checked == false)
            {
                return "Gender must be selected";
            }
            else if (add == "")
            {
                return "Address must be filled";
            }
            else if (!(add.Contains("street")))
            {
                return "Adress must be constains 'street'";
            }
            return "Successfully Register";
            this.Hide();
            new Menu().Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
