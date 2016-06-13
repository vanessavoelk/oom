using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Pull
    {
        public static void Run()
        {
            var liste = new List<Computer> { };

            liste.Add(new Computer(55, 2, "Huber"));
            liste.Add(new Computer(65, 1, "Mueller"));
            liste.Add(new Computer(75, 4, "Bauer"));
            liste.Add(new Computer(85, 7, "Gruber"));
            liste.Add(new Computer(95, 1, "Franz"));

            var i = liste.GetEnumerator();
            while (i.MoveNext()) Console.WriteLine($"{i.Current} - Gerätepreis: {i.Current.Gerätepreis}, Besitzer: {i.Current.Besitzername}");

            var liste2= liste.Where((x) => x.Anzahl > 2); //Ausschnitt von erster Liste


               
                }
    }
}
