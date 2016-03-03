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
        String zapros;

        public BazDan()
        {
        

        }
        public void ConnectBD(String zapros)
        {
            string Connect = "Server=127.0.0.1;Port=3306;Database=labupp;User Id=dmitrygo;Password=331150";

            string CommandText = zapros;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            try
            {
                myConnection.Open();
            }
            catch
            {
                
            }
        }



        //Метод добавления элемента в бд
        public void AddBD() {
            String zapros = "INSERT INTO ";
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
            String zapros = "SELECT  ";
            ConnectBD(zapros);
            return "0";
        }

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
