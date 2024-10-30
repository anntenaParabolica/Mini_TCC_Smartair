using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_MiniTCC_Smartir
{
    /// <summary>
    /// Lógica interna para adicionarlab.xaml
    /// </summary>
    public partial class adicionarlab : Window
    {
        public adicionarlab()
        {
            InitializeComponent();
        }

        //função limpar campos
        public void limpar()
        {
            txtid.Clear();
            txtnome.Clear();
            txtlocalizacao.Clear();
            txtdescricao.Clear();
        }

        //Botão para voltar ao painel
        private void VoltarBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Painel painel = new Painel();
            painel.Show();
            this.Close();
        }

        //Botão de cadastrar
        private void btncadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtid.Text != "" && txtlocalizacao.Text != "" && txtnome.Text != "")
            {
                Lab cadastrolab = new Lab(Convert.ToInt32(txtid.Text), txtnome.Text, txtlocalizacao.Text, txtdescricao.Text);
                Esp32DAO.cadastrolab(cadastrolab);
                CustomMessageBox.Show("Novo laboratório cadastrado com sucesso!", "Aviso: Cadastro Concluído");
                limpar();
            }

            else
            {
                CustomMessageBox.Show("As credenciais não podem estar vazias!", "Erro: Credenciais Inválidas");
                limpar();
                txtid.Focus();
            }
        }

        private void IdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir apenas letras
            e.Handled = !Regex.IsMatch(e.Text, @"^\d{0,3}$");
        }




    }
}
