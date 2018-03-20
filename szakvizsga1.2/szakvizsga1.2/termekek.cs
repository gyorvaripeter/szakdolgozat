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
using DGVPrinterHelper;
using Zen.Barcode;
using System.IO;
using szakvizsga1._2.Properties;

namespace szakvizsga1._2
{
    public partial class termekek : Form
    {
        OleDbConnection kapcsolat = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Adatbazis.accdb");
        OleDbCommand parancs;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        public termekek()
        {
            InitializeComponent();
            //---------------Datagridview formázás
            dgvform();

        }

        //--------------------------------------------------------------
        private void dgvform()
        {
            
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Term_ID";
            dataGridView1.Columns[0].CellTemplate.ValueType = typeof(int);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Termek";
            dataGridView1.Columns[2].Name = "Kategoria";
            dataGridView1.Columns[3].Name = "Leiras";
            dataGridView1.Columns[4].Name = "Mennyiseg";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string NRFormat = "###0 db";
            dataGridView1.Columns[4].DefaultCellStyle.Format = NRFormat;
            dataGridView1.Columns[5].Name = "Egysegar";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 80;
            
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //sql stmt
            string sql = "SELECT * FROM Termekek";
            parancs = new OleDbCommand(sql, kapcsolat);
            string combo = "SELECT Kategoria FROM Termekek group by Kategoria";
            OleDbCommand parancs3 = new OleDbCommand(combo, kapcsolat);
            kapcsolat.Open();
            OleDbDataReader reader = parancs3.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Kategoria"]);
            }


            kapcsolat.Close();
            try
            {
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);
                adapter.Fill(dt);
                //------------------------------------------
               
                //Loop THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    FELTOLTES((int)row[0], row[1].ToString(), row[3].ToString(), row[2].ToString(), (int)row[4], (int)row[5]);
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
        private void FELTOLTES(int id, string product, string category, string description, int amount, int price)
        {

            dataGridView1.Rows.Add(id, product, category, description, amount, price);

        }


        private void termekek_Load(object sender, EventArgs e)
        {
            
            retrieve();
            textBox2.Text.ToUpper();
            
           
            //-----------------------------------------------------
            
        }

        //-------------------------------------------------------------

        private void add(string product, string category, string description, int amount, int price, byte [] photo)
        {
            string sql = "INSERT INTO Termekek(Termek, Kategoria, Leiras, Mennyiseg, Egysegar,Termek_kep) VALUES(@pro,@cat,@desc,@amo,@uni,@pic)";
            parancs = new OleDbCommand(sql, kapcsolat);

            //
            //parancs.Parameters.AddWithValue("@ID", id);
            parancs.Parameters.AddWithValue("@pro", product);
            parancs.Parameters.AddWithValue("@cat", category);
            parancs.Parameters.AddWithValue("@desc", description);
            parancs.Parameters.AddWithValue("@amo", amount);
            parancs.Parameters.AddWithValue("@uni", price);
            parancs.Parameters.AddWithValue("@pic", savephoto());

            //--------------kapcsolat megnyitás
            try
            {
                kapcsolat.Open();
                if (parancs.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Sikeres hozzáadás");
                }

                retrieve();
                kapcsolat.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }

        }


        //------------------------------------------------------------------
        private byte [] savephoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox7.Image.Save(ms, pictureBox7.Image.RawFormat);
            return ms.GetBuffer();
        }
        private Image LoadPhoto(byte []photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        private void update(string product, string category, string description, int amount, int price, int id)
        {
            
            //SQL STMT             
            string sql = "UPDATE Termekek SET Termekek.Termek = '" + product + "',  Termekek.Kategoria = '" + category + "', Termekek.Leiras = '" + description + "', Termekek.Mennyiseg = '" + amount + "', Termekek.Egysegar = '" + price + "' WHERE Termekek.Term_ID = " + id + ";";
            parancs = new OleDbCommand(sql, kapcsolat);

            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);

                adapter.UpdateCommand = kapcsolat.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Sikeresen Frissítve!");
                }

                kapcsolat.Close();

                //REFRESH
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }

        }
        private void delete(int id)
        {
            //SQL STMT
            string sql = "DELETE FROM Termekek WHERE Term_ID=" + id;
            parancs = new OleDbCommand(sql, kapcsolat);

            //'OPEN CON,EXECUTE DELETE,CLOSE CON
            try
            {
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);

                adapter.DeleteCommand = kapcsolat.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("Biztosan törlöd az adatot?", "TÖRLÉS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (parancs.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sikeresen Törölted!");
                    }
                }

                kapcsolat.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                kapcsolat.Close();
            }
        }

        private void clearTxts()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

    

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            string id2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(id2);
            textBox1.Text = id.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().ToUpper();
            comboBox1.Text=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim('d', 'b');
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim('F', 't');
            //pictureBox7.Image = LoadPhoto((byte[]))

            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;

            barcode.Image = qrcode.Draw(textBox2.Text, 30);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = 0;
            index = dataGridView1.CurrentCell.RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[index].Cells["Term_ID"].Value);
            ID = Convert.ToInt32(textBox1.Text);

            string termekek = Convert.ToString(dataGridView1.Rows[index].Cells["Termek"].Value);
            termekek = textBox2.Text.ToUpper();

            string kategoria = Convert.ToString(dataGridView1.Rows[index].Cells["Kategoria"].Value);
            comboBox1.Text = kategoria;

            string leiras = Convert.ToString(dataGridView1.Rows[index].Cells["Leiras"].Value);
            textBox4.Text = leiras;

            int mennyiseg = Convert.ToInt32(dataGridView1.Rows[index].Cells["Mennyiseg"].Value);
            textBox5.Text = mennyiseg.ToString().Trim('d', 'b');

            int egysegar = Convert.ToInt32(dataGridView1.Rows[index].Cells["Egysegar"].Value);
            textBox6.Text = egysegar.ToString().Trim('F', 't');
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            add(textBox2.Text, comboBox1.SelectedItem.ToString() , textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text),savephoto());
            retrieve();
        }

        private void eltavolit_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            delete(id);
            clearTxts();
            retrieve();
        }

        private void szerkeszt_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            int id = Convert.ToInt32(selected);

            update(textBox2.Text, comboBox1.SelectedItem.ToString(), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), id);
            retrieve();
        }

        private void frissit_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kezdolap kezdolap = new kezdolap();
            kezdolap.Show();
            this.Hide();
        }
        //---------------------------NYOMTATÁS---------------------------
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowDialog();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Termék összesítő";
            printer.SubTitle = string.Format("Dátum: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Záródolgozat2018@Győrvári Péter\n Nyomtatta: " + Form2.belepesinev;
            printer.FooterSpacing = 15;
            printer.PrintDialogSettings.ShowNetwork.ToString();
            printer.PrintDataGridView(dataGridView1);
        }
        //**************************************************************


        //---------------------------KERESÉS-----------------------------
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dgvform();
            string osszes = "SELECT * FROM Termekek WHERE Termek like '%" + textBox7.Text + "%';";
            parancs = new OleDbCommand(osszes, kapcsolat);

            try
            {
                kapcsolat.Open();
                adapter = new OleDbDataAdapter(parancs);
                adapter.Fill(dt);


                //Loop THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    FELTOLTES((int)row[0], row[1].ToString(), row[3].ToString(), row[2].ToString(), (int)row[4], (int)row[5]);
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

        //************************************************************



        //-----------------------TÁLCÁRA HELYEZÉS-----------------------
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }
        //*************************************************************
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-------------------Darab növelés-----------------------------
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[4].Value = (int)dataGridView1.SelectedRows[0].Cells[4].Value + 1;
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim('d', 'b');
        }
        //************************************************************

        //-------------------Darab csökkentés-----------------------------
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[4].Value = (int)dataGridView1.SelectedRows[0].Cells[4].Value - 1;
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim('d', 'b');
        }
        //***************************************************************

        //--------------------------Mennyiség -csak szám- --------------------------
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Csak számot írhat be!");
            }
        }
        //*******************************************************************

        //--------------------------Ár -csak szám- --------------------------
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Csak számot írhat be!");
            }
        }
        //*******************************************************************
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.CharacterCasing = CharacterCasing.Upper;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.CharacterCasing = CharacterCasing.Upper;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "PNG File (*.png)|*.png|JPG File (*.jpg)|*.jpg|BMP File (*.bmp)|*.bmp|GIF File (*.gif)|*.gif"
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
