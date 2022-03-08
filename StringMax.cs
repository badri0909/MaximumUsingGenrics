using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProblemUsingGenerics
{
    public class StringMax
    {
        public string MaximumString(string firstWord, string secondWord, string thirdWord)
        {
            if (firstWord.CompareTo(secondWord) > 0 && firstWord.CompareTo(thirdWord) > 0 ||
               firstWord.CompareTo(secondWord) >= 0 && firstWord.CompareTo(thirdWord) > 0 ||
               firstWord.CompareTo(secondWord) > 0 && firstWord.CompareTo(thirdWord) >= 0)
            {
                Console.WriteLine("Maximum Number: " + firstWord);

            }
            if (secondWord.CompareTo(firstWord) > 0 && secondWord.CompareTo(thirdWord) > 0 ||
               secondWord.CompareTo(firstWord) >= 0 && secondWord.CompareTo(thirdWord) > 0 ||
               secondWord.CompareTo(firstWord) > 0 && secondWord.CompareTo(thirdWord) >= 0)
            {
                Console.WriteLine("Maximum Number: " + secondWord);
            }
            if (thirdWord.CompareTo(firstWord) > 0 && thirdWord.CompareTo(secondWord) > 0 ||
               thirdWord.CompareTo(firstWord) >= 0 && thirdWord.CompareTo(secondWord) > 0 ||
               thirdWord.CompareTo(firstWord) > 0 && thirdWord.CompareTo(secondWord) >= 0)
            {
                Console.WriteLine("Maximum Number: " + thirdWord);
            }
            return firstWord;
        }
    }
}