using System;
using System.Numerics;

BigInteger sum = 0;
BigInteger power = (BigInteger)Math.Pow(2, 1000);
char[] numberChars = power.ToString().ToCharArray();

foreach (char num in numberChars)
{
    sum += Convert.ToInt64(num.ToString());
}

Console.WriteLine(sum);