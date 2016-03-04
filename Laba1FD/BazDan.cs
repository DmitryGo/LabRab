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
        //Коннект для возврата из бд
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

            

        //Коннект для добавления
        public void ConnectBDInsert(string zapros)
        {

            string CommandText = zapros;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
            
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



        //Метод для отправки сообщения
        public string OtpravSoobsh()
        {
            return "0";
        }

        //Метод для получения сообщения
        public string PoluchSoobsh() { return "0"; }

        //Метод проверки наличия введеного логина в бд
        public string ProverkaBD(string name)
        {
            string zapros = "SELECT name FROM users WHERE name = '" + name + "' ";
            string s = ConnectBD(zapros);
            return s;
        }

        //Метод проверки наличия прав администратора
        public string ProverkaAdmin(string name, string pass)
        {
            string zapros = "SELECT name FROM users WHERE prav = '1',name='"+name+"','pass='"+pass+"'";
            string s = ConnectBD(zapros);
            return s;
        }
        //Метод проверки наличия прав клиента
        public string ProverkaKlient(string name, string pass)
        {
            string zapros = "SELECT name FROM users WHERE prav = '0',name='" + name + "','pass='" + pass + "'";
            string s = ConnectBD(zapros);
            return s;
        }

        public void RegistrNewPol(string name, string pass)
        {
                zapros = "INSERT INTO users (id,prav,name,pass) VALUES (NULL,'0','" + name + "','" + pass + "')";
                ConnectBDInsert(zapros);
        }

        //тест
        public void exittBD()
        {
            
        }

        }
}
