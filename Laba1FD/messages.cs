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
     //класс чата
    public partial class messages : Form
    {
        //конструктор
        public messages()
        {
            InitializeComponent();
        }
        //Метод отправки сообщения
        private void btSend_Click(object sender, EventArgs e)
        {

        }
        //Метод для выхода из чата
        private void btBack_Click(object sender, EventArgs e)
        {

        }

        private void messages_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
