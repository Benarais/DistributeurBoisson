using DistributeurBoisson.ViewModel;
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

namespace DistributeurBoisson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AfficherPrix viewModelAfficherPrix { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            viewModelAfficherPrix = new AfficherPrix();
            DataContext = viewModelAfficherPrix;
        }

        private void choisirBoisson(object sender, SelectionChangedEventArgs e)
        {
            prixBoisson.Text = viewModelAfficherPrix.determinerPrix(boissonChoisie.SelectedItem.ToString()) + " euros";
        }
    }
}
