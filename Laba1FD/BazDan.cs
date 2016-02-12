using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1FD
{   //Класс для осуществелния связи с бд, содержащий методы для работы с бд
    class BazDan
    {
        //Поля
            
        //конструктор
        public BazDan()
        {

        }

        //Метод добавления элемента в бд
        public void AddBD() { }

        //Метод удаления элемента из бд
        public void DellBD() { }

        //Метод редактирования элемента в бд
        public void RefreshBD() { }

        //Метод вывода прайс-листа из бд
        public string ShowPrice() { return "0"; }

        //Метод вывода адреса из бд
        public string ShowUrAdress() { return "0"; }

        //Метод вывода о компании из бд
        public string ShowOKompanii() { return "0"; }

        //Метод вывода информации о партнерах из бд
        public string ShowPartner() { return "0"; }

        //Метод вывода информации о контактах из бд
        public string ShowKontakt() { return "0"; }

        //Метод добавления нового заказчика
        public string AddZakaz() { return "0"; }

        //Метод проверки наличия введеного логина и пароля в бд
        public string ProverkaBD() { return "0"; }

        //Метод для отправки сообщения
        public string OtpravSoobsh() { return "0"; }

        //Метод для получения сообщения
        public string PoluchSoobsh() { return "0"; }


    }
}
