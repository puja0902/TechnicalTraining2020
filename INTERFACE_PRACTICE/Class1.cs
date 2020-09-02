using System;

namespace INTERFACE_PRACTICE
{
   

public interface ITax
        {
            decimal Calculate();
        }
 public interface Payroll
    {
        decimal CalPayroll();
    }
    // multiple interfaces
    public class Gst : ITax, Payroll
        {
            public decimal Amount { get; set; }
            public decimal Calculate() // public vocabulary
            {
                // changing the beavh
                return Amount * (10 / 100); // bug
            }

        public decimal CalPayroll() // public vocabulary
        {
            // changing the beavh
            return Amount * (10 *100); // bug
        }

        public decimal CalculateTDS()
            {
                return 0;


            }
        }


        public class Tds : ITax
        {
            public decimal Calculate()
            {
                throw new NotImplementedException();
            }
        }


        public static class Factory
        {
            public static ITax Create(int i)
            {
                if (i == 0)
                {
                    return new Gst();
                }
                else
                {
                    return new Tds();
                }


            }

            public static class globalvalue
            {
            static int counter = 0;
            public static int increment()
            {
                return counter++;

            }
            }
        }








    }

