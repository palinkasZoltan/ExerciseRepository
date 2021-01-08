using System;
using System.Collections.Generic;
using System.Text;

namespace GitExercise
{
    class ConditionCheckers
    {
        public bool IsItEven(int number) => number % 2 == 0;

        public bool IsItDivisibleByFive(int number) => number % 5 == 0;
    }
}
