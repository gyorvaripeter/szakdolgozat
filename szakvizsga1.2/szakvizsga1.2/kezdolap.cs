using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace szakvizsga1._2
{
    public partial class kezdolap : Form
    {
        
       
        public kezdolap()
        {
            InitializeComponent();
           

        }
        //EASTER EGG------------------------
   
        //---------------------------------

        private void Product_image_Click(object sender, EventArgs e)
        {
            termekek termekek = new termekek();
            termekek.Show();
            this.Hide();
        }

        private void Employee_image_Click(object sender, EventArgs e)
        {
            munkavallalok munkavallalok = new munkavallalok();
            munkavallalok.Show();
        }

        private void kezdolap_Load(object sender, EventArgs e)
        {
            label5.Text = ("Bejelentkezve mint: "+ Form2.belepesinev);
            label5.TextAlign = ContentAlignment.MiddleCenter;
           // label7.Text = Form2.belepesinev;
            label8.Text = Form2.Role;
            if(label8.Text=="User" || label8.Text=="Guest")
            {
                Employee_image.Enabled = false;
                Employee_image.Visible = false;
                label2.Text = "";
                Product_image.Location = new Point(384, 106);
                label3.Location = new Point(420,299);
                    
            }


         
    }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult kijelent;
            kijelent = MessageBox.Show("Biztosan Kijelentkezik?", "Bezárás", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kijelent == DialogResult.OK)
            {
                Form2 bejelentkezes = new Form2();
                bejelentkezes.Show();
                this.Hide();
            }
        }

        private void kezdolap_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 33)
            {
                eastereggs ea = new eastereggs();
                ea.Show();

            }
            if(e.KeyChar==9 )
            {
                easteregg2 ea2 = new _2.easteregg2();
                ea2.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            eladasok elad = new _2.eladasok();
            elad.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vasarlok vasarlok = new vasarlok();
            vasarlok.Show();
        }
    }


}
