using System;
using System.Collections.Generic;
using System.Linq;

int Min = 100;
int Max = 999;

HashSet<int> palindromes = new();

for (int i = Max; i > Min; i--)
{
    for (int j = i; j > Min; j--)
    {
        var val = i * j;
        var valString = val.ToString();
        if (string.Join("", valString.Reverse().ToArray()).Equals(valString))
        {
            palindromes.Add(val);
            Console.WriteLine($"Palindrome : {valString} = {i} x {j}");
        }
    }
}

Console.WriteLine($"Largesr Palindrome : {palindromes.Max()}");

