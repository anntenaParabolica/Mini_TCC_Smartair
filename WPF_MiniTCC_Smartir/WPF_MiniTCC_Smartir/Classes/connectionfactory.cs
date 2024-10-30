using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class connectionfactory
    {
        // classe para abrir conexão com o banco de dados
        private static string connectionBD = "Database=SmartAir;Server=localhost;Uid=root;Pwd=minicraft;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionBD);
            connection.Open();
            return connection;
        }
    }
}
