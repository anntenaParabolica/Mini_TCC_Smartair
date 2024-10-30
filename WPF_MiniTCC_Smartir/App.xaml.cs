using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_MiniTCC_Smartir
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Mostrar a tela de splash
            SplashScreen splash = new SplashScreen();
            splash.Show();

            // Simular um atraso para a transição (opcional)
            Task.Delay(3000).ContinueWith(t =>
            {
                // Criar e mostrar a janela principal
                Dispatcher.Invoke(() =>
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    splash.Close();
                });
            });
        }
    }
}
