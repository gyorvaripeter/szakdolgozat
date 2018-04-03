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
    public partial class vasarlok : MetroFramework.Forms.MetroForm
    {
        public vasarlok()
        {
            InitializeComponent();
        }

        private void vasarlok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adatbazisDataSet.Vasarlok' table. You can move, or remove it, as needed.
            this.vasarlokTableAdapter.Fill(this.adatbazisDataSet.Vasarlok);
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.dataGridView1.Refresh();
        }
    }
}
