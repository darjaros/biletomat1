using System;
using System.Collections.Generic;
using System.Data;
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
    /// Logika interakcji dla klasy miesieczne.xaml
    /// </summary>
    public partial class Metropolitalne : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Metropolitalne()
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


        public bool zmienna_button_3_2;
        DataTable dt = new DataTable();
        public string rodzaj_biletu;
        public double cena_biletu;
        List<Tickets> ticket = new List<Tickets>();
        public double suma = 0;
        List<string> tickets = new List<string>();
        Tickets ulg = new Tickets();
        public double suma_biletow = 0;
        int i = 0;
        int a150 = 0, a200 = 0, a230 = 0, a300 = 0, a480 = 0, a750 = 0, a100 = 0, a115 = 0, a150_ulg = 0, a230_ulg = 0;
        int i150 = 0, i200 = 0, i230 = 0, i300 = 0, i480 = 0, i750 = 0, i100 = 0, i115 = 0, i150_ulg = 0, i230_ulg = 0;

        public class Tickets
        {
            //public int ilosc = 0;
            public int liczba { get; set; }


            public string Name { get; set; }

            public double cena { get; set; }

        }
    
        void showTable()
        {
            dataGrid.ItemsSource = ticket;
            dataGrid.Items.Refresh();
            i = +1;
            //  suma = ticket.;
        }

        void zaplata()
        {
            //  double cena;
            // suma_biletow = cena;
            int count = ticket.Count();
            suma_biletow = 0;

            foreach (Tickets oticket in ticket)
            {
                suma_biletow = suma_biletow + oticket.cena;
            }
            do_zaplaty.Content = Convert.ToString(suma_biletow);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Pg Pg1 = new Pg(suma_biletow);
            this.NavigationService.Navigate(Pg1);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Koniec koniec = new Koniec(1);
            this.NavigationService.Navigate(koniec);
        }

        private void button150_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a150 == 0) { i150 = i; i++; }

            if (a150 > 0)
            {

                ticket.RemoveAt(i150);
            }

            a150 = Convert.ToInt32(ilosc150.Text) + 1;
            ilosc150.Text = Convert.ToString(a150);
            //ticket.Count
            //   ticket.Contains
            //  ticket.Exists
            ticket.Insert(i150, new Tickets() { liczba = a150, Name = "Normalny 24H komunalny", cena = a150 * 15 });
            zaplata();
            //ticket.Add(new Tickets() { liczba = a32, Name = "normalny wazny na lini zwyklej", cena = a32 * 3.2 });
            showTable();

            //            a32 = wyswietlanie_plus(3.2, a32, i32);


        }

        private void button150_minus_Click(object sender, RoutedEventArgs e)
        {
            a150 = Convert.ToInt32(ilosc150.Text) - 1;
            ilosc150.Text = Convert.ToString(a150);

            if (a150 < 0)
            {
                ilosc150.Text = Convert.ToString(0);
                a150 = 0;
            }

            ticket.RemoveAt(i150);
            ticket.Insert(i150, new Tickets() { liczba = a150, Name = "Normalny 24H komunalny", cena = a150 * 15 });
            zaplata();

            showTable();
            //a150 = wyswietlanie_minus(3.2, a150, i42);

        }

        private void button_Copy1_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            Koniec koniec = new Koniec(1);
            this.NavigationService.Navigate(koniec);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 p11 = new Page1();
            this.NavigationService.Navigate(p11);
        }

        private void button200_minus_Click(object sender, RoutedEventArgs e)
        {
            a200 = Convert.ToInt32(ilosc200.Text) - 1;
            ilosc200.Text = Convert.ToString(a200);

            if (a200 < 0)
            {
                ilosc200.Text = Convert.ToString(0);
                a200 = 0;
            }

            ticket.RemoveAt(i200);
            ticket.Insert(i200, new Tickets() { liczba = a200, Name = "Normalny 24H kolejowo komunalny dwoch organizatorow", cena = a200 * 20 });
            zaplata();

            showTable();
            // a200 = wyswietlanie_minus(4.2, a200, i200);
        }

        private void button200_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a200 == 0) { i200 = i; i++; }

            if (a200 > 0)
            {

                ticket.RemoveAt(i200);
            }

            a200 = Convert.ToInt32(ilosc200.Text) + 1;
            ilosc200.Text = Convert.ToString(a200);

            ticket.Insert(i200, new Tickets() { liczba = a200, Name = "Normalny 24H kolejowo komunalny dwoch organizatorow", cena = a200 * 20 });
            showTable();
            zaplata();

            //a42 = wyswietlanie_plus(4.2, a42, i42);
            //i++;
        }

        private void button230_minus_Click(object sender, RoutedEventArgs e)
        {
            a230 = Convert.ToInt32(ilosc230.Text) - 1;
            ilosc230.Text = Convert.ToString(a230);

            if (a230 < 0)
            {
                ilosc230.Text = Convert.ToString(0);
                a230 = 0;
            }

            ticket.RemoveAt(i230);
            ticket.Insert(i230, new Tickets() { liczba = a230, Name = "Normalny 24H kolejowo komunalny wszystkich organizatorow", cena = a230 * 23});
            zaplata();

            showTable();
        }

        private void button230_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a230 == 0) { i230 = i; i++; }

            if (a230 > 0)
            {

                ticket.RemoveAt(i230);
            }

            a230 = Convert.ToInt32(ilosc230.Text) + 1;
            ilosc230.Text = Convert.ToString(a230);

            ticket.Insert(i230, new Tickets() { liczba = a230, Name = "Normalny 24H kolejowo komunalny wszystkich organizatorow", cena = a230 * 23 });
            showTable();
            zaplata();

        }
        private void button300_minus_Click(object sender, RoutedEventArgs e)
        {
            a300 = Convert.ToInt32(ilosc300.Text) - 1;
            ilosc300.Text = Convert.ToString(a300);

            if (a300 < 0)
            {
                ilosc300.Text = Convert.ToString(0);
                a300 = 0;
            }

            ticket.RemoveAt(i300);
            ticket.Insert(i300, new Tickets() { liczba = a300, Name = "Normalny 72H komunalny ", cena = a300 * 30 });
            zaplata();

            showTable();
            // a300 = wyswietlanie_minus(4.2, a300, i300);
        }

        private void button300_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a300 == 0) { i300 = i; i++; }

            if (a300 > 0)
            {

                ticket.RemoveAt(i300);
            }

            a300 = Convert.ToInt32(ilosc300.Text) + 1;
            ilosc300.Text = Convert.ToString(a300);

            ticket.Insert(i300, new Tickets() { liczba = a300, Name = "Normalny 72H komunalny", cena = a300 * 30 });
            showTable();
            zaplata();

            //a300 = wyswietlanie_plus(4.2, a300, i300);
            //i++;
        }
        private void button480_minus_Click(object sender, RoutedEventArgs e)
        {
            a480 = Convert.ToInt32(ilosc480.Text) - 1;
            ilosc480.Text = Convert.ToString(a480);

            if (a480 < 0)
            {
                ilosc480.Text = Convert.ToString(0);
                a480 = 0;
            }

            ticket.RemoveAt(i480);
            ticket.Insert(i480, new Tickets() { liczba = a480, Name = "Normalny 72H kolejowo komunalny wszystkich organizatorow", cena = a480 * 48 });
            zaplata();

            showTable();
            // a480 = wyswietlanie_minus(4.2, a480, i480);
        }

        private void button480_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a480 == 0) { i480 = i; i++; }

            if (a480 > 0)
            {

                ticket.RemoveAt(i480);
            }

            a480 = Convert.ToInt32(ilosc480.Text) + 1;
            ilosc480.Text = Convert.ToString(a480);

            ticket.Insert(i480, new Tickets() { liczba = a480, Name = "Normalny 72H kolejowo komunalny wszystkich organizatorow", cena = a480 * 48 });
            showTable();
            zaplata();

            //a480 = wyswietlanie_plus(4.2, a480, i480);
            //i++;
        }
        private void button750_minus_Click(object sender, RoutedEventArgs e)
        {
            a750 = Convert.ToInt32(ilosc750.Text) - 1;
            ilosc750.Text = Convert.ToString(a750);

            if (a750 < 0)
            {
                ilosc750.Text = Convert.ToString(0);
                a750 = 0;
            }

            ticket.RemoveAt(i750);
            ticket.Insert(i750, new Tickets() { liczba = a750, Name = "Ulgowy 24H  komunalny", cena = a750 * 7.5 });

            showTable();
            zaplata();

            // a750 = wyswietlanie_minus(4.2, a750, i750);
        }

        private void button750_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a750 == 0) { i750 = i; i++; }

            if (a750 > 0)
            {

                ticket.RemoveAt(i750);
            }

            a750 = Convert.ToInt32(ilosc750.Text) + 1;
            ilosc750.Text = Convert.ToString(a750);

            ticket.Insert(i750, new Tickets() { liczba = a750, Name = "Ulgowy 24H komunalny", cena = a750 * 7.5 });
            showTable();
            zaplata();

            //a750 = wyswietlanie_plus(4.2, a750, i750);
            //i++;
        }
        private void button100_minus_Click(object sender, RoutedEventArgs e)
        {
            a100 = Convert.ToInt32(ilosc100.Text) - 1;
            ilosc100.Text = Convert.ToString(a100);

            if (a100 < 0)
            {
                ilosc100.Text = Convert.ToString(0);
                a100 = 0;
            }

            ticket.RemoveAt(i100);
            ticket.Insert(i100, new Tickets() { liczba = a100, Name = "Ulgowy 24H kolejowo komunalny dwoch organizatorow", cena = a100 * 10 });
            zaplata();

            showTable();
            // a100 = wyswietlanie_minus(4.2, a100, i100);
        }

        private void button100_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a100 == 0) { i100 = i; i++; }

            if (a100 > 0)
            {

                ticket.RemoveAt(i100);
            }

            a100 = Convert.ToInt32(ilosc100.Text) + 1;
            ilosc100.Text = Convert.ToString(a100);

            ticket.Insert(i100, new Tickets() { liczba = a100, Name = "Ulgowy 24H kolejowo komunalny dwoch organizatorow", cena = a100 * 10 });
            showTable();
            zaplata();

            //a100 = wyswietlanie_plus(4.2, a100, i100);
            //i++;
        }
        private void button115_minus_Click(object sender, RoutedEventArgs e)
        {
            a115 = Convert.ToInt32(ilosc115.Text) - 1;
            ilosc115.Text = Convert.ToString(a115);

            if (a115 < 0)
            {
                ilosc115.Text = Convert.ToString(0);
                a115 = 0;
            }

            ticket.RemoveAt(i115);
            ticket.Insert(i115, new Tickets() { liczba = a115, Name = "Ulgowy 24H kolejowo komunalny wszystkich organizatorow", cena = a115 * 11.5 });

            showTable();
            zaplata();

            // a115 = wyswietlanie_minus(4.2, a115, i115);
        }

        private void button115_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a115 == 0) { i115 = i; i++; }

            if (a115 > 0)
            {

                ticket.RemoveAt(i115);
            }

            a115 = Convert.ToInt32(ilosc115.Text) + 1;
            ilosc115.Text = Convert.ToString(a115);

            ticket.Insert(i115, new Tickets() { liczba = a115, Name = "Ulgowy 24H kolejowo komunalny wszystkich organizatorow", cena = a115 * 11.5 });
            showTable();
            zaplata();

            //a115 = wyswietlanie_plus(4.2, a115, i115);
            //i++;
        }
        private void button150_ulg_minus_Click(object sender, RoutedEventArgs e)
        {
            a150_ulg = Convert.ToInt32(ilosc150_ulg.Text) - 1;
            ilosc150_ulg.Text = Convert.ToString(a150_ulg);

            if (a150_ulg < 0)
            {
                ilosc150_ulg.Text = Convert.ToString(0);
                a150_ulg = 0;
            }

            ticket.RemoveAt(i150_ulg);
            ticket.Insert(i150_ulg, new Tickets() { liczba = a150_ulg, Name = "Ulgowy 72H komunalny ", cena = a150_ulg * 15 });

            zaplata();

            showTable();
            // a150_ulg = wyswietlanie_minus(4.2, a150_ulg, i150_ulg);
        }

        private void button150_ulg_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a150_ulg == 0) { i150_ulg = i; i++; }

            if (a150_ulg > 0)
            {

                ticket.RemoveAt(i150_ulg);
            }

            a150_ulg = Convert.ToInt32(ilosc150_ulg.Text) + 1;
            ilosc150_ulg.Text = Convert.ToString(a150_ulg);

            ticket.Insert(i150_ulg, new Tickets() { liczba = a150_ulg, Name = "Ulgowy 72H  komunalny", cena = a150_ulg * 15 });
            showTable();
            zaplata();

            //a150_ulg = wyswietlanie_plus(4.2, a150_ulg, i150_u);
            //i++;
        }
        private void button230_ulg_minus_Click(object sender, RoutedEventArgs e)
        {
            a230_ulg = Convert.ToInt32(ilosc230_ulg.Text) - 1;
            ilosc230_ulg.Text = Convert.ToString(a230_ulg);

            if (a230_ulg < 0)
            {
                ilosc230_ulg.Text = Convert.ToString(0);
                a230_ulg = 0;
            }

            ticket.RemoveAt(i230_ulg);
            ticket.Insert(i230_ulg, new Tickets() { liczba = a230_ulg, Name = "Ulgowy 72H kolejowo komunalny wszystkich organizatorow", cena = a230_ulg * 23 });

            showTable();
            zaplata();

            // a230_ulg = wyswietlanie_minus(4.2, a230_ulg, i230_ulg);
        }

        private void button230_ulg_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a230_ulg == 0) { i230_ulg = i; i++; }

            if (a230_ulg > 0)
            {

                ticket.RemoveAt(i230_ulg);
            }

            a230_ulg = Convert.ToInt32(ilosc230_ulg.Text) + 1;
            ilosc230_ulg.Text = Convert.ToString(a230_ulg);

            ticket.Insert(i230_ulg, new Tickets() { liczba = a230_ulg, Name = "Ulgowy 72H kolejowo komunalny wszystkich organizatorow", cena = a230_ulg * 23 });
            showTable();
            zaplata();

        }
    }
}
