using System;
using System.Collections.Generic;
using System.Text;

namespace tcsLearn5
{
    public class Class2
    {
        public void subtract()
        {
            var sub =0;
            Console.WriteLine("Enter the first number A:");
            var firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            var secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
                sub = firstnumber - secondnumber;
            else
                sub = secondnumber - firstnumber;
            Console.WriteLine("Result of Addition is {0} ", sub);
            Console.WriteLine("Enter '5' if you want to continue or '9' to exit subtraction");
            var counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 5)
            {
                subtract();
            }
        }
    }
}
