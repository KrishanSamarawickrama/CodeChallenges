using System;
using System.Collections.Generic;
using System.Linq;

bool IsPrime(long num)
{
    if (num <= 1) return false;
    if (num < 4) return true;

    long maxNum = (long)Math.Sqrt(num);

    for (long i = maxNum; i > 1; i--)
    {
        if (num % i == 0 && i != 1) return false;
    }

    return true;
}


Console.WriteLine("=================================================");
Console.WriteLine("Summation of Primes");
Console.WriteLine("=================================================");
Console.WriteLine("");
Console.WriteLine("Find the sum of all the primes below n");
Console.WriteLine("Enter valid value for n : _");
var input = Console.ReadLine();
Console.WriteLine("");

if (long.TryParse(input, out long maxNumber))
{
    long runningNum = 1;
    List<long> primeNumbers = new();

    while (true)
    {
        if (IsPrime(runningNum))
        {
            primeNumbers.Add(runningNum);
            //Console.Write($"\rPrime values : {string.Join(',', primeNumbers)}");
            Console.WriteLine($"{runningNum}");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        if (runningNum >= maxNumber) break;

        runningNum++;
    }
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"all the primes below {maxNumber} is : {primeNumbers.Sum()} ");
    Console.WriteLine("");
}
else
{
    Console.WriteLine("Invalid value !!!!!!");
    Console.WriteLine("");
}