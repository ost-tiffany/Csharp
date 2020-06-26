using System;

namespace Csharp
{
    class MainClass
    {
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

        }
    }
}