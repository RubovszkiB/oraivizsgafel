using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleApp14.Models;

namespace ConsoleApp14
{

    public class Program
    {
        static List<Models.Hos> hosok = new List<Models.Hos>();
        static void Main(string[] args)
        {
            Beolvas();
            Kiir();
            Feladat3();
            Feladat4();
        }

        static void Kiir()
        {
            int darab = hosok.Count;
            foreach (var item in hosok)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void Feladat4()
        {
            int mini = 0;
          List<Models.Hos> hosok2 = new List<Models.Hos>();
            for (int i = 0; i < hosok.Count; i++)
            {
                if (hosok[i].ADlevel(5) < hosok[mini].ADlevel(5))
                {
                    mini = i;
                }
            }
            Console.WriteLine($"5. Feladat: 5. szinten a legkisebb sebzéssel rendelkező hős {hosok[mini].Name}; {hosok[mini].Attackdamage}");
        }
        static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Kérem adja meg a hős nevét (írja be: vége a kilépéshez):");
            while (true)
            {
                Console.Write("Hős neve: ");
                var bekert = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(bekert))
                {
                    Console.WriteLine("Üres bevitel. Próbálja újra.");
                    continue;
                }

                bekert = bekert.Trim();
                if (bekert.Equals("vége", StringComparison.OrdinalIgnoreCase))
                    break;

                var talalatok = hosok
                    .Where(h => string.Equals(h.Name, bekert, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (talalatok.Any())
                {
                    foreach (var h in talalatok)
                    {
                        Console.WriteLine($"{h.Name} {h.Title} {h.Category} {h.Tag} {h.HP} {h.Attackdamage} {h.Attackdamagelevel}");
                    }
                }
                else
                {
                    Console.WriteLine("Nincs ilyen hős!");
                }
            }
        }

        public static void Beolvas()
        {
            StreamReader sr = new StreamReader("champions2017_V4.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                hosok.Add(new Models.Hos(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}