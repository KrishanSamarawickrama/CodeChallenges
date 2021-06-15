using System;
using System.Collections.Generic;

int n = 10001;
List<int> primeNumbers = new();
int curruntNumber = 1;

bool IsPrime(int n)
{
    if (n <= 1) return false;
    if (n < 4) return true;
    int max = (int)Math.Sqrt(n);

    for (int i = 1; i <= max; i++)
    {
        if (n % i == 0 && i != 1) return false;
    }

    return true;
}

while (primeNumbers.Count < n)
{
    if (IsPrime(curruntNumber))
        primeNumbers.Add(curruntNumber);

    curruntNumber++;
}

Console.WriteLine($"{n} th Prime Number is : {primeNumbers[n-1]}");

