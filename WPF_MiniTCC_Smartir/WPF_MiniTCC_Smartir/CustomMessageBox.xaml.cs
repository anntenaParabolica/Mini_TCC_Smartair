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

namespace WPF_MiniTCC_Smartir
{
    /// <summary>
    /// Lógica interna para CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string message, string title = "Message")
        {
            InitializeComponent();
            lblErroMsg.Content = message;
            Title = title;
        }

        public static bool Show(string message, string title = "Message")
        {
            var messageBox = new CustomMessageBox(message, title);
            return messageBox.ShowDialog() == true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
