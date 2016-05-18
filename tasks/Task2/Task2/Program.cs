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

            Console.WriteLine($"Der Preis für das Servicepaket für Computer a  ist {a.Preis} EURO, und wird an {a.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {a.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer b  ist {b.Preis} EURO, und wird an {b.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {b.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer c  ist {c.Preis} EURO, und wird an {c.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {c.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer d  ist {d.Preis} EURO, und wird an {d.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {d.Endpreis()} ");

            
        }
    }
}
