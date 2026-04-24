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
    public partial class View_Transaction : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public View_Transaction()
        {
            InitializeComponent();
        }

        private void View_Transaction_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            var display = (from x in dc.Header_Transcations
                           select x);
            dataGridView1.DataSource = display;

        }
    }
}
