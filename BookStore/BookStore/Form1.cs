using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Manage manage = new Manage();
            manage.Owner = this;
            manage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Client client = new Client();
            client.Owner = this;
            client.Show();
        }
    }
}
