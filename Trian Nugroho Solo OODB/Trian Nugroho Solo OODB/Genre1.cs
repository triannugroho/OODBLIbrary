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
    public partial class Genre1 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Genre1()
        {
            InitializeComponent();
        }

        private void Genre1_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            var display = (from x in dc.Genres
                           select x);
            dataGridView1.DataSource = display;

        }

        private void btnGCancel_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls) 
            {
                if(b.GetType() == typeof(TextBox))
                {
                    b.Text = "";
                }
            }
        }

        private void btnGInsert_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            string ide = txtGId.Text;
            string namee = txtGName.Text;

            genre.GenreId = txtGId.Text;
            genre.GenreName= txtGName.Text;

            var id = from x
                        in dc.Books
                     select x.GenreId;

            var name = from x
                      in dc.Genres
                       select x.GenreName;

            string chacnomor = (id.Count()).ToString();
            int far = int.Parse(chacnomor);
            string value = "BK" + (far + 1).ToString("000");
            
            if (txtGId.Text == "")
            {
                MessageBox.Show("Genre Name must be filled");
            }

            dc.Genres.InsertOnSubmit(genre);
            dc.SubmitChanges();

            displaydata();
        }
        }
    }
