using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

            Console.WriteLine($"Der Preis für das Servicepaket für Computer a  ist {a.Gerätepreis} EURO, und wird an {a.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {a.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer b  ist {b.Gerätepreis} EURO, und wird an {b.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {b.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer c  ist {c.Gerätepreis} EURO, und wird an {c.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {c.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer d  ist {d.Gerätepreis} EURO, und wird an {d.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {d.Endpreis()} ");

            a.Besitzerändern("Huber");
            Console.WriteLine($"Der Computer gehört {a.Besitzername}");

            Drucker e = new Drucker(89, 1);
            e.Besitzerändern("Mueller");
            Console.WriteLine($"Der Drucker e mit dem Preis {e.Gerätepreis} wird an {e.Besitzername} verkauft!");
            a.Servicepaket("SP1");

            var items = new IGerät[]
            {
            new Computer(499, 1),
            new Computer(599, 4),
            new Computer(699, 2),
            new Computer(799, 3),
            new Drucker(79, 1),
            new Drucker(89, 2),
            new Drucker(99, 5),
        };

        foreach(var x in items)
            {
                Console.WriteLine($"{x.Gerätepreis} ");
            }

            var computer = new Computer(399, 2);
            string s = JsonConvert.SerializeObject(computer);
            Console.WriteLine(s);
        }
    }
}
