using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpecialPythagorenTriplet;

async Task FindSpecialPythagorenTriplet(long value)
{
    await Task.Run(() =>
    {
        long maxValue = value;
        List<PythagorenTriplet> PythagorenTriplets = new();

        for (long m = 3; m < maxValue; m++)
        {
            for (long n = 2; n < m; n++)
            { 
                long a = (long)Math.Pow(m,2) - (long)Math.Pow(n,2);
                long b = 2 * m * n;
                long c = (long)Math.Pow(m, 2) + (long)Math.Pow(n, 2);

                long p1 = (long)Math.Pow(a,2) + (long)Math.Pow(b , 2);
                long p2 = (long)Math.Pow(c, 2);

                if (p1 == p2)
                {
                    long sum = a + b + c;
                    var pythadoren = new PythagorenTriplet(a, b, c, sum);
                    PythagorenTriplets.Add(pythadoren);

                    Console.WriteLine($"Pythagoren triplet for m : {m} n : {n} is {pythadoren}");

                    if (sum == maxValue)
                    {
                        Console.WriteLine($"The Special pythagoren triplet product is {a * b * c}");
                        return;
                    }
                }
                
            }
        }

    });
}

Console.WriteLine("==============================================================");
Console.WriteLine("Find Pythagoren Special For : <enter an integer number>");
var value = Console.ReadLine();
if (long.TryParse(value, out long numberValue))
{
    FindSpecialPythagorenTriplet(numberValue).Wait();    
}
else
{
    Console.WriteLine("Invalid Number");
}


public record PythagorenTriplet(long A, long B, long C, long Sum);


