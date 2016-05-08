using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer a = new Computer(499, 1);
            Computer b = new Computer(599, 4);
            Computer c = new Computer(699, 2);
            Computer d = new Computer(799, 3);

            Console.WriteLine($"Der Preis von Computer a  ist {a.Preis} EURO, ihn gibt es {a.Anzahl} mal und der Gesamtpreis dafür ist {a.Endpreis()} ");
            Console.WriteLine($"Der Preis von Computer b  ist {b.Preis} EURO, ihn gibt es {b.Anzahl} mal und der Gesamtpreis dafür ist {b.Endpreis()} ");
            Console.WriteLine($"Der Preis von Computer c  ist {c.Preis} EURO, ihn gibt es {c.Anzahl} mal und der Gesamtpreis dafür ist {c.Endpreis()} ");
            Console.WriteLine($"Der Preis von Computer d  ist {d.Preis} EURO, ihn gibt es {d.Anzahl} mal und der Gesamtpreis dafür ist {d.Endpreis()} ");

        }
    }
}
