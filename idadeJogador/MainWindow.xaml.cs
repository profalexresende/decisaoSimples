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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace idadeJogador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);

            //Iniciando a condição
            if (idade >= 12)
            {
                //BLOCO PARA CONDIÇÃO VERDADEIRA
                MessageBox.Show("Você pode jogar!", "ONG",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
