using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IGerät
    {
        //Servicepaketbeschreibung
        string Besitzername { get; }
                
        double Gerätepreis { get; }
        
    }
}
