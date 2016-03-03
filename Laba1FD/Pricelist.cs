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
    }
}
