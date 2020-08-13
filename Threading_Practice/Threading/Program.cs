using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);
            obj1.Start();
            obj2.Start();
        }

        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is function1"+ i.ToString());
                Thread.Sleep(1000);

            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is function2" + i.ToString());
                Thread.Sleep(1000);

            }
        }
    }
}
