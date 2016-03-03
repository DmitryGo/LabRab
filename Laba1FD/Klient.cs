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
    //Класс вкотором реализовано форма для заказчика
    public partial class Klient : Form
    {
        //конструктор
        public Klient()
        {
            InitializeComponent();
        }
        //Метод для перехода на форму создания БД
        private void btTZ_Click(object sender, EventArgs e)
        {

        }
        //метод для перехода на форму прайс листа
        private void btPrice_Click(object sender, EventArgs e)
        {

        }
        //метод обеспечивающий общение заказчика и разработчика
        private void btSviz_Click(object sender, EventArgs e)
        {

        }
        //возврат к форме авторизации
        private void btBack_Click(object sender, EventArgs e)
        {
            Avtorizac avtorizac = new Avtorizac();
            avtorizac.Show();
            this.Close();
        }

        private void Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
