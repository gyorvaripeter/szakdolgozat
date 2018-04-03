﻿using System;
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
        public static int osszes;
        public static int id;
        public static int[] termekek = new int[100];
        public static int termid = 0;
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
            dataGridView2.ColumnCount = 7;
            dataGridView2.Columns[0].Name = "Eladás_ID";
            dataGridView2.Columns[0].CellTemplate.ValueType = typeof(int);
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Name = "Termék";
            string NRFormat2 = "###0 db";
            dataGridView2.Columns[2].Name = "Mennyiség";
            dataGridView2.Columns[2].DefaultCellStyle.Format = NRFormat2;
            dataGridView2.Columns[3].Name = "Összeg";
            dataGridView2.Columns[4].Name = "Dátum";
            // dataGridView2.Columns[3].DefaultCellStyle.Format = "d";
            dataGridView2.Columns[5].Name = "Munkavállaló";
            dataGridView2.Columns[6].Name = "Vásárló";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dataGridView2.Columns[1].Width = 260;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.Visible = false;
            listView1.FullRowSelect = true;
           
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
            string sql = "SELECT Eladasok.Eladas_ID, Termekek.Termek, Eladas_adatok.Mennyiseg,[Eladas_adatok.Mennyiseg]*[Termekek.Egysegar],Eladasok.eladas_datum, Munkavallalok.Munkavallalok, Vasarlok.Vasarlo_neve FROM Vasarlok,Eladasok,Munkavallalok,Eladas_adatok,Termekek WHERE Munkavallalok.Azonosító = Eladasok.Munkv_ID AND Eladasok.Munkv_ID = Vasarlok.Vasarlo_ID AND Eladasok.Eladas_ID = Eladas_adatok.Eladas_ID AND Eladas_adatok.Termek_ID = Termekek.Term_ID;";
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
                    FELTOLTES2((int)row[0], row[1].ToString(), (int)row[2], (int)row[3], row[4].ToString(), row[5].ToString(), row[6].ToString());
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
        private void FELTOLTES2(int elad_id, string product,int quantity, int amount, string date ,string munk_name,string vasarlo_name)
        {

            dataGridView2.Rows.Add(elad_id, product,quantity, amount,date,munk_name,vasarlo_name);

        }
        //-------------------------------------------------------------------------------------------
        private void add(int elad_id, int termid, int amount)
        {
            string sql = "INSERT INTO Eladas_adatok(Termek_ID, Mennyiseg) VALUES(@termid,@amo);"; 
                string sql2 = "INSERT INTO Eladas(Eladas_ID) VALUES (@eladid);";
            parancs = new OleDbCommand(sql, kapcsolat);
            OleDbCommand parancs2 = new OleDbCommand(sql2, kapcsolat);

            //
            //parancs.Parameters.AddWithValue("@ID", id);
            parancs.Parameters.AddWithValue("@eladid", elad_id);
            parancs.Parameters.AddWithValue("@termid", termid);
            parancs.Parameters.AddWithValue("@amo", amount);


            //--------------kapcsolat megnyitás
            try
            {
                kapcsolat.Open();
                if (parancs.ExecuteNonQuery() > 0 && parancs2.ExecuteNonQuery() > 0)
                {
                    //clearTxts();
                    MessageBox.Show("Sikeres hozzáadás");
                }

                retrieve2();
                kapcsolat.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }

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
            columnHeader2.TextAlign = HorizontalAlignment.Center;
           

        }

        public void t_Tick(object Sender,EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id = Convert.ToInt32(id2);
            
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

            //------------------Lista feltöltés------------------------
            string[] row = { textBox1.Text, textBox2.Text, price.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
           
            //-------------------checkBoxes-----------------------------
            listViewItem.Checked = true;

            osszes = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                osszes += int.Parse(listView1.Items[i].SubItems[2].Text);
                osszesen.Text = osszes.ToString();
            }
            //---------------------------------------------------------

            
            string termekidje = "SELECT Term_ID FROM Termekek WHERE Termek LIKE'"+textBox1.Text+"'";
            OleDbCommand parancs3 = new OleDbCommand(termekidje, kapcsolat);
            kapcsolat.Open();
            OleDbDataReader reader2 = parancs3.ExecuteReader();
            while (reader2.Read())
            {
                termid = int.Parse((reader2["Term_ID"].ToString()));
            }
            reader2.Close();
            kapcsolat.Close();
            
            for (int i = termekek.Last(); i < termekek.Length; i++)
            {
                termekek[i] = termid;
            }
           
            //string sql = "DELETE";
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
            listView1.Visible = false;
            dataGridView1.Visible = false;
        }

        private void újTermékEladásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            listView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eladid = 0;
            string eladasidje = "SELECT TOP 1 Eladasok.Eladas_ID FROM Eladasok ORDER BY Eladasok.Eladas_ID DESC;";
            
            OleDbCommand parancs2 = new OleDbCommand(eladasidje, kapcsolat);
            kapcsolat.Open();
            OleDbDataReader reader = parancs2.ExecuteReader();

            while (reader.Read())
            {
               eladid=int.Parse((reader["Eladas_ID"].ToString()));
            }
            reader.Close();

          
            kapcsolat.Close();
            

            add(eladid+1,termid, Convert.ToInt32(textBox2.Text));
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            //ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
           
                for (int i =0;  i < listView1.Items.Count-1; i++)
            {
                if (e.CurrentValue == CheckState.Checked)
                  {
                    osszes = osszes - Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    listView1.Items[i].Remove();
                    osszesen.Text = osszes.ToString();
                    i++;
                  }
            }
            
        }

        //select * where username="form2.Role"...
    }
}
