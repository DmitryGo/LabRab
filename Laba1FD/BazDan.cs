using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Laba1FD
{   //Класс для осуществелния связи с бд, содержащий методы для работы с бд
    class BazDan
    {
        //Поля
        string CommandText = "Наш SQL скрипт";
        string Connect = "Database=labupp;Data Source=db4free.net;User Id=dmitrygo;Password=331150";
        //Переменная Connect - это строка подключения в которой:
        //БАЗА - Имя базы в MySQL
        //ХОСТ - Имя или IP-адрес сервера (если локально то можно и localhost)
        //ПОЛЬЗОВАТЕЛЬ - Имя пользователя MySQL
        //ПАРОЛЬ - говорит само за себя - пароль пользователя БД MySQL


            
        //конструктор
        public BazDan()
        {
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open(); //Устанавливаем соединение с базой данных.

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


        //тест
        public void exittBD()
        {

            //myConnection.Close();
        }

        }
}
