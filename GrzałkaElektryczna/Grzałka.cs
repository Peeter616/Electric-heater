using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GrzałkaElektryczna
{
    abstract class Grzałka
    {
        protected double temperatura;
        protected double temperaturaKońcowa;
        protected double stałaTemperatury;
        public Grzałka(double temperatura = 0, double temperaturaKońcowa = 0, double stałaTemperatury = 5) //konstruktor klasy z domyślnymi wartościami
        {
            this.temperatura = temperatura;
            this.temperaturaKońcowa = temperaturaKońcowa;
            this.stałaTemperatury = stałaTemperatury;
        }

        /// <summary>
        /// gettery,settery
        /// </summary>

        public double Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                temperatura = value;
            }
        }
        public double TemperaturaKońcowa
        {
            get
            {
                return temperaturaKońcowa;
            }
            set
            {
                temperaturaKońcowa = value;
            }
        }
        public double StałaTemperatury
        {
            get
            {
                return stałaTemperatury;
            }
        }

        /// <summary>
        /// gettery,settery
        /// </summary>

        /// <summary>
        /// funkcje klasy
        /// </summary>

        public void dane()
        {

            System.Windows.Forms.MessageBox.Show("Aktualna temperatura = " + Temperatura);
        }//funkcja wyświetlające aktualne dane nt urzadzenia
        abstract public double aktualnaTemperatura(double czas);//funkcja licząca aktualną temperaturę - jest to funkcja abstrakcyjna ponieważ wzór bedzie inaczej wyglądał dla różnych obiektów

        /// <summary>
        /// funkcje klasy
        /// </summary>
 
    }
}
