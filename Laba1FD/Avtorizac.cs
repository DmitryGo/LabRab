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
            string name = tbName.Text;
            string pass = tbPas.Text;
            if (name != "" && pass != "")
            {
                string nameprov = bd.ProverkaAdmin(name, pass);
                string nameprov2 = bd.ProverkaKlient(name, pass);
                if (nameprov==name)
                {
                    Razrabotchik razrabotchic = new Razrabotchik();
                    razrabotchic.Show();
                    this.Hide();
                }
                else if(nameprov2==name)
                {
                    Klient klient = new Klient();
                    klient.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователя не существует или не верный пароль");
                }
            }
            else
            {
                MessageBox.Show("Введите имя и пароль");
            }
            
        }
        //метод регистрации нового пользователя
        private void btReg_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPas.Text;
            if (name != "" && pass != "")
            {
                string nameprov = bd.ProverkaBD(name);
                if (nameprov != name)
                {
                    bd.RegistrNewPol(name, pass);
                    MessageBox.Show("Зарегестрирован");
                }
                else
                {
                    MessageBox.Show("Данный пользователь уже зарегестрирован");
                }
            }
            else
            {
                MessageBox.Show("Введите имя и пароль");
            }
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
