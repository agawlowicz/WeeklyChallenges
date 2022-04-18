using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
            => (numbers == null || numbers.Length == 0) ?
                0 : numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
            => new string[] { str1, str2, str3, str4 }.Min(x => x.Length);

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
            => new int[] { number1, number2, number3, number4 }.Min();

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
            => biz.Name = "TrueCoders";

        //Triangle Inequality Theorem
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
            => (sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2);

        public bool IsStringANumber(string input)
            => double.TryParse(input, out var result);

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
            => objs.Where(x => x == null).Count() > objs.Where(x => x != null).Count();

        public double AverageEvens(int[] numbers)
        {
            try
            { return numbers.Where(x => x % 2 == 0).Average(); }
            catch
            { return 0; }
        }

        public int Factorial(int number)
            => (number == 1 || number == 0) ? 1 : Enumerable.Range(1, number).ToList().Aggregate((x, y) => x * y);

    }
}
