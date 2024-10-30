using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class EspDAO
    {
        //função para cadastrar lab
        public static void cadastroesp(Esp32 cadastroesp)
        {
            //abre a conexão
            using (MySqlConnection connection = connectionfactory.GetConnection())
            {
                //comando insert para o banco de dados
                string insert = "INSERT INTO ESP32 (ID_ESP32, Endereço_IP, Estado) Values (@ID_ESP32, @Endereço_IP, @Estado)";

                //criação do comando insert
                MySqlCommand commandindert = new MySqlCommand(insert, connection);

                commandindert.Parameters.AddWithValue("@ID_ESP32", cadastroesp.Idesp32);
                commandindert.Parameters.AddWithValue("@Endereço_IP", cadastroesp.Ip);
                commandindert.Parameters.AddWithValue("@Estado", cadastroesp.Estado);

                //execução do comando
                commandindert.ExecuteNonQuery();

                
            }
        }
    }
}
