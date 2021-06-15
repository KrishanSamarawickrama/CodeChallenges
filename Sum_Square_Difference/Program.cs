using System;
using System.Linq;

int max = 100;

var range = Enumerable.Range(1, max).ToArray();
var powerRange = range.Select(x => Math.Pow(x, 2)).ToArray();

//Console.WriteLine(string.Join(',', range));
//Console.WriteLine(string.Join(',', powerRange));

var sumOfSquares = powerRange.Sum();
Console.WriteLine($"The sum of the squares of the first ten natural numbers is : {sumOfSquares}");

var squareOfSums = Math.Pow(range.Sum(), 2);
Console.WriteLine($"The square of the sum of the first ten natural numbers is : {squareOfSums}");


Console.WriteLine($"the difference between the sum of the squares and the square of the sum is : {squareOfSums - sumOfSquares}");



