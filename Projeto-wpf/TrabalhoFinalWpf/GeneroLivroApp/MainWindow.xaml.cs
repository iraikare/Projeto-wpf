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

namespace GeneroLivroApp
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

        private Genero gen;
        private void btngenero_Click(object sender, RoutedEventArgs e)
        {
            gen = new Genero(txtgenero.Text);
            btninserir.IsEnabled = true;
            btncalc.IsEnabled = false;
            btnlistar.IsEnabled = false;
        }

        private void btninserir_Click(object sender, RoutedEventArgs e)
        {
            Livro x = new Livro(txtnome.Text, txtautor.Text, double.Parse(txtpreco.Text));
            gen.Inserir(x);
            btncalc.IsEnabled = true;
            btnlistar.IsEnabled = true;
            txtnome.Clear();
            txtautor.Clear();
            txtpreco.Clear();
        }

        private void btnlistar_Click(object sender, RoutedEventArgs e)
        {
            txtlista.ItemsSource = null;
            txtlista.ItemsSource = gen.Listar();
        }

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            txtmenor.Text = gen.MenorPreco().ToString();
        }
    }
}
