using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class ContaDAO
    {
        //função para cadastrar contas admin
        public static void admincadastro(Conta admincadastrando)
        {
            //abre a conexão
            using (MySqlConnection connection = connectionfactory.GetConnection())
            {
                //comando insert para o banco de dados
                string insert = "INSERT INTO Usuario Values (@Idusuario, @Nome, @Email, @Senha)";

                //criação do comando insert
                MySqlCommand commandindert = new MySqlCommand(insert, connection);

                commandindert.Parameters.AddWithValue("@Idusuario", admincadastrando.Idusuario);
                commandindert.Parameters.AddWithValue("@Nome", admincadastrando.Nome);
                commandindert.Parameters.AddWithValue("@Email", admincadastrando.Email);
                commandindert.Parameters.AddWithValue("@Senha", admincadastrando.Senha);

                //execução do comando
                commandindert.ExecuteNonQuery();

                //fim da conexão
                connection.Close();
            }
        }


        public static bool adminlogar(Conta adminlogando)
        {
            MySqlConnection connection = connectionfactory.GetConnection();
            string query = "SELECT * FROM Usuario WHERE ID_Usuario = @Idusuario AND Senha = @senha";
            MySqlCommand busca = new MySqlCommand(query, connection);

            busca.Parameters.AddWithValue("@Idusuario", adminlogando.Idusuario);
            busca.Parameters.AddWithValue("@senha" , adminlogando.Senha);

            MySqlDataReader reader = busca.ExecuteReader();

            if(reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }
    }
}
