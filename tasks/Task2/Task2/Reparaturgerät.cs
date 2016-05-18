using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface Reparaturgerät
    {
        //Servicepaketbeschreibung
        string Geräteservicepaket { get; }

        decimal GetServicepreis(Preisliste Preis);
                
    }
}
