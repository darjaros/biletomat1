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
    /// Logika interakcji dla klasy _30_dniowy.xaml
    /// </summary>
    public partial class trzyDniowy : Page
    {   
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public trzyDniowy()
        {
            InitializeComponent();

            calendar.SelectedDate =  DateTime.Now;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 60000;
            timer.Start();
            date();
        }
        private void date()
        {   
            DateTime start = calendar.SelectedDate.Value;
            if ((DateTime.Compare(start, DateTime.Now)) < 0)
            {
                start = DateTime.Now;
                // Dorzuć popup
            }

            DateTime end = start.AddDays(30);
            data.Content = String.Concat("Bilet ważny od ",start.ToShortDateString()," do ",end.ToShortDateString());
        }
        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            timer.Stop();
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        public double suma_biletow;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button_1_1_Click(object sender, RoutedEventArgs e)
        {

            do_zaplaty.Content = 72.00;
            suma_biletow = 72.00;
        }

        private void button_1_2_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 86.00;
            suma_biletow = 86.00;
        }

        private void button_1_3_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 58.00;
            suma_biletow = 58.00;
        }

        private void button_1_4_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 74.00;
            suma_biletow = 74.00;
        }

        private void button_1_5_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 96.00;
            suma_biletow = 96.00;
        }

        private void button_2_1_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 36.00;
            suma_biletow = 36.00;
        }

        private void button_2_2_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 43.00;
            suma_biletow = 43.00;
        }

        private void button_2_3_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 29.00;
            suma_biletow = 29.00;
        }

        private void button_2_4_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 37.00;
            suma_biletow = 37.00;
        }

        private void button_2_5_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 48.00;
            suma_biletow = 48.00;
        }

        private void button_3_1_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 82.00;
            suma_biletow = 48.00;
        }

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 94.00;
            suma_biletow = 94.00;
        }

        private void button_3_3_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 64.00;
            suma_biletow = 64.00;
        }

        private void button_3_4_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 84.00;
            suma_biletow = 84.00;
        }

        private void button_3_5_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 104.00;
            suma_biletow = 104.00;
        }

        private void button_4_1_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 41.00;
            suma_biletow = 41.00;
        }

        private void button_4_2_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 47.00;
            suma_biletow = 47.00;
        }

        private void button_4_3_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 32.00;
            suma_biletow = 32.00;
        }

        private void button_4_4_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 42.00;
            suma_biletow = 42.00;
        }

        private void button_4_5_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 52.00;
            suma_biletow = 52.00;
        }

        private void button_5_1_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 92.00;
            suma_biletow = 92.00;
        }

        private void button_5_2_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 107.00;
            suma_biletow = 107.00;
        }

        private void button_5_3_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 75.00;
            suma_biletow = 75.00;
        }

        private void button_5_4_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 97.00;
            suma_biletow = 97.00;
        }

        private void button_5_5_Click(object sender, RoutedEventArgs e)
        {
            do_zaplaty.Content = 117.00;
            suma_biletow = 117.00;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Koniec koniec = new Koniec(1);
            this.NavigationService.Navigate(koniec);
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Pg Pg1 = new Pg(suma_biletow);
            this.NavigationService.Navigate(Pg1);
        }

        

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            date();
        }
    }
}
