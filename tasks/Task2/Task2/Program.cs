using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Reactive.Linq;
using System.Reactive.Subjects;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer a = new Computer(499, 1, "Huber");
            Computer b = new Computer(599, 4, "Mueller");
            Computer c = new Computer(699, 5, "Bauer");
            Computer d = new Computer(799, 3, "Franz");

            Console.WriteLine($"Der Preis für das Servicepaket für Computer a  ist {a.Gerätepreis} EURO, und wird an {a.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {a.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer b  ist {b.Gerätepreis} EURO, und wird an {b.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {b.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer c  ist {c.Gerätepreis} EURO, und wird an {c.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {c.Endpreis()} ");
            Console.WriteLine($"Der Preis für das Servicepaket für Computer d  ist {d.Gerätepreis} EURO, und wird an {d.Anzahl} Computer(n) ausgeführt und der Gesamtpreis dafür ist {d.Endpreis()} ");
              

            Console.WriteLine($"Der Computer gehört {a.Besitzername}");
            a.Besitzerändern("Huber");
            Console.WriteLine($"Der Computer gehört {a.Besitzername}");

            Drucker e = new Drucker(89, 1, "Huber");
            e.Besitzerändern("Mueller");
            Console.WriteLine($"Der Drucker e mit dem Preis {e.Gerätepreis} wird an {e.Besitzername} verkauft!");
            a.Servicepaket("SP1");

           var items = new IGerät[]
            {
            new Computer(499, 1, "Huber"),
            new Computer(599, 4, "Mueller"),
            new Computer(699, 2, "Franz"),
            new Computer(799, 3, "Bauer"),
            new Drucker(79, 1, "Gutherr"),
            new Drucker(89, 2, "Fritz"),
            new Drucker(99, 5, "Mauau"),

        };

            foreach (var x in items)
            {
                Console.WriteLine($"Gerätepreis: {x.Gerätepreis} \nBesitzername: {x.Besitzername}\n");
            }

            
            string s = JsonConvert.SerializeObject(items);
            Console.WriteLine(s);

            Serialization.Run(items);

           

            Pull.Run();

            Push.Run();

            Push1.Run();

            //Push2.Run();
            Push3.Run();
            
            Rx.Run();

            Async.MyAsync().ContinueWith((t)=>Console.WriteLine($"Ende")).Wait();
            

        }
    }
}
