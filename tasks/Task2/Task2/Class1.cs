using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Computer
    {
        private decimal m_preis;
        private int m_anzahl=0;
        

        public decimal Preis
        {
            get //Ausgeführt wenn Wert gelesen wird
            {
                return m_preis;
            }
            set
            {
                if (value < 0) throw new Exception("Preis kann nicht negativ sein!");
                m_preis = value;
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
            return (m_anzahl * m_preis);
        }

        public Computer(decimal newm_preis, int newm_anzahl)
        {
            if (newm_preis < 0) throw new ArgumentOutOfRangeException("Preis kann nicht negativ werden!");
            if (newm_anzahl < 0) throw new ArgumentOutOfRangeException("Anzahl kann nicht negativ werden!");
            m_preis = newm_preis;
            m_anzahl = newm_anzahl; //warum bleibt der Lagerstand 1??
        }
    }
}
