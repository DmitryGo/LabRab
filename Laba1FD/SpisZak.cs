﻿using System;
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
    public partial class SpisZak : Form
    {
        public SpisZak()
        {
            InitializeComponent();
        }

        private void SpisZak_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Razrabotchik razrabotckik = new Razrabotchik();
            razrabotckik.Show();
            this.Hide();
        }
    }
}
