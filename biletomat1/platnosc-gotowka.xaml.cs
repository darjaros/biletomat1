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
    public partial class Pg : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Pg(double cenna)
        {
            InitializeComponent();
            //do_zapl.Content = Convert.ToString(suma_biletow);
            zaplata = cenna;
            do_zapl.Content = zaplata;
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

        private void TimerEventProcessor2(Object myObject,
                                            EventArgs myEventArgs)
        {
            Koniec koniec = new Koniec(3);
            this.NavigationService.Navigate(koniec);
        }


        private double zaplata ;
        private void change ()
        {
            if (zaplata <= 0)
            {
                System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(TimerEventProcessor2);
                timer2.Interval = 2000;
                timer2.Start();

            }
            do_zapl.Content = zaplata.ToString("N2");
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
                 Page1 p11 = new Page1();
                this.NavigationService.Navigate(p11);
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            zaplata -= 20;
            change();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            zaplata -= 10;
            change();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            zaplata -= 5;
            change();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            zaplata -= 2;
            change();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            zaplata -= 1;
            change();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            zaplata -= 0.5;
            change();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            zaplata -= 0.2;
            change();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            zaplata -= 0.1;
            if (zaplata <= 0)
            change();
        }
        
    }
}
