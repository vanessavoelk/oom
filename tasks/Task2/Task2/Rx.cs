using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace Task2
{
    public static class Rx
    {
        public static void Run()
        {
            Subject<Computer> Rx = new Subject<Computer>();

            Rx.Where(x => x.Anzahl > 2).Subscribe((x) => Console.WriteLine($"Hier Computer {x.Besitzername}")); //was er tun soll wenn er ein objekt krieg

            Task.Run(() =>
            {
                Task.Delay(5000).Wait(); 
                Rx.OnNext(new Computer(466, 1, "Hans"));
                Rx.OnNext(new Computer(399, 2, "Klaus"));
                Rx.OnNext(new Computer(499, 5, "Bauer"));
                Rx.OnNext(new Computer(549, 6, "Mueller"));
                Rx.OnNext(new Computer(899, 7, "Franz"));
                Rx.OnNext(new Computer(299, 1, "Huber"));

            }); //füllt das in einen neuen Task und macht es nebenbei


        }
    }
}
