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

namespace biletomat1
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        


        private void jednorazowe_Click(object sender, RoutedEventArgs e)
        {

            Page2 p2 = new Page2();               //bilety jednorazowe
            this.NavigationService.Navigate(p2);
        }

        private void miesieczne_Click(object sender, RoutedEventArgs e)
        {
            Miesieczne msc = new Miesieczne();
            this.NavigationService.Navigate(msc);
        }

        private void _30_dniowe_Click(object sender, RoutedEventArgs e)
        {
            trzyDniowy trz = new trzyDniowy();
            this.NavigationService.Navigate(trz);
        }

        private void semestralne_Click(object sender, RoutedEventArgs e)
        {
            Semestralne sem = new Semestralne();
            this.NavigationService.Navigate(sem);
        }

        private void metropolitarne_Click(object sender, RoutedEventArgs e)
        {
            Metropolitalne metrop = new Metropolitalne();
            this.NavigationService.Navigate(metrop);
        }
    }

}
