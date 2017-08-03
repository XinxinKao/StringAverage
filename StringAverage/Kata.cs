using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        public string[] NumberString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public string AverageString(string input)
        {
            if (input == "")
            {
                return "n/a";
            }
            var numbers = input.Split(' ');
            var total = numbers.Sum(number => ConvertToInt(number));

            var average = total / numbers.Length;

            return NumberString[average];
        }

        private int ConvertToInt(string input)
        {
            switch (input)
            {
                case "zero":
                    return 0;
                    break;
                case "one":
                    return 1;
                    break;
                case "two":
                    return 2;
                    break;
                case "three":
                    return 3;
                    break;
                case "four":
                    return 4;
                    break;
                case "five":
                    return 5;
                    break;
                case "six":
                    return 6;
                    break;
                case "seven":
                    return 7;
                    break;
                case "eight":
                    return 8;
                    break;
                case "nine":
                    return 9;
                    break;
                default:
                    return 0;
                    break;
            }

            return 0;
        }
    }
}
