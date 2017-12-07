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
    public partial class Miesieczne : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Miesieczne()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 60000;
            timer.Start();
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            timer.Stop();
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }
        private double suma_biletow;
        private int miejsce = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Koniec koniec = new Koniec(1);
            this.NavigationService.Navigate(koniec);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Pg pg = new Pg(suma_biletow);
            this.NavigationService.Navigate(pg);
        }

        private void button_1_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 72.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            miejsce = 11;

        }
    }
}
