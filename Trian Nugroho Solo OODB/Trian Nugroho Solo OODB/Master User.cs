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

    public partial class Master_User : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Master_User()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Master_User_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            var display = (from x in dc.Users
                           select x);
            dataGridView1.DataSource = display;

        }

        private void btnMUCancel_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls) 
            {
                if(b.GetType() == typeof(TextBox))
                {
                    b.Text = "";
                }
            }
        }
        }
    }

