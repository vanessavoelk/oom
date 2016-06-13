﻿using System;
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
    public static class Push
    {
        public static void Run()
        {
            var w = new Form();
             w.Text = "Push Example";
             w.Width = 800;
             w.Height = 600;

             
             w.MouseMove += (s, e) => WriteLine($"[MouseMove event] ({e.X},{e.Y})");

            IObservable<Point> moves = Observable.FromEventPattern<MouseEventArgs>(w, "MouseMove").Select(x => x.EventArgs.Location);

            Application.Run(w);


        }
    }
}
