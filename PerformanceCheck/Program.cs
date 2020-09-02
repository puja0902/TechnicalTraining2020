using System;
using System.Diagnostics;

namespace PerformanceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            CheckPerformance();
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Restart();
            st.Start();
            CheckPerformance();
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Restart();
            st.Start();
            CheckPerformance();
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Restart();

            Console.WriteLine(st.ElapsedMilliseconds);
            Console.Read();
            Console.WriteLine("This is Main");
        }


        static void
        CheckPerformance()
        {
        for (int i=0; i<1000000; i++)
	        {
                int i1 = 10;
                object y1 = i;
             }

    }
}



    }
    

