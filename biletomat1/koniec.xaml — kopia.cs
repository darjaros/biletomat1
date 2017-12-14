using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace biletomat1
{
    /// <summary>
    /// Logika interakcji dla klasy Page3.xaml
    /// </summary>
    public partial class Koniec : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        
        public Koniec(int tekst)
        {
            InitializeComponent();
            button.IsEnabled = false;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 5000;
            opcja = tekst;
            Zmianna();
            timer.Start();
        }
        private  int opcja;
        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            timer.Stop();
            if (opcja > 4)
            {
                Page1 p11 = new Page1();
                this.NavigationService.Navigate(p11);
            }
            Zmianna();
            timer.Start();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
           this.NavigationService.Navigate(p11);
           
        }

 
        private void Zmianna()
        {
            if (opcja == 1)
            {
                text.Content = "PROSZĘ POSTĘPOWAĆ ZGODNIE Z\nINSTRUKCJAMI NA PINPADZIE";
            }
            if (opcja == 2)
            {
                text.Content = "PROSZĘ CZEKAĆ...";
            }
            if (opcja == 3)
            {
                text.Content = "TRWA DRUKOWANIE BILETU...";
            }

            if (opcja == 4)
            {
                text.Content = "DZIĘKUJEMY!\nŻYCZYMY MIŁEJ PODRÓŻY";
                button.Opacity = 100;
                button.IsEnabled = true;
                timer.Interval = 30000;
            }
            opcja++;
        }
    }
}
