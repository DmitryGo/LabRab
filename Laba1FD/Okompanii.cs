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


        //Конструктор
        public Okompanii()
        {
            InitializeComponent();
            lbUrAd.Text = bd.ShowUrAdress();
            lbIOP.Text = bd.ShowPartner();
            lbKon.Text = bd.ShowKontakt();
            lbIOD.Text = bd.ShowOKompanii();
        }


        //Метод возвращающий пользователя к главной форме
        private void btBack_Click(object sender, EventArgs e)
        {
            Glavstr glavstr = new Glavstr();
            glavstr.Visible = true;
            this.Hide();

        }

        private void Okompanii_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Okompanii_Load(object sender, EventArgs e)
        {

        }
    }
}
