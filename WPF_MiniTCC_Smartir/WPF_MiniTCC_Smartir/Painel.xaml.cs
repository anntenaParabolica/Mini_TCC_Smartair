using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_MiniTCC_Smartir.Classes;
using static WPF_MiniTCC_Smartir.Painel;

namespace WPF_MiniTCC_Smartir
{
    /// <summary>
    /// Lógica interna para Painel.xaml
    /// </summary>
    public partial class Painel : Window
    {

        public Painel()
        {
            InitializeComponent();
            CarregarLaboratorios();
        }

        public void CarregarLaboratorios()
        {
            var laboratorios = BuscarLaboratorios();
            LaboratoriosList.ItemsSource = laboratorios;
        }// Inicia e carrega a busca dos laboratorios cadastrados quando a pagina carregar

        // Classes List dos Labs e Esps Cadastrados
        public class Laboratorio
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Localizacao { get; set; }
            public List<ESP> Esps { get; set; }
        }
        public class ESP
        {
            public int Id { get; set; }
            public int LaboratorioId { get; set; }
            public string Estado { get; set; }
        }


        private void icnAddUser_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //vai para a pagina para adicionar admin
        {
            adicionaradmin adicionaradmin = new adicionaradmin();
            adicionaradmin.Show();
            this.Close();
        }

        private void icnAddLab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) // vai p/ pagina de adicionar lab
        {
            adicionarlab adicionarlab = new adicionarlab();
            adicionarlab.Show();
            this.Close();
        }

        private void icnAddEsp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            adicionaresp adicionaresp = new adicionaresp();
            adicionaresp.Show();
            this.Close();
        }// vai p/ pagina de  adicionar esp

        public List<Laboratorio> BuscarLaboratorios()
        {
            var laboratorios = new List<Laboratorio>();

            using (MySqlConnection connection = connectionfactory.GetConnection())
            {
                string query = @"SELECT l.ID_Lab, l.Nome, l.Localizacao, l.Descricao, e.ID_ESP32, e.Endereço_IP, e.Estado 
                         FROM Lab l 
                         LEFT JOIN ESP32 e ON l.ID_Lab = e.ID_Lab";

                MySqlCommand command = new MySqlCommand(query, connection);

                // Executa a consulta e lê os resultados
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verifica se o laboratório já foi adicionado à lista
                        var laboratorioExistente = laboratorios.FirstOrDefault(l => l.Id == reader.GetInt32("ID_Lab"));

                        if (laboratorioExistente == null)
                        {
                            // Se o laboratório ainda não existe na lista, adiciona-o
                            var laboratorio = new Laboratorio
                            {
                                Id = reader.GetInt32("ID_Lab"),
                                Nome = reader.GetString("Nome"),
                                Localizacao = reader.GetString("Localizacao"),
                                Esps = new List<ESP>()
                            };

                            if (!reader.IsDBNull(reader.GetOrdinal("ID_ESP32")))
                            {
                                // Adiciona o ESP se estiver disponível
                                laboratorio.Esps.Add(new ESP
                                {
                                    Id = reader.GetInt32("ID_ESP32"),
                                    Estado = reader.GetString("Estado")
                                });
                            }

                            laboratorios.Add(laboratorio);
                        }
                        else
                        {
                            // Se o laboratório já está na lista, apenas adiciona o ESP
                            if (!reader.IsDBNull(reader.GetOrdinal("ID_ESP32")))
                            {
                                laboratorioExistente.Esps.Add(new ESP
                                {
                                    Id = reader.GetInt32("ID_ESP32"),
                                    Estado = reader.GetString("Estado")
                                });
                            }
                        }
                    }
                }

                connection.Close();
            }

            return laboratorios;
        }// Função P/ Buscar os Laboratórios Cadastrados

        private void LaboratoriosList_SelectionChanged(object sender, SelectionChangedEventArgs e) // Função p/ mostrar o Menu Control com as informações do lab/esp
        {
            // Verifica se um item foi selecionado
            if (LaboratoriosList.SelectedItem != null)
            {
                // Obtém o laboratório selecionado
                var laboratorioSelecionado = (Laboratorio)LaboratoriosList.SelectedItem;

                // Atualiza o conteúdo das Labels com os valores do laboratório selecionado
                lblTitulo.Content = laboratorioSelecionado.Nome;
                lblIdEsp.Content = laboratorioSelecionado.Esps.Count > 0 ? laboratorioSelecionado.Esps[0].Id.ToString() : "Sem ESP";
                lblStatusEsp.Content = laboratorioSelecionado.Esps.Count > 0 ? laboratorioSelecionado.Esps[0].Estado : "Indefinido";
                lblTempLab.Content = "Temperatura: " + "36°C"; // exemplo parado

                // Exibe o grid (define Visibility como Visible)
                grdMenuControl.Visibility = Visibility.Visible;
            }
        }
    }

 

}
