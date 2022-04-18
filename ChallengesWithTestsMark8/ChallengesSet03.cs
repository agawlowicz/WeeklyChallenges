using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
            => vals.Contains(false);

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            => (numbers == null) ? false : numbers.Sum() % 2 != 0;

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isDigit = false;

            for(int i = 0; i < password.Length; i++)
            {
                if(char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if(char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsDigit(password[i]))
                {
                    isDigit = true;
                }
            }

            return (isLower && isUpper && isDigit) ? true : false;
        }

        public char GetFirstLetterOfString(string val)
            => val.First();

        public char GetLastLetterOfString(string val)
            => val.Last();

        public decimal Divide(decimal dividend, decimal divisor)
            => (divisor == 0) ? 0 : dividend / divisor;

        public int LastMinusFirst(int[] nums)
            => nums.Last() - nums.First();

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        // => words.ToList().ForEach(x => x.ToUpper()).ToArray();
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
