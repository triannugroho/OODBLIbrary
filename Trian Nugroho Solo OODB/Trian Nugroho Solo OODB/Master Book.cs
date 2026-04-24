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
    public partial class Master_Book : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Master_Book()
        {
            InitializeComponent();
        }

        private void Master_Book_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            var display = (from x in dc.Users
                           select x);
            dataGridView1.DataSource = display;

        }

        private void btnMBInsert_Click(object sender, EventArgs e)
        {
            Book student = new Book();
            string genre = cmbMBGenre.Text;
            var stock = updownMBStock.Text;
            var price = txtMBPrice.Text;

            student.BookName = txtMBName.Text;
            student.GenreId = cmbMBGenre.SelectedValue.ToString();
            student.Stock = Int32.Parse(stock);
            student.Price = Int32.Parse(price);
            

            var id = from x
                        in dc.Books
                        select x.BookId;

            var genr = from x
                      in dc.Genres
                       select x.GenreId;

                      string chacnomor = (id.Count()).ToString();
            int far = int.Parse(chacnomor);
            string value = "BK" + (far +1).ToString("000");
            int temp;
            if (txtMBName.Text == "")
            {
                MessageBox.Show("Book Name must be filled");
            }
            else if (cmbMBGenre.Text == "--Genre must be choosen")
            {
                MessageBox.Show("Genre must be choosen");
            }
            else if (txtMBPrice.Text == "")
            {
                MessageBox.Show("Book Price must be filled");
            }
            else if(!(Int32.TryParse(txtMBPrice.Text, out temp)))
            {
                MessageBox.Show("Book Price must be numeric");
            }

            dc.Books.InsertOnSubmit(student);
            dc.SubmitChanges();

            displaydata();
            
        }

        private void btnMBCancel_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls) 
            {
                if(b.GetType() == typeof(TextBox))
                {
                    b.Text = "";
                }
            }
        }

        private void btnMBSave_Click(object sender, EventArgs e)
        {
            Book student = new Book();
            string genre = cmbMBGenre.Text;
            var stock = updownMBStock.Text;
            var price = txtMBPrice.Text;

            student.BookName = txtMBName.Text;
            student.GenreId = cmbMBGenre.SelectedValue.ToString();
            student.Stock = Int32.Parse(stock);
            student.Price = Int32.Parse(price);


            var id = from x
                        in dc.Books
                     select x.BookId;

            var genr = from x
                      in dc.Genres
                       select x.GenreId;

            string chacnomor = (id.Count()).ToString();
            int far = int.Parse(chacnomor);
            string value = "BK" + (far + 1).ToString("000");


            dc.Books.InsertOnSubmit(student);
            dc.SubmitChanges();

            displaydata();
        }
    }
}
