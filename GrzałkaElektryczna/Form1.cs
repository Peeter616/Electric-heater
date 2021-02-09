using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrzałkaElektryczna
{
    public partial class Form1 : Form
    {
        Klawiatura klawiatura = new Klawiatura();
        Palenisko pal1 = new Palenisko();
        Palenisko pal2 = new Palenisko();
        Palenisko pal3 = new Palenisko();
        Palenisko pal4 = new Palenisko();
        int czasDziałania;
        double czasZaczęcia= DateTime.Now.ToOADate();
        public Form1()
        {
            InitializeComponent();
        }

        private void Wlwyl_Click(object sender, EventArgs e)
        {
            if (klawiatura.Wlaczone == true)
            {
                klawiatura.Wylacz(p1, p2, p3, p4);
                pal1.Stopień = 0;
                pal2.Stopień = 0;
                pal3.Stopień = 0;
                pal4.Stopień = 0;
                pal1.ustalTemperaturęKońcową();
                pal2.ustalTemperaturęKońcową();
                pal3.ustalTemperaturęKońcową();
                pal4.ustalTemperaturęKońcową(); //wylaczanie klawiatury urzadzenia oraz przeliczanie temperatur poszczegolnych palenisk
            }
            else if (klawiatura.Wlaczone == false)
                klawiatura.Wlaczone = true;
        }

        private void p1_Click(object sender, EventArgs e)
        {
            if (klawiatura.Wlaczone == true)
            {
                klawiatura.AktywnePalenisko_void(p1, p2, p3, p4, 1);
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (klawiatura.Wlaczone == true)
            {
                klawiatura.AktywnePalenisko_void(p2, p1, p3, p4, 2);
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (klawiatura.Wlaczone == true)
            {
                klawiatura.AktywnePalenisko_void(p3, p1, p2, p4, 3);
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (klawiatura.Wlaczone == true)
            {
                klawiatura.AktywnePalenisko_void(p4, p1, p2, p3, 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            klawiatura.WGore(pal1, pal2, pal3, pal4);
            switch (klawiatura.AktywnePalenisko)
            {
                case 1:
                    {
                        p1.Text = Convert.ToString(pal1.Stopień);
                        pal1.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 2:
                    {
                        p2.Text = Convert.ToString(pal2.Stopień);
                        pal2.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 3:
                    {
                        p3.Text = Convert.ToString(pal3.Stopień);
                        pal3.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 4:
                    {
                        p4.Text = Convert.ToString(pal4.Stopień);
                        pal4.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            klawiatura.WDol(pal1, pal2, pal3, pal4);
            switch (klawiatura.AktywnePalenisko)
            {
                case 1:
                    {
                        p1.Text = Convert.ToString(pal1.Stopień);
                        pal1.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 2:
                    {
                        p2.Text = Convert.ToString(pal2.Stopień);
                        pal2.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 3:
                    {
                        p3.Text = Convert.ToString(pal3.Stopień);
                        pal3.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
                case 4:
                    {
                        p4.Text = Convert.ToString(pal4.Stopień);
                        pal4.CzasWlaczenia = czasDziałania;//okresla moment zalaczenia urzadzenia - niezbedne do wzoru obliczajacego temperature chwilowa
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czasDziałania = Convert.ToInt32((DateTime.Now.ToOADate() - czasZaczęcia) * 100000);
            L1.Text = Convert.ToString(pal1.aktualnaTemperatura(czasDziałania - pal1.CzasWlaczenia));
            L2.Text = Convert.ToString(pal2.aktualnaTemperatura(czasDziałania - pal2.CzasWlaczenia));
            L3.Text = Convert.ToString(pal3.aktualnaTemperatura(czasDziałania - pal3.CzasWlaczenia));
            L4.Text = Convert.ToString(pal4.aktualnaTemperatura(czasDziałania - pal4.CzasWlaczenia));
            panel1.Refresh();
            if (pal1.Wlaczone == true)
                klawiatura.Rysujpalenisko(panel1, 37, 37, 250);
            if (pal2.Wlaczone == true)
                klawiatura.Rysujpalenisko(panel1, 362, 62, 200);
            if (pal3.Wlaczone == true)
                klawiatura.Rysujpalenisko(panel1, 62, 362, 200);
            if (pal4.Wlaczone == true)
                klawiatura.Rysujpalenisko(panel1, 387, 387, 150);
        }
    }
}
