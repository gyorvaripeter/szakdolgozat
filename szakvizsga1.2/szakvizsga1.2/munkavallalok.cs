using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szakvizsga1._2
{
    public partial class munkavallalok : Form
    {
        public munkavallalok()
        {
            InitializeComponent();
        }

        private void munkavallalok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adatbazisDataSet3.Munkavallalok' table. You can move, or remove it, as needed.
            this.munkavallalokTableAdapter.Fill(this.adatbazisDataSet3.Munkavallalok);


        }
    }
}
