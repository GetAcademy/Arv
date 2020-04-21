using System;
using System.Collections.Generic;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = new List<Star>();
            stars.Add(new MyStar());
            stars.Add(new YourStar());
            stars.Add(new RandomStar());

            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                }
                Console.ReadLine();
            }


            //Dyr d;

            //var b = new Blekksprut();
            //b.Dø();

            //d = b;
            //Blekksprut b2 = (Blekksprut)d;
            //b2.SpruteBlekk();
        }
    }
}
