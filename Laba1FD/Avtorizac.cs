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
    //класс авторизации
    public partial class Avtorizac : Form
    {
        string name;//имя 
        string pass;//пароль
        
        BazDan bd = new BazDan();//объект класса БД

        //конструктор
        public Avtorizac()
        {
            
            InitializeComponent();
        }
        //метод входа
        private void btVhod_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "1")
            {
                Razrabotchik razrabotchic = new Razrabotchik();
                razrabotchic.Show();
                this.Close(); 
            }
            else if (tbName.Text == "0")
            {
                Klient klient = new Klient();
                klient.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите имя и пароль");
            }
        }
        //метод регистрации нового пользователя
        private void btReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зарегестрирован");
        }
        //метода возврата на главную форму
        private void btBack_Click(object sender, EventArgs e)
        {
            Glavstr glavstr = new Glavstr();
            glavstr.Visible = true;
            this.Hide();
            
        }

        private void Avtorizac_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
