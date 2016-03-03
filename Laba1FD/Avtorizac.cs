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

        }
        //метод регистрации нового пользователя
        private void btReg_Click(object sender, EventArgs e)
        {

        }
        //метода возврата на главную форму
        private void btBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
