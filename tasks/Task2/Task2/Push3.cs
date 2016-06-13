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
    public static class Push3
    {
        public static void Run()
        {
            var producer = new Subject<int>();

            producer.Subscribe(x => Console.WriteLine($"received value {x}"));

            for (var i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); //schläft für 1 Sekunde
                producer.OnNext(i); // pusht den Wert von i zu subscribers
            }
        }
    }
}
