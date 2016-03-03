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
    //Класс для отображения списка заказов
    public partial class SpisZak : Form
    {
        //Конструктор
        public SpisZak()
        {
            InitializeComponent();
        }
        //Метод для закрытия формы
        private void SpisZak_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Кнопка назад
        private void bt1_Click(object sender, EventArgs e)
        {
            Razrabotchik razrabotckik = new Razrabotchik();
            razrabotckik.Show();
            this.Hide();
        }
    }
}
