using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using Server;
using System.Diagnostics;


namespace szakvizsga1._2
{
    public partial class easteregg2 : Form
    {
        public ClientSettings Client { get; set; }
        public easteregg2()
        {
            Client = new ClientSettings();
            InitializeComponent();
        }

        private void easteregg2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            
            Process.Start("Client.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start("Server.exe");
        }
    }
}
