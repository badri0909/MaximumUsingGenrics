using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProblemUsingGenerics
{
    public class FloatMax
    {
        public double MaximumFloatNum(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 ||
               firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 ||
               firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                Console.WriteLine("Maximum Number: " + firstNum);

            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 ||
               secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 ||
               secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                Console.WriteLine("Maximum Number: " + secondNum);
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0 ||
               thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) > 0 ||
               thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                Console.WriteLine("Maximum Number: " + thirdNum);
            }
            return firstNum;
        }
    }
}