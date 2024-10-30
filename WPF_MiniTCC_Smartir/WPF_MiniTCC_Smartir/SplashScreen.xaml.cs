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
using System.Windows.Media.Animation;

namespace WPF_MiniTCC_Smartir
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();

            // Iniciar o efeito de fade-out quando a janela for carregada
            Loaded += SplashScreen_Loaded;
        }

        private void SplashScreen_Loaded(object sender, RoutedEventArgs e)
        {
            // Buscar o storyboard de animação e iniciá-lo
            Storyboard fadeOutStoryboard = (Storyboard)this.FindResource("FadeOutAnimation");
            fadeOutStoryboard.Begin(blackOverlay); // Passar o retângulo como o alvo da animação

        }
    }
}
