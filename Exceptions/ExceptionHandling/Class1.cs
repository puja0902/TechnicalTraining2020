using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    //EXAMPLE OF HANDLED EXCEPTION 
    class HandledException
    {
        public static void Main()
        {
            int x = 0;
            int intTemp = 0;
            try
            {
                intTemp = 100 / x;
                Console.WriteLine("Program terminated before this statement");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Division by Zero occurs");
            }
            finally
            {

                Console.WriteLine("Result is {0}", intTemp);
            }
        }

   
    }
}
