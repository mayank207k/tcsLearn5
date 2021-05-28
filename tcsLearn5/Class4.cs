using System;
using System.Collections.Generic;
using System.Text;

namespace tcsLearn5
{
    public class Class4
    {
        public void divide()
        {
            Console.WriteLine("Enter the first number A:");
            var firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            var secondnumber = Convert.ToInt32(Console.ReadLine());
            if (secondnumber == 0)
            {
                Console.WriteLine("Divisor cannnot be 0 \nPLease Enter the valid input");
                divide();
            }
            else
            {
                Console.WriteLine("Result of division is {0} ", firstnumber / secondnumber);
                Console.WriteLine("Enter '5' if you want to continue or '9' to exit Divison");
                var counter = Convert.ToInt32(Console.ReadLine());
                if (counter == 5)
                {
                    divide();
                }
            }
        }
    }
}
