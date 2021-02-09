using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrzałkaElektryczna
{
    class Klawiatura
    {
        bool wlaczone;
        int aktywnePalenisko;
        public Klawiatura(bool wlaczone = false, int aktywnePalenisko = 0)
        {
            this.wlaczone = wlaczone;
            this.aktywnePalenisko = aktywnePalenisko;
        } //konstruktor z domyślnymi danymi

        /// <summary>
        /// gettery,settery
        /// </summary>

        public int AktywnePalenisko
        {
            get
            {
                return aktywnePalenisko;
            }
            set
            {
                aktywnePalenisko = value;
            }
        }
        public bool Wlaczone
        {
            get
            {
                return wlaczone;
            }
            set
            {
                wlaczone = value;
            }
        }

        /// <summary>
        /// gettery,settery
        /// </summary>

        /// <summary>
        /// funkcje klasy
        /// </summary>

        public void AktywnePalenisko_void(Button aktywny, Button pasywny1, Button pasywny2, Button pasywny3, int aktywnePalenisko)//funkcja podświetlająca przcisk aktualnego paleniska oraz ustawiania wartości pola aktualne palenisko
        {
            if (aktywnePalenisko == AktywnePalenisko)
            {
                aktywny.ForeColor = Color.Black;
                pasywny1.ForeColor = Color.Black;
                pasywny2.ForeColor = Color.Black;
                pasywny3.ForeColor = Color.Black;
                AktywnePalenisko = 0;
            }
            else
            {
                aktywny.ForeColor = Color.DarkGray;
                pasywny1.ForeColor = Color.Black;
                pasywny2.ForeColor = Color.Black;
                pasywny3.ForeColor = Color.Black;
                AktywnePalenisko = aktywnePalenisko;
            }
        }
        public void Wylacz(Button p1, Button p2, Button p3, Button p4)//Wyłączanie panelu
        {
            Wlaczone = false;
            p1.ForeColor = Color.Black;
            p2.ForeColor = Color.Black;
            p3.ForeColor = Color.Black;
            p4.ForeColor = Color.Black;
            p1.Text = "0";
            p2.Text = "0";
            p3.Text = "0";
            p4.Text = "0";
            AktywnePalenisko = 0;
        }
        public void WGore(Palenisko pal1, Palenisko pal2, Palenisko pal3, Palenisko pal4)//funkcja przesuwająca stopień na interfejsie w góre
        {
            switch (AktywnePalenisko)
            {
                case 0:
                    break;
                case 1:
                    if (pal1.Stopień < 9)
                    {
                        pal1.Stopień++;
                        pal1.ustalTemperaturęKońcową();
                        pal1.Wlaczone = true;
                    }
                    else
                    {
                        pal1.Stopień = 0;
                        pal1.ustalTemperaturęKońcową();
                        pal1.Wlaczone = false;
                    }
                    break;
                case 2:
                    if (pal2.Stopień < 9)
                    {
                        pal2.Stopień++;
                        pal2.ustalTemperaturęKońcową();
                        pal2.Wlaczone = true;
                    }
                    else
                    {
                        pal2.Stopień = 0;
                        pal2.ustalTemperaturęKońcową();
                        pal2.Wlaczone = false;
                    }
                    break;
                case 3:
                    if (pal3.Stopień < 9)
                    {
                        pal3.Stopień++;
                        pal3.ustalTemperaturęKońcową();
                        pal3.Wlaczone = true;
                    }
                    else
                    {
                        pal3.Stopień = 0;
                        pal3.ustalTemperaturęKońcową();
                        pal3.Wlaczone = false;
                    }
                    break;
                case 4:
                    if (pal4.Stopień < 9)
                    {
                        pal4.Stopień++;
                        pal4.ustalTemperaturęKońcową();
                        pal4.Wlaczone = true;
                    }
                    else
                    {
                        pal4.Stopień = 0;
                        pal4.ustalTemperaturęKońcową();
                        pal4.Wlaczone = false;
                    }
                    break;
                default:
                    break;
            }
        }
        public void WDol(Palenisko pal1, Palenisko pal2, Palenisko pal3, Palenisko pal4)//funkcja przesuwająca stopień na interfejsie w dół
        {
            switch (AktywnePalenisko)
            {
                case 0:
                    break;
                case 1:
                    if (pal1.Stopień > 0)
                    {
                        pal1.Stopień--;
                        pal1.ustalTemperaturęKońcową();
                        if (pal1.Stopień == 0)
                            pal1.Wlaczone = false;
                    }
                    else
                    {
                        pal1.Stopień = 9;
                        pal1.ustalTemperaturęKońcową();
                        pal1.Wlaczone = true;
                    }
                    break;
                case 2:
                    if (pal2.Stopień > 0)
                    {
                        pal2.Stopień--;
                        pal2.ustalTemperaturęKońcową();
                        if (pal2.Stopień == 0)
                            pal2.Wlaczone = false;
                    }
                    else
                    {
                        pal2.Stopień = 9;
                        pal2.ustalTemperaturęKońcową();
                        pal2.Wlaczone = true;
                    }
                    break;
                case 3:
                    if (pal3.Stopień > 0)
                    {
                        pal3.Stopień--;
                        pal3.ustalTemperaturęKońcową();
                        if (pal3.Stopień == 0)
                            pal3.Wlaczone = false;
                    }
                    else
                    {
                        pal3.Stopień = 9;
                        pal3.ustalTemperaturęKońcową();
                        pal3.Wlaczone = true;
                    }
                    break;
                case 4:
                    if (pal4.Stopień > 0)
                    {
                        pal4.Stopień--;
                        pal4.ustalTemperaturęKońcową();
                        if (pal4.Stopień == 0)
                            pal4.Wlaczone = false;
                    }
                    else
                    {
                        pal4.Stopień = 9;
                        pal4.ustalTemperaturęKońcową();
                        pal4.Wlaczone = true;
                    }
                    break;
                default:
                    break;
            }
        }
        public void Rysujpalenisko(Panel panel1, int x, int y, float średnica) //rysowanie obrysów paleniska
        {
                Pen pioro = new Pen(Color.Red, 5);
                Graphics g = panel1.CreateGraphics();
                g.DrawEllipse(pioro, x, y, średnica, średnica);
        }
    }
    /// <summary>
    /// funkcje klasy
    /// </summary>
}

