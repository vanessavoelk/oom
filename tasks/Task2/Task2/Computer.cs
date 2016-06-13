using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Computer : IGerät
    {
        private int anzahl;

        private double gerätepreis;
        private double umsatz; 
        private string besitzername;

        private double Umsatz
        {
            get
            {
                umsatz = gerätepreis / 1.2;
                return umsatz;
            }
        }

        public string Besitzername
        {
            get
            {
                return besitzername;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Familienname darf nicht leer sein!");
                besitzername = value;
            }
        }

        
       
         public double Gerätepreis
        {
            get 
            {
                return gerätepreis;
            }
            set
            {
                if (value < 0) throw new Exception("Preis kann nicht negativ sein!");
                gerätepreis = value;
            }
        }

        public int Anzahl
        {
            get
            {
                return anzahl;
            }
            set
            {
                if (value < 0) throw new Exception("Anzahl kann nicht negativ sein!");
                anzahl = value;
            }
        }

        public void Besitzerändern(string Nachname)
        {
            if (string.IsNullOrWhiteSpace(Nachname)) throw new ArgumentException("Familienname darf nicht leer sein!");
            besitzername = Nachname;
        }

        public double Endpreis()
        {
            return (anzahl * gerätepreis);
        }

        public void Servicepaket(string Paketname)
        {
            Console.WriteLine($"Mein Computer bekommt das Servicepaket " + Paketname);
            
        }
        
        
      
        public Computer(double Gerätepreis, int Anzahl, string Besitzername)
        {
            if (Gerätepreis < 0) throw new ArgumentOutOfRangeException("Preis kann nicht negativ werden!");
            if (Anzahl < 0) throw new ArgumentOutOfRangeException("Anzahl kann nicht negativ werden!");
            if(string.IsNullOrWhiteSpace(Besitzername)) throw new ArgumentException("Familienname darf nicht leer sein!");
            gerätepreis = Gerätepreis;
            anzahl = Anzahl;
            besitzername = Besitzername;
        }
    }
}
