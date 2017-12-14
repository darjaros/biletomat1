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
    /// Logika interakcji dla klasy Page3.xaml
    /// </summary>
    public partial class Drukowanie : Page
    {
        public Drukowanie()
        {
            InitializeComponent();
            Task.Delay(2000).Wait();
            Koniec koniec = new Koniec(4);
            this.NavigationService.Navigate(koniec);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
