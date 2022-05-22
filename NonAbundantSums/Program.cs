// Non-abundant sums

const int upperLimit = 28123;
HashSet<decimal> abundantNums = new();

for (var j = 1; j <= upperLimit; j++)
{
    List<int> dividends = new();
    for (var k = 1; k <= j / 2; k++)
    {
        if ((j % k) == 0) dividends.Add(k);
    }

    if (dividends.Sum() > j) abundantNums.Add(j);
}

Console.WriteLine("Abundant Nums");
Console.WriteLine(string.Join(",", abundantNums));
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

var abundantNumsArray = abundantNums.ToArray();
HashSet<decimal> abundantSumsNums = new();
for (var i = 0; i < abundantNums.Count; i++)
{
    for (var j = 0; j < abundantNums.Count; j++)
    {
        abundantSumsNums.Add(abundantNumsArray[i] + abundantNumsArray[j]);
    }
}

Console.WriteLine("Abundant Num sums");
Console.WriteLine(string.Join(",", abundantSumsNums));
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

HashSet<decimal> nonAbundantSumsNums = new();
for (var j = 1; j <= upperLimit; j++)
{
    if (!abundantSumsNums.Contains(j)) nonAbundantSumsNums.Add(j);
}

Console.WriteLine("Sum of non Abundant Num sums");
Console.WriteLine(nonAbundantSumsNums.Sum());
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Console.ReadLine();