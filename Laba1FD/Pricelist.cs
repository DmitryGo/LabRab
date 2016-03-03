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
{   //Класс прайс-листа
    public partial class Pricelist : Form
    {
           //Конструктор
        public Pricelist()
        {
            InitializeComponent();
        }
        //Метод для закрытия формы
        private void Pricelist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Текстбокс для вывода прайс-листа
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Кнопка назад
        private void bt1_Click(object sender, EventArgs e)
        {

        }
    }
}
