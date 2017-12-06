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

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 72.00;
            do_zaplaty.Content = suma_biletow;


        }

        private void button_1_6_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 36.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_2_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 82.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_1_6_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 41.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_1_6_Copy1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 92.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 86.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 43.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_2_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 94.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_1_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 47.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 107.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_8_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 58.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_1_9_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 29.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_8_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 64.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_1_9_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 32.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_1_9_Copy1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 75.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_8_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 74.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 37.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_8_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 84.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_4_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 42.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_2_4_Copy1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 97.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_13_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 96.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_6_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 48.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_13_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 104.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_6_5_Copy_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 52.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_6_5_Copy1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 117.00;
            do_zaplaty.Content = suma_biletow;
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
    }
}
