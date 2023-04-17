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

namespace WpfApp
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
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            // Obtém a altura e o peso digitados pelo usuário
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPeso.Text);

            // Calcula o IMC
            double imc = (peso / (altura * altura))*100;

            // Exibe o resultado do IMC em um TextBlock
            txtResultado.Text = $"Seu IMC é: {imc.ToString("N2")}";
        }
    }
}