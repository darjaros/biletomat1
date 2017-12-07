using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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
        int a32 = 0, a42 = 0, a38 = 0, a48 = 0, a13 = 0, a16 = 0, a21 = 0, a19 = 0, a24 = 0, a65 = 0;
        int i32 = 0, i42 = 0, i38 = 0, i48 = 0, i13 = 0, i16 = 0, i21 = 0, i19 = 0, i24 = 0, i65 = 0;

        public class Tickets
        {
            //public int ilosc = 0;
            public int liczba { get; set; }


            public string Name { get; set; }

            public double cena { get; set; }
            public double cena1
            {
                set
                {

                }
            }



        }
        private float cenna;
        public Page2()
        {
            InitializeComponent();

            dt.Columns.Add("liczba biletow");
         
            dt.Columns.Add("rodaj biletu");
            dt.Columns.Add("cena biletu");
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
            
            do_zaplaty.Content = suma_biletow.ToString("N2");
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

        private void button32_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a32 == 0) { i32 = i; i++; }

            if (a32 > 0)
            {

                ticket.RemoveAt(i32);
            }

            a32 = Convert.ToInt32(ilosc32.Text) + 1;
            ilosc32.Text = Convert.ToString(a32);
            //ticket.Count
            //   ticket.Contains
            //  ticket.Exists
            ticket.Insert(i32, new Tickets() { liczba = a32, Name = "normalny wazny na lini zwyklej", cena = a32 * 3.20 });
            zaplata();
            //ticket.Add(new Tickets() { liczba = a32, Name = "normalny wazny na lini zwyklej", cena = a32 * 3.2 });
            showTable();

            //            a32 = wyswietlanie_plus(3.2, a32, i32);


        }

        private void button32_minus_Click(object sender, RoutedEventArgs e)
        {
            a32 = Convert.ToInt32(ilosc32.Text) - 1;
            ilosc32.Text = Convert.ToString(a32);

            if (a32 < 0)
            {
                ilosc32.Text = Convert.ToString(0);
                a32 = 0;
            }

            ticket.RemoveAt(i32);
            ticket.Insert(i32, new Tickets() { liczba = a32, Name = "normalny wazny na lini zwyklej", cena = a32 * 3.20 });
            zaplata();

            showTable();
            //a32 = wyswietlanie_minus(3.2, a32, i42);

        }

       

        private void button42_minus_Click(object sender, RoutedEventArgs e)
        {
            a42 = Convert.ToInt32(ilosc42.Text) - 1;
            ilosc42.Text = Convert.ToString(a42);

            if (a42 < 0)
            {
                ilosc42.Text = Convert.ToString(0);
                a42 = 0;
            }

            ticket.RemoveAt(i42);
            ticket.Insert(i42, new Tickets() { liczba = a42, Name = "normalny wazny na pospiesznej,/n specjalnej i zwyklej", cena = a42 * 4.20 });
            zaplata();

            showTable();
            // a42 = wyswietlanie_minus(4.2, a42, i42);
        }

        private void button42_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a42 == 0) { i42 = i; i++; }

            if (a42 > 0)
            {

                ticket.RemoveAt(i42);
            }

            a42 = Convert.ToInt32(ilosc42.Text) + 1;
            ilosc42.Text = Convert.ToString(a42);

            ticket.Insert(i42, new Tickets() { liczba = a42, Name = "normalny wazny na pospiesznej,\n nocnej i zwyklej", cena = a42 * 4.20 });
            showTable();
            zaplata();

            //a42 = wyswietlanie_plus(4.2, a42, i42);
            //i++;
        }

        private void button38_minus_Click(object sender, RoutedEventArgs e)
        {
            a38 = Convert.ToInt32(ilosc38.Text) - 1;
            ilosc38.Text = Convert.ToString(a38);

            if (a38 < 0)
            {
                ilosc38.Text = Convert.ToString(0);
                a38 = 0;
            }

            ticket.RemoveAt(i38);
            ticket.Insert(i38, new Tickets() { liczba = a38, Name = "normalny 1-godzinny wazny na liniach zwyklych", cena = a38 * 3.80 });
            zaplata();

            showTable();
        }

        private void button38_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a38 == 0) { i38 = i; i++; }

            if (a38 > 0)
            {

                ticket.RemoveAt(i38);
            }

            a38 = Convert.ToInt32(ilosc38.Text) + 1;
            ilosc38.Text = Convert.ToString(a38);

            ticket.Insert(i38, new Tickets() { liczba = a38, Name = "normalny 1-godzinny wazny na liniach zwyklych", cena = a38 * 3.80 });
            showTable();
            zaplata();

        }
        private void button48_minus_Click(object sender, RoutedEventArgs e)
        {
            a48 = Convert.ToInt32(ilosc48.Text) - 1;
            ilosc48.Text = Convert.ToString(a48);

            if (a48 < 0)
            {
                ilosc48.Text = Convert.ToString(0);
                a48 = 0;
            }

            ticket.RemoveAt(i48);
            ticket.Insert(i48, new Tickets() { liczba = a48, Name = "normalny 1-godzinny wazny na liniach pospiesznych, specjalnych i zwyklych", cena = a48 * 4.80 });
            zaplata();

            showTable();
            // a48 = wyswietlanie_minus(4.2, a48, i48);
        }

        private void button48_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a48 == 0) { i48 = i; i++; }

            if (a48 > 0)
            {

                ticket.RemoveAt(i48);
            }

            a48 = Convert.ToInt32(ilosc48.Text) + 1;
            ilosc48.Text = Convert.ToString(a48);

            ticket.Insert(i48, new Tickets() { liczba = a48, Name = "normalny 1-godzinny wazny na liniach pospiesznych, specjalnych i zwyklych", cena = a48 * 4.80 });
            showTable();
            zaplata();

            //a48 = wyswietlanie_plus(4.2, a48, i48);
            //i++;
        }
        private void button13_minus_Click(object sender, RoutedEventArgs e)
        {
            a13 = Convert.ToInt32(ilosc13.Text) - 1;
            ilosc13.Text = Convert.ToString(a13);

            if (a13 < 0)
            {
                ilosc13.Text = Convert.ToString(0);
                a13 = 0;
            }

            ticket.RemoveAt(i13);
            ticket.Insert(i13, new Tickets() { liczba = a13, Name = "normalny 24-godzinny wazny na liniach nocnych, pospiesznych, specjalnych i zwyklych", cena = a13 * 13.00 });
            zaplata();

            showTable();
            // a13 = wyswietlanie_minus(4.2, a13, i13);
        }

        private void button13_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a13 == 0) { i13 = i; i++; }

            if (a13 > 0)
            {

                ticket.RemoveAt(i13);
            }

            a13 = Convert.ToInt32(ilosc13.Text) + 1;
            ilosc13.Text = Convert.ToString(a13);

            ticket.Insert(i13, new Tickets() { liczba = a13, Name = "normalny 24-godzinny wazny na liniach nocnych, pospiesznych, specjalnych i zwyklych", cena = a13 * 13.00 });
            showTable();
            zaplata();

            //a13 = wyswietlanie_plus(4.2, a13, i13);
            //i++;
        }
        private void button16_minus_Click(object sender, RoutedEventArgs e)
        {
            a16 = Convert.ToInt32(ilosc16.Text) - 1;
            ilosc16.Text = Convert.ToString(a16);

            if (a16 < 0)
            {
                ilosc16.Text = Convert.ToString(0);
                a16 = 0;
            }

            ticket.RemoveAt(i16);
            ticket.Insert(i16, new Tickets() { liczba = a16, Name = "Ulgowy wazny na liniach zwyklych", cena = a16 * 1.60 });

            showTable();
            zaplata();

            // a16 = wyswietlanie_minus(4.2, a16, i16);
        }

        private void button16_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a16 == 0) { i16 = i; i++; }

            if (a16 > 0)
            {

                ticket.RemoveAt(i16);
            }

            a16 = Convert.ToInt32(ilosc16.Text) + 1;
            ilosc16.Text = Convert.ToString(a16);

            ticket.Insert(i16, new Tickets() { liczba = a16, Name = "Ulgowy wazny na liniach zwyklych", cena = a16 * 1.60 });
            showTable();
            zaplata();

            //a16 = wyswietlanie_plus(4.2, a16, i16);
            //i++;
        }
        private void button21_minus_Click(object sender, RoutedEventArgs e)
        {
            a21 = Convert.ToInt32(ilosc21.Text) - 1;
            ilosc21.Text = Convert.ToString(a21);

            if (a21 < 0)
            {
                ilosc21.Text = Convert.ToString(0);
                a21 = 0;
            }

            ticket.RemoveAt(i21);
            ticket.Insert(i21, new Tickets() { liczba = a21, Name = "Ulgowy wazny na liniach pospiesznej, nocnej i zwyklej", cena = a21 * 2.10 });
            zaplata();

            showTable();
            // a21 = wyswietlanie_minus(4.2, a21, i21);
        }

        private void button21_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a21 == 0) { i21 = i; i++; }

            if (a21 > 0)
            {

                ticket.RemoveAt(i21);
            }

            a21 = Convert.ToInt32(ilosc21.Text) + 1;
            ilosc21.Text = Convert.ToString(a21);

            ticket.Insert(i21, new Tickets() { liczba = a21, Name = "Ulgowy wazny na liniach pospiesznej, nocnej i zwyklej", cena = a21 * 2.10 });
            showTable();
            zaplata();

            //a21 = wyswietlanie_plus(4.2, a21, i21);
            //i++;
        }
        private void button19_minus_Click(object sender, RoutedEventArgs e)
        {
            a19 = Convert.ToInt32(ilosc19.Text) - 1;
            ilosc19.Text = Convert.ToString(a19);

            if (a19 < 0)
            {
                ilosc19.Text = Convert.ToString(0);
                a19 = 0;
            }

            ticket.RemoveAt(i19);
            ticket.Insert(i19, new Tickets() { liczba = a19, Name = "Ulgowy 1-godzinny wazny na liniach zwyklych", cena = a19 * 1.90 });

            showTable();
            zaplata();

            // a19 = wyswietlanie_minus(4.2, a19, i19);
        }

        private void button19_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a19 == 0) { i19 = i; i++; }

            if (a19 > 0)
            {

                ticket.RemoveAt(i19);
            }

            a19 = Convert.ToInt32(ilosc19.Text) + 1;
            ilosc19.Text = Convert.ToString(a19);

            ticket.Insert(i19, new Tickets() { liczba = a19, Name = "Ulgowy 1-godzinny wazny na liniach zwyklych", cena = a19 * 1.90 });
            showTable();
            zaplata();

            //a19 = wyswietlanie_plus(4.2, a19, i19);
            //i++;
        }
        private void button24_minus_Click(object sender, RoutedEventArgs e)
        {
            a24 = Convert.ToInt32(ilosc24.Text) - 1;
            ilosc24.Text = Convert.ToString(a24);

            if (a24 < 0)
            {
                ilosc24.Text = Convert.ToString(0);
                a24 = 0;
            }

            ticket.RemoveAt(i24);
            ticket.Insert(i24, new Tickets() { liczba = a24, Name = "Ulgowy 1-godzinny wazny na liniach nocnych, pospiesznych, specjalnych i zwyklych", cena = a24 * 2.40 });

            zaplata();

            showTable();
            // a24 = wyswietlanie_minus(4.2, a24, i24);
        }

        private void button24_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a24 == 0) { i24 = i; i++; }

            if (a24 > 0)
            {

                ticket.RemoveAt(i24);
            }

            a24 = Convert.ToInt32(ilosc24.Text) + 1;
            ilosc24.Text = Convert.ToString(a24);

            ticket.Insert(i24, new Tickets() { liczba = a24, Name = "Ulgowy 1-godzinny wazny na liniach nocnych, pospiesznych, specjalnych i zwyklych", cena = a24 * 2.40 });
            showTable();
            zaplata();

            //a24 = wyswietlanie_plus(4.2, a24, i24);
            //i++;
        }
        private void button65_minus_Click(object sender, RoutedEventArgs e)
        {
            a65 = Convert.ToInt32(ilosc65.Text) - 1;
            ilosc65.Text = Convert.ToString(a65);

            if (a65 < 0)
            {
                ilosc65.Text = Convert.ToString(0);
                a65 = 0;
            }

            ticket.RemoveAt(i65);
            ticket.Insert(i65, new Tickets() { liczba = a65, Name = "Ulgowy 24-godzinny wazny na linii nocnej, pospiesznej, specjalnej i zwyklej", cena = a65 * 3.2 });

            showTable();
            zaplata();

            // a65 = wyswietlanie_minus(4.2, a65, i65);
        }

        private void button65_plus_Click(object sender, RoutedEventArgs e)
        {

            if (a65 == 0) { i65 = i; i++; }

            if (a65 > 0)
            {

                ticket.RemoveAt(i65);
            }

            a65 = Convert.ToInt32(ilosc65.Text) + 1;
            ilosc65.Text = Convert.ToString(a65);

            ticket.Insert(i65, new Tickets() { liczba = a65, Name = "Ulgowy 24-godzinny wazny na linii nocnej, pospiesznej, specjalnej i zwyklej", cena = a65 * 3.2 });
            showTable();
            zaplata();

        }

    }
}


