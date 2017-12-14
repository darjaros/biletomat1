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
        string[] miesiac = new string[12] {
            "STYCZEŃ",
            "LUTY",
            "MARZEC",
            "KWIECIEŃ",
            "MAJ",
            "CZERWIEC",
            "LIPIEC",
            "SIERPIEŃ",
            "WRZESIEŃ",
            "PAŹDZIERNIK",
            "LISTOPAD",
            "GRUDZIEŃ"
        };
        

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Miesieczne()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            int month = now.Month-1;
            int year = now.Year;
            for (int i = 0; i < 12; i++)
            {
                miesace.Items.Add(String.Concat( miesiac[month]," ", year.ToString()));
                month++;
                if (month >11)
                {
                    month = 0;
                    year++;
                }
            }
            miesace.SelectedIndex=0;

            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 60000;
            timer.Start();
        }
      
        private void unselectbutton ( ) {
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x05, 0x90, 0xd1));
            if (miejsce == 11){ button_1_1.Background = mySolidColorBrush;}
            if (miejsce == 12) { button_1_2.Background = mySolidColorBrush;}
            if (miejsce == 13) { button_1_3.Background = mySolidColorBrush; }
            if (miejsce == 14) { button_1_4.Background = mySolidColorBrush; }
            if (miejsce == 15) { button_1_5.Background = mySolidColorBrush; }
            if (miejsce == 21) { button_2_1.Background = mySolidColorBrush; }
            if (miejsce == 22) { button_2_2.Background = mySolidColorBrush; }
            if (miejsce == 23) { button_2_3.Background = mySolidColorBrush; }
            if (miejsce == 24) { button_2_4.Background = mySolidColorBrush; }
            if (miejsce == 25) { button_2_5.Background = mySolidColorBrush; }
            if (miejsce == 31) { button_3_1.Background = mySolidColorBrush; }
            if (miejsce == 32) { button_3_2.Background = mySolidColorBrush; }
            if (miejsce == 33) { button_3_3.Background = mySolidColorBrush; }
            if (miejsce == 34) { button_3_4.Background = mySolidColorBrush; }
            if (miejsce == 35) { button_3_5.Background = mySolidColorBrush; }
            if (miejsce == 41) { button_4_1.Background = mySolidColorBrush; }
            if (miejsce == 42) { button_4_2.Background = mySolidColorBrush; }
            if (miejsce == 43) { button_4_3.Background = mySolidColorBrush; }
            if (miejsce == 44) { button_4_4.Background = mySolidColorBrush; }
            if (miejsce == 45) { button_4_5.Background = mySolidColorBrush; }
            if (miejsce == 51) { button_5_1.Background = mySolidColorBrush; }
            if (miejsce == 52) { button_5_2.Background = mySolidColorBrush; }
            if (miejsce == 53) { button_5_3.Background = mySolidColorBrush; }
            if (miejsce == 54) { button_5_4.Background = mySolidColorBrush; }
            if (miejsce == 55) { button_5_5.Background = mySolidColorBrush; }
        }
        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            timer.Stop();
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }
        private double suma_biletow=72.00;
        private int miejsce = 11;



        

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
            unselectbutton();
            miejsce = 11;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_1.Background = mySolidColorBrush;
        }

        private void button_1_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 36.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 12;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_2.Background = mySolidColorBrush;
        }

        private void button_1_3_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 82.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 13;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_3.Background = mySolidColorBrush;
        }

        private void button_1_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 41.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 14;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_4.Background = mySolidColorBrush;
        }

        private void button_1_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 92.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 15;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_1_5.Background = mySolidColorBrush;
        }

        private void button_2_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 86.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 21;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_1.Background = mySolidColorBrush;
        }

        private void button_2_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 43.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 22;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_2.Background = mySolidColorBrush;
        }

        private void button_2_3_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 94.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 23;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_3.Background = mySolidColorBrush;
        }

        private void button_2_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 47.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 24;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_4.Background = mySolidColorBrush;
        }

        private void button_2_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 107.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 25;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_2_5.Background = mySolidColorBrush;
        }

        private void button_3_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 58.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 31;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_1.Background = mySolidColorBrush;
        }

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 29.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 32;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_2.Background = mySolidColorBrush;
        }

        private void button_3_3_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 64.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 33;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_3.Background = mySolidColorBrush;
        }

        private void button_3_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 32.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 34;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_4.Background = mySolidColorBrush;
        }

        private void button_3_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 75.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 35;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_3_5.Background = mySolidColorBrush;
        }

        private void button_4_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 74.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 41;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_1.Background = mySolidColorBrush;
        }

        private void button_4_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 37.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 42;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_2.Background = mySolidColorBrush;
        }

        private void button_4_3_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 84.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 43;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_3.Background = mySolidColorBrush;
        }

        private void button_4_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 42.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 44;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_4.Background = mySolidColorBrush;
        }

        private void button_4_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 97.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 45;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_4_5.Background = mySolidColorBrush;
        }

        private void button_5_1_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 96.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 51;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_1.Background = mySolidColorBrush;
        }

        private void button_5_2_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 48.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 52;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_2.Background = mySolidColorBrush;
        }

        private void button_5_3_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 104.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 53;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_3.Background = mySolidColorBrush;
        }
        private void button_5_4_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow =52.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 54;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_4.Background = mySolidColorBrush;
        }
        private void button_5_5_Click(object sender, RoutedEventArgs e)
        {
            suma_biletow = 117.00;
            do_zaplaty.Content = suma_biletow.ToString("N2");
            unselectbutton();
            miejsce = 55;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(0x96, 0xdd, 0xff));
            button_5_5.Background = mySolidColorBrush;
        }
    }
}
