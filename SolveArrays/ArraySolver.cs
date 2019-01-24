using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;

            foreach (var number in numbers)
            {
                total = total + number;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
           
        }

        public double AverageEvens(int[] numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
