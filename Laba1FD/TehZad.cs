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
    //Класс для технического задания
    public partial class TehZad : Form
    {
        //Конструктор
        public TehZad()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Метод для закрытия формы
        private void TehZad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Кнопка назад
        private void bt2_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.Show();
            this.Hide();
        }
    }
}
