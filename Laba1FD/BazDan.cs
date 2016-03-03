using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Laba1FD
{   //Класс для осуществелния связи с бд, содержащий методы для работы с бд
    class BazDan
    {
        string zapros;
        string str;
        string Connect = "server=www.db4free.net;port=3306;database=labupp;user=dmitrygo;password=331150;";

        public BazDan()
        {
        

        }
        public string ConnectBD(string zapros)
        {
            
            string CommandText = zapros;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            try {
                myConnection.Open();
            }
            catch
            {
                return "Ошибка соединения!";
            }
                MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
                object result = myCommand.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                } 
            else return "Таблица пуста!";
            }
        

        //Метод добавления элемента в бд
        public void AddBD() {
            
            ConnectBD(zapros);

        }

        //Метод удаления элемента из бд
        public void DellBD() { }

        //Метод редактирования элемента в бд
        public void RefreshBD() { }

        //Метод вывода прайс-листа из бд
        public string ShowPrice() { return "0"; }

        //Метод вывода адреса из бд
        public string ShowUrAdress() {
            string zapros = "SELECT Opisanie FROM informokompan WHERE name = 'Юридический адрес' ";
            string s = ConnectBD(zapros);
            return s;
        }

        //Метод вывода о компании из бд
        public string ShowOKompanii()
        {
            string zapros = "SELECT Opisanie FROM informokompan WHERE name = 'О компании' ";
            string s = ConnectBD(zapros);
            return s;
        }

        //Метод вывода информации о партнерах из бд
        public string ShowPartner()
        {
            string zapros = "SELECT Opisanie FROM informokompan WHERE name = 'О партнерах' ";
            string s = ConnectBD(zapros);
            return s;
        }

        //Метод вывода информации о контактах из бд
        public string ShowKontakt()
        {
            string zapros = "SELECT Opisanie FROM informokompan WHERE name = 'Контакты' ";
            string s = ConnectBD(zapros);
            return s;
        }

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
            
        }

        }
}
