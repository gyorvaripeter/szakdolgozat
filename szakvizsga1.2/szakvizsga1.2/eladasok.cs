using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace szakvizsga1._2
{
    public partial class eladasok : Form
    {
        OleDbConnection kapcsolat = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Adatbazis.accdb");
        OleDbCommand parancs;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();
        //---------------------------------------------------
        public static int egysegar;
        public static int mennyiseg;
        public static int osszeg;
        //************************************************
        public eladasok()
        {
            InitializeComponent();
            
            //---------------------------------------------------------
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Term_ID";
            dataGridView1.Columns[0].CellTemplate.ValueType = typeof(int);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Termék";
            string NRFormat = "###0 db";
            dataGridView1.Columns[2].Name = "Mennyiség";
            dataGridView1.Columns[2].DefaultCellStyle.Format = NRFormat;
            dataGridView1.Columns[3].Name = "Egységár";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "c";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[1].Width = 260;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            //--------------------------------------------------------
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].Name = "Eladás_ID";
            dataGridView2.Columns[0].CellTemplate.ValueType = typeof(int);
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Name = "Termék";
            string NRFormat2 = "###0 db";
            dataGridView2.Columns[2].Name = "Mennyiség";
            dataGridView2.Columns[2].DefaultCellStyle.Format = NRFormat2;
            dataGridView2.Columns[3].Name = "Dátum";
           // dataGridView2.Columns[3].DefaultCellStyle.Format = "d";
            dataGridView2.Columns[4].Name = "Munkavállaló";
            dataGridView2.Columns[5].Name = "Vásárló";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dataGridView2.Columns[1].Width = 260;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.Visible = false;
           
        }

        private void retrieve()
        {
            dataGridView1.Rows.Clear();

            //sql stmt
            string sql = "SELECT Term_ID,Termek,Mennyiseg,Egysegar FROM Termekek";
            parancs = new OleDbCommand(sql, kapcsolat);

            try
            {
                
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);
                adapter.Fill(dt);


                //Loop THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    FELTOLTES((int)row[0], row[1].ToString(), (int)row[2], (int)row[3]);
                }
                kapcsolat.Close();
                dt.Rows.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }
        }
        private void retrieve2()
        {
            dataGridView2.Rows.Clear();

            //sql stmt
            string sql = "SELECT Eladasok.Eladas_ID, Termekek.Termek, Eladas_adatok.Mennyiseg, Eladasok.eladas_datum, Munkavallalok.Munkavallalok, Vasarlok.Vasarlo_neve FROM Vasarlok,Eladasok,Munkavallalok,Eladas_adatok,Termekek WHERE Munkavallalok.Azonosító = Eladasok.Munkv_ID AND Eladasok.Munkv_ID = Vasarlok.Vasarlo_ID AND Eladasok.Eladas_ID = Eladas_adatok.Eladas_ID AND Eladas_adatok.Termek_ID = Termekek.Term_ID;";
            parancs = new OleDbCommand(sql, kapcsolat);

            try
            {
                dt = new DataTable();
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);
                adapter.Fill(dt);


                //Loop THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    FELTOLTES2((int)row[0], row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
                kapcsolat.Close();
                dt.Rows.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }
        }
    
        // adatok feltöltése
        private void FELTOLTES(int id, string product, int amount, int price)
        {

            dataGridView1.Rows.Add(id, product, amount, price);

        }
        private void FELTOLTES2(int elad_id, string product, int amount, string date ,string munk_name,string vasarlo_name)
        {

            dataGridView2.Rows.Add(elad_id, product, amount,date,munk_name,vasarlo_name);

        }
        private void eladasok_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
            retrieve();
            retrieve2();

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
          //  listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void t_Tick(object Sender,EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(id2);
            
            //textBox1.Text = id.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().ToUpper();
            dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim('d', 'b');
            string egysegars = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim('F','t');

            egysegar = Convert.ToInt32(egysegars);
            textBox3.Text = egysegars;
            textBox2.Text = "1";
            if (textBox2.Text == "")
            {
                price.Text = "0";
            }
            else
            {
                mennyiseg = Convert.ToInt32(textBox2.Text);
                osszeg = mennyiseg * egysegar;
                price.Text = osszeg.ToString();
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if ( textBox2.Text=="")
            {
                price.Text = "0";
            }
            else
            {
                mennyiseg = Convert.ToInt32(textBox2.Text);
                osszeg = mennyiseg * egysegar;
                price.Text = osszeg.ToString();
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Csak számot írhat be!");
            }
        }

        private void összesEladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
        }

        private void újTermékEladásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        //select * where username="form2.Role"...
    }
}
