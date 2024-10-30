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
    /// Lógica interna para adicionaradmin.xaml
    /// </summary>
    public partial class adicionaradmin : Window
    {
        public adicionaradmin()
        {
            InitializeComponent();
        }

        //função limpar campos
        public void limpar()
        {
            txtidcadastrar.Clear();
            txtnomecadastrar.Clear();
            txtemailcadastrar.Clear();
            pswsenha.Clear();
        }

        //Logando na conta


        //voltar ao painel
        private void VoltarBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Painel painel = new Painel();
            painel.Show();
            this.Close();
        }
        //Cadastrar admin
        private void btncadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtemailcadastrar.Text != "" && txtidcadastrar.Text != "" && txtnomecadastrar.Text != "" && pswsenha.Password != "")
            {
                Conta admincadastro = new Conta(Convert.ToInt32(txtidcadastrar.Text), txtnomecadastrar.Text,
                txtemailcadastrar.Text, pswsenha.Password);
                ContaDAO.admincadastro(admincadastro);
                CustomMessageBox.Show("Novo usuário cadastrado com sucesso!", "Aviso: Cadastro Concluído");
                limpar();
            }
            else
            {
                CustomMessageBox.Show("As credenciais não podem estar vazias!", "Erro: Credenciais Inválidas");
                limpar();
                txtidcadastrar.Focus();
            }
        }

        private void IdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir apenas letras
            e.Handled = !Regex.IsMatch(e.Text, @"^\d{0,3}$");
        }


    }
}
