using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class RandomStar : Star
    {
        private readonly Random _random;

        public RandomStar()
        {
            _pattern = "xzy";
            _random = new Random();
        }

        public override void Show()
        {
            Console.WriteLine(_pattern[_random.Next(0, _pattern.Length)]);
        }
    }
}
