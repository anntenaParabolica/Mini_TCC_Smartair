using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class Esp32DAO
    {
        //função para cadastrar lab
        public static void cadastrolab(Lab cadastrolab)
        {
            //abre a conexão
            using (MySqlConnection connection = connectionfactory.GetConnection())
            {
                //comando insert para o banco de dados
                string insert = "INSERT INTO Lab Values (@ID_Lab, @Nome, @Localizacao, @Descricao)";

                //criação do comando insert
                MySqlCommand commandindert = new MySqlCommand(insert, connection);

                commandindert.Parameters.AddWithValue("@ID_Lab", cadastrolab.Idlab);
                commandindert.Parameters.AddWithValue("@Nome", cadastrolab.Nome);
                commandindert.Parameters.AddWithValue("@Localizacao", cadastrolab.Localizacao);
                commandindert.Parameters.AddWithValue("@Descricao", cadastrolab.Descricao);

                //execução do comando
                commandindert.ExecuteNonQuery();

                //fim da conexão
                connection.Close();
            }
        }
    }
}
