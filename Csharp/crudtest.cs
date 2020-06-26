using System;

namespace Csharp
{
    public class crudtest
    {
        public static void Bio()
        {
            Console.WriteLine("username :");
            string userName = Console.ReadLine();

            Console.WriteLine("age :");
            string age = Console.ReadLine();
            int num = -1;
            if (!int.TryParse(age, out num))
            {
                Console.WriteLine("Not a number");
            }
            else
            {
                call(userName, age);
                Okorno();
            }
        }

        static void call(string name, string age)
        {
            Console.WriteLine("Username is: " + name);
            Console.WriteLine("Age is: " + age);
        }

        static void Okorno()
        {
            Console.WriteLine("is it okay? (y/n)");
            string answer = Console.ReadLine();

            string result = (answer == "y") ? "Good" : "welp";
            Console.WriteLine(result);
        }
    }
}
