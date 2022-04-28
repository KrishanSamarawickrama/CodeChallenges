//Amicable numbers

var target = 10000;

var sumOfDividers = new Dictionary<int, int>();
var amicableNumbers = new HashSet<(int,int)>();

for (var i = 1; i <= target; i++)
{
    var divisorCandidates = Enumerable.Range(1, i / 2);
    var divisors = divisorCandidates.Where(divisor => i % divisor == 0 || divisor == 1).ToList();
    //Console.WriteLine($"divisors of {i} : {string.Join(",", divisors)}");
    var sum = divisors.Sum();
   
    if (sumOfDividers.ContainsKey(sum) && sumOfDividers[sum] == i)
    {
        amicableNumbers.Add((i,divisors.Sum()));
    }
    sumOfDividers.Add(i, sum);
}

Console.WriteLine($"Amicable numbers : {string.Join(",", amicableNumbers)}");
Console.WriteLine($"Sum of Amicable numbers : {amicableNumbers.Sum(x => (x.Item1 + x.Item2))}");
Console.ReadLine();