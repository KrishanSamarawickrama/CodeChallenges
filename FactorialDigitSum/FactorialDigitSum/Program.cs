//Factorial digit sum

using System.Numerics;

var number = 100;

BigInteger GetFactorial(int digit, Dictionary<string,BigInteger>? mem = null)
{
    if (digit == 1) return 1;
    var key = $"{digit}x{digit - 1}";
    mem ??= new();
    if (mem.ContainsKey(key)) return mem[key];
    mem[key] = digit * GetFactorial(digit - 1,mem);
    return mem[key] ;
}

long GetSumOfDigits(int digit)
{
    var factorial = GetFactorial(number);
    Console.WriteLine($"Factorial of {number} : {factorial} ");
    return factorial.ToString().ToCharArray().Sum(n => int.Parse(n.ToString()));
}


Console.WriteLine($"Factorial digit sum of {number} : {GetSumOfDigits(number)} ");
Console.ReadLine();