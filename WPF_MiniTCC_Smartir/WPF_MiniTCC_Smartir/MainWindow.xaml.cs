using Org.BouncyCastle.Crypto.Signers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MiniTCC_Smartir.Classes;

namespace WPF_MiniTCC_Smartir
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // P/ sumir com o icone dos texts
        private void pswSenha_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(pswSenha.Password))
            {
                ImageBrush imgBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Imagens/key.png")));
                imgBrush.Stretch = Stretch.Uniform;
                imgBrush.AlignmentX = AlignmentX.Left;
                pswSenha.Background = imgBrush;
            }
            
            else
            {
                pswSenha.Background = Brushes.Transparent;
            }
        }
        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                ImageBrush imgBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Imagens/user.png")));
                imgBrush.Stretch = Stretch.Uniform;
                imgBrush.AlignmentX = AlignmentX.Left;
                txtID.Background = imgBrush;
            }
            
            else
            {
                txtID.Background = Brushes.Transparent;
            }
        }

        //Btn Logar
        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {

            if (txtID.Text != "" && pswSenha.Password != "")
            {

                Conta Contalogando = new Conta();
                Contalogando.Idusuario = Convert.ToInt32(txtID.Text);
                Contalogando.Senha = pswSenha.Password;

                if (ContaDAO.adminlogar(Contalogando))
                {
                    //ida para o painel
                    Painel painel = new Painel();
                    painel.Show();
                    this.Close();
                }
                else
                {
                    CustomMessageBox.Show("ID ou Senha incorretos", "Erro: Credenciais Inválidas");
                    txtID.Clear();
                    txtID.Focus();
                    pswSenha.Clear();
                }
            }

            else
            {
                CustomMessageBox.Show("As credenciais não podem estar vazias!", "Erro: Credenciais Inválidas");
                txtID.Clear();
                txtID.Focus();
                pswSenha.Clear();
            }

        }

        private void IdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir apenas letras
            e.Handled = !Regex.IsMatch(e.Text, @"^\d{0,3}$");
        }

        //Passagem direta REMOVER DEPOIS
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Painel painel = new Painel();
            painel.Show();
            this.Close();
        }
    }
}
