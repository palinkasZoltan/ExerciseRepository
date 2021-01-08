using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give in a number please : ");
            ConditionCheckers conditionC = new ConditionCheckers();
            int nr = 0;
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
        }
    }
}
