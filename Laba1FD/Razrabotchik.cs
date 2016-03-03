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
{//класс форма для разработчика
    public partial class Razrabotchik : Form
    {
        //конструктор
        public Razrabotchik()
        {
            InitializeComponent();
        }

        //метод перехода на форму с заказами
        private void btSpisZak_Click(object sender, EventArgs e)
        {
            SpisZak spiszak = new SpisZak();
            spiszak.Show();
            this.Hide();
        }
        //метод для общения клиента и разработчика
        private void btSvKlient_Click(object sender, EventArgs e)
        {

        }
        //метод открытия формы редактирования прайс-листа
        private void btKorPrice_Click(object sender, EventArgs e)
        {

        }
        //метод выовзращающий к форме авторизации
        private void btBack_Click(object sender, EventArgs e)
        {
            Avtorizac avtorizac = new Avtorizac();
            avtorizac.Show();
            this.Hide();
        }

        private void Razrabotchik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
