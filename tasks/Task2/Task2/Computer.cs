using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Computer
    {
        public decimal m_servicepreis;
        public int m_anzahl=0;
        private int m_Umsatz;
      

        public decimal Preis
        {
            get //Ausgeführt wenn Wert gelesen wird
            {
                return m_servicepreis;
            }
            set
            {
                if (value < 0) throw new Exception("Preis kann nicht negativ sein!");
                m_servicepreis = value;
            }
        }

        public int Anzahl
        {
            get
            {
                return m_anzahl;
            }
            set
            {
                if (value < 0) throw new Exception("Anzahl kann nicht negativ sein!");
                m_anzahl = value;
            }
        }

        public decimal Endpreis()
        {
            return (m_anzahl * m_servicepreis);
        }

        public Computer(decimal newm_servicepreis, int newm_anzahl)
        {
            if (newm_servicepreis < 0) throw new ArgumentOutOfRangeException("Preis kann nicht negativ werden!");
            if (newm_anzahl < 0) throw new ArgumentOutOfRangeException("Anzahl kann nicht negativ werden!");
            m_servicepreis = newm_servicepreis;
            m_anzahl = newm_anzahl; //warum bleibt der Lagerstand 1??
        }
    }
}
