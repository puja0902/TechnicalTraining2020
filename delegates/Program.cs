using System;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParser p = new FileParser();
            p.ppointer += display;
            p.ppointer += display1;
            Task t = new Task(p.Parse);
            t.Start();
            Console.WriteLine("This is main");
            Console.Read();


        }
        static void display(int i)
        {
            Console.WriteLine("One" + i);
        }
        static void display1(int i)
        {
            Console.WriteLine("Second" + i);
        }



    }

    public class File FileParser 
        
        public delegate void parsepointer
        
        public parsepointer ppointer;
    public void Parse()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(2000);
            ppointer.invoke(i);

        }
    }
}

