using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return (alphabet.Contains(char.ToLower(c)));
        }

        public bool CountOfElementsIsEven(string[] vals)
            => (vals.Count() % 2 == 0);

        public bool IsNumberEven(int number)
            => (number % 2 == 0) ? true : false;

        public bool IsNumberOdd(int num)
            => (num % 2 != 0) ? true : false;

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0) { return 0; }
            else { return numbers.Min() + numbers.Max(); }
        }

        public int GetLengthOfShortestString(string str1, string str2)
            => (str1.Length < str2.Length) ? str1.Length : str2.Length;

        public int Sum(int[] numbers)
            => (numbers == null) ? 0 : numbers.ToList().Sum();
           // => (numbers.Length = 0)numbers.ToList().Sum();

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            else { return numbers.Where(x => x % 2 == 0).Sum(); }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            else { return (numbers.Sum() % 2 != 0) ? true : false; }
        }
            //=> (numbers.Sum() % 2 != 0 || numbers != null) ? true : false;

        public long CountOfPositiveOddsBelowNumber(long number)
            => (number > 0) ? number/2 : 0;
    }
}
