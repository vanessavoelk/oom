using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Drucker : IGerät
    {
        public int m_anzahl;

        public double m_gerätepreis;
        private double m_Umsatz;
        public string m_besitzername;

        private double Umsatz
        {
            get
            {
                m_Umsatz = m_gerätepreis / 1.2;
                return m_Umsatz;
            }
        }

        public string Besitzername
        {
            get
            {
                return m_besitzername;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(m_besitzername)) throw new ArgumentException("Familienname darf nicht leer sein!");
                m_besitzername = value;
            }
        }

        public void Besitzerändern(string Nachname)
        {
            if (string.IsNullOrWhiteSpace(Nachname)) throw new ArgumentException("Familienname darf nicht leer sein!");
            m_besitzername = Nachname;
        }

        public double Gerätepreis
        {
            get
            {
                return m_gerätepreis;
            }
            set
            {
                if (value < 0) throw new Exception("Preis kann nicht negativ sein!");
                m_gerätepreis = value;
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

        public double Endpreis()
        {
            return (m_anzahl * m_gerätepreis);
        }

        
        public Drucker(double newm_servicepreis, int newm_anzahl)
        {
            if (newm_servicepreis < 0) throw new ArgumentOutOfRangeException("Preis kann nicht negativ werden!");
            if (newm_anzahl < 0) throw new ArgumentOutOfRangeException("Anzahl kann nicht negativ werden!");
            m_gerätepreis = newm_servicepreis;
            m_anzahl = newm_anzahl;
        }
    }
}
