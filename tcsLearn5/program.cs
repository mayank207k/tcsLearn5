using System;

namespace tcsLearn5
{

    public class program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Creation of Class Object

                //Entering Choices for Calculator
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                Console.WriteLine("Enter your choice from 1-4 to perform action");
                var ch = Console.ReadLine();
                var choice = Convert.ToInt16(ch);

                do
                {
                    switch (choice)
                    {
                        case 1:
                            Class1 obj1 = new Class1();
                            obj1.Add();
                            break;

                        case 2:
                            Class2 obj2 = new Class2();
                            obj2.subtract();
                            break;

                        case 3:
                            Class3 obj3 = new Class3();
                            obj3.multiply();
                            break;

                        case 4:
                            Class4 obj4 = new Class4();
                            obj4.divide();
                            break;

                        default:
                            Console.WriteLine("Please Enter valid input");
                            break;
                    }
                    Console.WriteLine("Enter Your choice as below");
                    Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                    ch = Console.ReadLine();
                    choice = Convert.ToInt16(ch);
                } while (choice != 0);
                Console.WriteLine("Thank for using Calculator");
            }
            catch (Exception)
            {
                Console.WriteLine(" Sorry Something went wrong, Please try again later");
            }
        }
    }
}
