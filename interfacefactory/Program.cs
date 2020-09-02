using System;


namespace interfacefactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITax t = Factory.Create(1);
            t = Factory.Create(0);



            t.Calculate();

        }
    }
}
