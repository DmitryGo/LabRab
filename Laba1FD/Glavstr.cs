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
    //Класс главное страницы ПС
    public partial class Glavstr : Form
    {
        
        //Конструктор
        public Glavstr()
        {
            InitializeComponent();
            
        }

        //Метод для перехода на форму авторизации
        private void btAvtor_Click(object sender, EventArgs e)
        {
            Avtorizac avtorizac = new Avtorizac();
            avtorizac.Show();
            this.Visible = false;



        }
        //Метод для перехода на форму о компании
        private void btOkomp_Click(object sender, EventArgs e)
        {
            Okompanii okompanii = new Okompanii();
            okompanii.Show();
            this.Visible = false;

        }

        private void Glavstr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
