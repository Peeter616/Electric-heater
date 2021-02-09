using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrzałkaElektryczna
{
    class Palenisko : Grzałka
    {
        int stopień;
        float średnica;
        double moc;
        double poprzedniaTemperatura;
        int czasWlaczenia;
        bool wlaczone = false;
        public Palenisko(double moc = 1000, float średnica = 5) : base() //deklaracja paleniska, po znaku równości domyślne wartości, inicjowany w konstruktorze rodzica
        {
            stopień = 0;
            this.średnica = średnica;
            this.moc = moc;
        }
        public Palenisko(int stopień) : this()//konstruktor przeciążony inicjowany w konstruktorze podstawowym
        {
            this.stopień = stopień;
        }

        /// <summary>
        /// gettery,settery
        /// </summary>

        public int Stopień
        {
            get
            {
                return stopień;
            }
            set
            {
                stopień = value;
            }
        }
        public float Średnica
        {
            get
            {
                return średnica;
            }
        }
        public double Moc
        {
            get
            {
                return moc;
            }
        }
        public int CzasWlaczenia
        {
            get
            {
                return czasWlaczenia;
            }
            set
            {
                czasWlaczenia = value;
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

        public void ustalTemperaturęKońcową()
        {
            temperaturaKońcowa = Stopień * 20;
        }
        void ustalStałąTemperatury()
        {
            stałaTemperatury = Średnica * 1000 / Moc; //wzór na stałą czasową wykorzystywaną do dalszych obliczeń
        }
        override public double aktualnaTemperatura(double czas)//funkcja licząca aktualną temperaturę - jest to funkcja nadpisująca funkcję rodzica
        {
            ustalTemperaturęKońcową();
            ustalStałąTemperatury();
            if (stałaTemperatury > czas)
            {
                temperatura = poprzedniaTemperatura + (temperaturaKońcowa - poprzedniaTemperatura ) * (1 - Math.Pow(Math.E, -(czas / stałaTemperatury))); //wzór na temperaturę chwilową
                poprzedniaTemperatura = temperatura;
            }
            else
            {
                temperatura = temperaturaKońcowa;//w momencie ustalenia temperatury, temperatura końcowa = temperatura aktualna
                poprzedniaTemperatura = temperatura;
            }
            return temperatura;
        }

        /// <summary>
        /// funkcje klasy
        /// </summary>
        
    }
}
