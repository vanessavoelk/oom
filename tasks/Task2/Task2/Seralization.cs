using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
    class Serialization
    {
        public static void Run(IGerät[] items)
        {
            var computer = items[0];

           
            Console.WriteLine(JsonConvert.SerializeObject(computer));
            Console.WriteLine(JsonConvert.SerializeObject(computer, Formatting.Indented));

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(items, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IGerät[]>(textFromFile, settings);
           
            foreach (var x in itemsFromFile) Console.WriteLine($"{x.Gerätepreis} {x.Besitzername}");
        }
    }
}
