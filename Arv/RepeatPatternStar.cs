using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    abstract class RepeatPatternStar : Star
    {
        private int _index = 0;

        public override void Show()
        {
            Console.WriteLine(NextChar());
        }

        private char NextChar()
        {
            _index = (_index + 1) % _pattern.Length;
            var c = _pattern[_index];
            return c;
        }
    }
}
