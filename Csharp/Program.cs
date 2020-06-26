using System;

namespace Csharp
{
    class MainClass
    {
        string Using;
        string Computer;
        string Reference;

        public static void Main(string[] args)
        {
            EmptyClass.func1();

            //put bio

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("user test? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    crudtest.Bio();
                    i++;
                    continue;
                }
                else
                {
                    break;
                }
                
            }

            //math test

            while (i < 5)
            {
                Console.WriteLine("math test? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    counting.math();
                    i++;
                    continue;
                }
                else
                {
                    break;
                }

            }

            //credit to
            MainClass atHome = new MainClass();
            atHome.Using = "visual studio";
            atHome.Reference = "w3schools";
            atHome.Computer = "macbook";
            Console.WriteLine("At Home using " + atHome.Using + " with reference from " + atHome.Reference + " computer is : " + atHome.Computer);

            MainClass atWork = new MainClass();
            atWork.Using = "visual studio";
            atWork.Reference = "w3schools";
            atWork.Computer = "dont know";
            Console.WriteLine("At Work using " + atWork.Using + " with reference from " + atWork.Reference);
            Console.WriteLine(" computer is : " + atWork.Computer);

        }
    }
}