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
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 156.00;
        }
        private int miejsce=11;
        private void unselectbutton()
        {
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x05, 0x90, 0xd1));
            if (miejsce == 11) { button_1_1.Background = mySolidColorBrush; }
            if (miejsce == 12) { button_1_2.Background = mySolidColorBrush; }
            if (miejsce == 21) { button_2_1.Background = mySolidColorBrush; }
            if (miejsce == 22) { button_2_2.Background = mySolidColorBrush; }
            if (miejsce == 31) { button_3_1.Background = mySolidColorBrush; }
            if (miejsce == 32) { button_3_2.Background = mySolidColorBrush; }
            if (miejsce == 41) { button_4_1.Background = mySolidColorBrush; }
            if (miejsce == 42) { button_4_2.Background = mySolidColorBrush; }
            if (miejsce == 51) { button_5_1.Background = mySolidColorBrush; }
            if (miejsce == 52) { button_5_2.Background = mySolidColorBrush; }
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

        private void button_1_1_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 156.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 11;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_1.Background = mySolidColorBrush;
        }

        private void button_2_1_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add( "od 1 października do 31 stycznia"  );
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 179.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 21;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_1.Background = mySolidColorBrush;
        }


        private void button_4_1_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 160.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 41;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_1.Background = mySolidColorBrush;
        }

        private void button_5_1_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 198.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 51;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_1.Background = mySolidColorBrush;

        }

        private void button_1_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            lista.SelectedIndex = 1;
            suma_biletow = 195.00;
            do_zaplaty.Content = suma_biletow.ToString("N2"); 
            unselectbutton();
            miejsce = 31;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_2.Background = mySolidColorBrush;
        }

        private void button_2_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            lista.SelectedIndex = 1;
            suma_biletow = 223.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 22;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_2.Background = mySolidColorBrush;
        }

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            lista.SelectedIndex = 1;
            suma_biletow = 152.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 32;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_2.Background = mySolidColorBrush;

        }

        private void button_4_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            lista.SelectedIndex = 1;
            suma_biletow = 200.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 42;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_2.Background = mySolidColorBrush;
        }

        private void button_5_2_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 września do 31 stycznia");
            lista.Items.Add("od 1 lutego do 30 czerwca");
            lista.SelectedIndex = 1;
            suma_biletow = 247.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 52;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_2.Background = mySolidColorBrush;
        }

        private void button_3_1_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add("od 1 października do 31 stycznia");
            lista.Items.Add("od 1 lutego do 31 maja");
            lista.SelectedIndex = 1;
            suma_biletow = 122.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 31;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_1.Background = mySolidColorBrush;
        }
    }
}
