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
    public partial class Semestralne : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private double suma_biletow;
        public Semestralne()
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

    private void button_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            this.NavigationService.Navigate(page1);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Koniec koniec = new Koniec(1);
            this.NavigationService.Navigate(koniec);
        }


        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Pg pg = new Pg(suma_biletow);
            this.NavigationService.Navigate(pg);
        }

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            suma_biletow = 156.00;
            do_zaplaty.Content = suma_biletow;
         }

        private void button_4_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add( "od 1 października do 31 stycznia"  );
            lista.Items.Add("od 1 lutego do 31 maja");
            suma_biletow = 179.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_8_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            suma_biletow = 122.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_8_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            suma_biletow = 160.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_13_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            suma_biletow = 198.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_2_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            suma_biletow = 195.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_2_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            suma_biletow = 223.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_3_8_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            suma_biletow = 152.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_4_8_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            suma_biletow = 200.00;
            do_zaplaty.Content = suma_biletow;
        }

        private void button_13_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            suma_biletow = 247.00;
            do_zaplaty.Content = suma_biletow;
        }
    }
}
