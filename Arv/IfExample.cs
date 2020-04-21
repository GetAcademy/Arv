using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class IfExample
    {
        public static void Main()
        {
            A a = new A();
            a.Show();
            //if (a.Type == "X")
            //{
            //    Console.WriteLine("Gjøre en ting");
            //}
            //else
            //{
            //    Console.WriteLine("Gjøre en annen ting");
            //}
        }
    }

    abstract class A
    {
        public string Type;

        public abstract void Show();
    }

    class AX : A
    {
        public override void Show()
        {
            Console.WriteLine("Gjøre en ting");
        }
    }

    class AY : A
    {
        public override void Show()
        {
            Console.WriteLine("Gjøre en annen ting");
        }
    }
}
