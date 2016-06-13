using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using static System.Console;
using System.Windows.Forms;

namespace Task2
{
    public static class Push1
    {
        public static void Run()
        {
            var w = new Form();
            w.Text = "Push Example";
            w.Width = 800;
            w.Height = 600;


            
            IObservable<Point> moves = Observable.FromEventPattern<MouseEventArgs>(w, "MouseMove").Select(x => x.EventArgs.Location);
            //wenn die Maus bewegt wird, dann mach select (art von filter) filtert location
            moves
                .Throttle(TimeSpan.FromSeconds(0.5)) //hört auf Werte weiterzuleiten, wenn sie öfter als alle 0,5 Sekunden kommen
                .DistinctUntilChanged() //erst wenn etwas neues kommt, wird es durchgelassen
                .Subscribe(e => WriteLine($"[Mouse Event] ({e.X}, {e.Y})"))
                ;


            Application.Run(w);


        }
    }
}
