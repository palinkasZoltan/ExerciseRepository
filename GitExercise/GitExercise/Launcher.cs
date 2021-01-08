using System;
using System.Collections.Generic;
using System.Text;

namespace GitExercise
{
    static class Launcher
    {
        static ConditionCheckers conditionC = new ConditionCheckers();

        public static void Launch()
        {
            Console.WriteLine("Give in a number please : ");
            int nr;
            while (!int.TryParse(Console.ReadLine(), out nr))
            {
                Console.WriteLine("Give in a correct value!");
            }
            if (conditionC.IsItEven(nr))
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is not even!");
            }
            if (conditionC.IsItDivisibleByFive(nr))
            {
                Console.WriteLine("This number is divisible by 5.");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 5.");
            }

        }
    }
}
