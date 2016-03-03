using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1FD
{
    public partial class TehZad : Form
    {
        public TehZad()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TehZad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.Show();
            this.Hide();
        }
    }
}
