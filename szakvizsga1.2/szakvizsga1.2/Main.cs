using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace szakvizsga1._2
{
    public partial class Main : Form
    {
        private readonly Listener listener;

        public List<Socket> clients = new List<Socket>(); // store all the clients into a list
        public Main()
        {
            InitializeComponent();
        }
    }
}
