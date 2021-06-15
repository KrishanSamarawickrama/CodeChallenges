using System;
using System.Collections.Generic;
using System.Linq;

int curruntNumber = 1;
int maxCount = 500;

Console.WriteLine("====================================================================================");

while (true)
{
    var triangularNum = Enumerable.Range(1, curruntNumber).Sum();
    List<int> divisors = new() { triangularNum };
    var maxBound = Math.Sqrt(triangularNum);

    for (int d = 1; d <= maxBound; d++)
    {
        if (triangularNum % d == 0)
        {
            // If divisors are equal, count only one
            if (triangularNum / d == d)
                divisors.Add(d);
            else
            {
                divisors.Add(d);
                divisors.Add((triangularNum / d));
            }
        }
    }

    //Console.WriteLine($"No : {curruntNumber} | Triangular No : {triangularNum} | Divisor Count: {divisors.Count}");

    if (divisors.Count > maxCount)
    {
        Console.WriteLine($"The value of the first triangle number to have over {maxCount} divisors is : ");
        Console.WriteLine($"{curruntNumber} th triangular number is {triangularNum}");
        Console.WriteLine($"Divisors : {string.Join(',', divisors)}");
        break;
    }

    curruntNumber++;
}


Console.WriteLine("====================================================================================");