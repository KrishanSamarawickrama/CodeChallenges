using System;

int limit = 1000000;

int Method1()
{
    int output = 0;

    for (int i = 0; i < limit; i++)
    {
        if (((i % 3) == 0) || ((i % 5) == 0))
            output += i;
    }

    return output;
}

Console.WriteLine("Method 1 ");
Console.WriteLine($"The sum of all the multiples of 3 or 5 below {limit} is : {Method1()}");
Console.WriteLine("--------------------------------------------------------------------------------------");
Console.WriteLine("");


int SumDivisableBy(int n)
{
    int output = 0;
    int p = limit / n;
    output = n * ((p * (p + 1))/2);
    return output;
}

Console.WriteLine("Method 2 ");
Console.WriteLine($"The sum of all the multiples of 3 or 5 below {limit} is : {SumDivisableBy(3) + SumDivisableBy(5) - SumDivisableBy(15)}");
Console.WriteLine("--------------------------------------------------------------------------------------");
Console.WriteLine("");
