using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Letter_Counts
{
    public class NumberToLetterConverter
    {
        private Dictionary<int, string> memorey;

        private readonly string[] singleDigit = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private readonly string[] doubleDigit = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private readonly string[] tenThProducts = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private readonly string[] tenThPower = { "Hundred", "Thousand", "Million", "Billion", "Trillion" };


        public NumberToLetterConverter()
        {
            memorey = new();
        }

        public string Convert(int number)
        {
            if (memorey.ContainsKey(number)) return memorey[number];

            if (number < 100)
            {
                memorey[number] = GetBaseNumber(number);
                return memorey[number];
            }

            int thousondGroups = ((number.ToString().Length % 3) == 0 ? (number.ToString().Length / 3) : (number.ToString().Length / 3) + 1) - 1;
            int index = (number.ToString().Length % 3) == 0 ? 1 : number.ToString().Length % 3;

            int digit1 = int.Parse(number.ToString().Substring(0, index));
            string digit2Str = "";
            if (number.ToString().Length >= 3)
            {
                int digit2 = int.Parse(number.ToString()[(index)..]);
                if (digit2 > 0)
                    digit2Str = $"And {Convert(digit2)}";
            }

            memorey[number] = $"{Convert(digit1)} {tenThPower[thousondGroups]} {digit2Str}";
            return memorey[number];
        }

        private string GetBaseNumber(int number)
        {
            string output = "";

            if (0 <= number && number < 10)
            {
                output = singleDigit[number];
            }
            else if (10 <= number && number < 20)
            {
                int digit1 = int.Parse(number.ToString()[1].ToString());
                output = doubleDigit[digit1];
            }
            else if (20 <= number && number < 100)
            {
                int digit1 = int.Parse(number.ToString()[0].ToString());
                int digit2 = int.Parse(number.ToString()[1].ToString());

                if (digit2 == 0)
                {
                    output = tenThProducts[digit1 - 2];
                }
                else
                {
                    output = $"{tenThProducts[digit1 - 2]} {singleDigit[digit2]}";
                }
            }

            return output;
        }
    }
}
