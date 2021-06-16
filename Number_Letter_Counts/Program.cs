using System;
using System.Collections.Generic;
using Number_Letter_Counts;

int counter = 0;
NumberToLetterConverter toLetterConverter = new();

for (int i = 1; i <= 1000; i++)
{
    Console.WriteLine($"{i} - {toLetterConverter.Convert(i)}");
    counter += toLetterConverter.Convert(i).Replace(" ","").Length;
}

Console.WriteLine(counter);