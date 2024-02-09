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
using DataAccess;
namespace KleiderShop.View
{
    /// <summary>
    /// Interaktionslogik für MainViewTest.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySQLConnector sQLConnector = new MySQLConnector();

            MessageBox.Show(sQLConnector.testConnection());
        }

        private void btnLoeschen(object sender, RoutedEventArgs e)
        {
            DbManager.loescheDantensatz();
        }

        private void btnSpeichern(object sender, RoutedEventArgs e)
        {
            DbManager.fuegeDatensatzHinzu();
        }
        
        private void btnAktualisieren(object sender, RoutedEventArgs e)
        {
            DbManager.updateDatenzsatz();
        }

        private void btnZurueck(object sender, RoutedEventArgs e)
        {

        }

        private void btnVorwaerts(object sender, RoutedEventArgs e)
        {

        }
    }
}
