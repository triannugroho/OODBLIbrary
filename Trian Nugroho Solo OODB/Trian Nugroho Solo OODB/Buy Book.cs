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
    public partial class Buy_Book : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Buy_Book()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            displaydata2();
        }

        private void displaydata()
        {
            var display = (from x in dc.Books
                               select x);
            dataGridView1.DataSource = display;
    
        }

        private void displaydata2()
        {
            var id = (from x in dc.Header_Transcations
                      select x.TransactionId);
            string label = label3.Text;
        }

        private void btnBAddtoCart_Click(object sender, EventArgs e)
        {
            long temp;
            string qty = btnBAddtoCart.Text;
            Book book = new Book();
            int t = Int32.Parse(btnBAddtoCart.Text);

            int quantity = book.Stock;

            if (qty == "") 
            {
                MessageBox.Show("Quantity must be filled");
            }
            else if(!Int64.TryParse(qty.Substring(0), out temp))
            {
                MessageBox.Show("Quantity must be a number");
            }
            else if(t  > quantity )
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                MessageBox.Show("Succes");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Book_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBDeleteFrom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
