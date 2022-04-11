using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
            => char.IsLetter(c); // IsLetter method

        public bool CountOfElementsIsEven(string[] vals)
            => (vals.Count() % 2 == 0);

        public bool IsNumberEven(int number)
            => (number % 2 == 0);

        public bool IsNumberOdd(int num)
            => (num % 2 != 0);

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //Null check
            if (numbers == null || numbers.Count() == 0) { return 0; }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
            => (str1.Length < str2.Length) ? str1.Length : str2.Length;

        public int Sum(int[] numbers)
            => (numbers == null) ? 0 : numbers.Sum();

        public int SumEvens(int[] numbers)
            => (numbers == null) ? 0 : numbers.Where(x => x % 2 == 0).Sum();

        //Return if sum is odd if input not null
        public bool IsSumOdd(List<int> numbers)
            => (numbers == null) ? false : numbers.Sum() % 2 != 0;

        public long CountOfPositiveOddsBelowNumber(long number)
            => (number > 0) ? number/2 : 0;
    }
}
