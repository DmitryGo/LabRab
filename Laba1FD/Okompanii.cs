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
    //Класс о компании
    public partial class Okompanii : Form
    {
        BazDan bd = new BazDan();//объект класса БД

        string kontakt;//Переменная в которой записано из БД информациия контактов
        string infokomp;//Переменная в которой записано из БД информациия о компании
        string uradres;//Переменная в которой записано из БД юридический адрес компании
        string infport;//Переменная в которой записано из БД информациия о партнерах

        //Конструктор
        public Okompanii()
        {
            InitializeComponent();
        }


        //Метод возвращающий пользователя к главной форме
        private void btBack_Click(object sender, EventArgs e)
        {

        }

        
    }
}
