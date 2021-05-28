using System;
using System.Collections.Generic;
using System.Text;

namespace tcsLearn5
{
    public class Class1
    {
        public void Add()
        {
            Console.WriteLine("Enter the first number A:");
            var firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            var secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of Addition is {0} ", firstnumber + secondnumber);
            Console.WriteLine("Enter '5' if you want to continue or '9' to exit Addition");
            var counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 5)
            {
                Add();
            }
        }
    }
}
