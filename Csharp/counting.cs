using System;

namespace Csharp
{
    public class counting
    {
        public static void math()
        {
            Console.WriteLine("please put number only");

            Console.WriteLine("1st num :");
            string first = Console.ReadLine();
            int one = Convert.ToInt32(first);

            Console.WriteLine("2nd num :");
            string second = Console.ReadLine();
            int two = Convert.ToInt32(second);

            Console.WriteLine("what do you want to do? (plus/minus/divide/multiply)");
            string answer = Console.ReadLine();

            if(answer == "plus")
            {
                char sign = '+';
                int result = one + two;
                Console.WriteLine(one + " " + sign + " " + two + " = " + result);
            }
            if (answer == "minus")
            {
                char sign = '-';
                int result = one - two;
                Console.WriteLine(one + " " + sign + " " + two + " = " + result);
            }
            if (answer == "divide")
            {
                char sign = '/';
                int result = one / two;
                Console.WriteLine(one + " " + sign + " " + two + " = " + result);
            }
            if (answer == "multiply")
            {
                char sign = '*';
                int result = one * two;
                Console.WriteLine(one + " " + sign + " " + two + " = " + result);
            }
            else
            {
                Console.WriteLine("try again");
            }
        }
    }
}
