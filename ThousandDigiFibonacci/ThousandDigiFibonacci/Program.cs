// 1000-digit Fibonacci number

using System.Collections;
using System.Numerics;


(BigInteger, Dictionary<string, BigInteger>) GenFibonacci(BigInteger number, Dictionary<string, BigInteger>? mem = null)
{
    mem ??= new Dictionary<string, BigInteger>();
    if (number <= 2) return (1, mem);

    if (mem.ContainsKey(number.ToString())) return (mem[number.ToString()], mem);

    var fib = GenFibonacci(number - 1, mem).Item1 + GenFibonacci(number - 2, mem).Item1;
    mem[number.ToString()] = fib;

    return (fib, mem);
}

IEnumerable<(BigInteger, BigInteger)> GetFibonacci()
{
    BigInteger index = 1;
    Dictionary<string, BigInteger>? mem = null;
    while (true)
    {
        (var fib, mem) = GenFibonacci(index, mem);
        yield return (fib, index);
        index += 1;
    }
}

foreach (var (fib, index) in GetFibonacci())
{
    //Console.WriteLine("-----------------------------------");
    //Console.WriteLine(fib);
    if (fib.ToString().Trim().Length == 1000)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("-------------- Number -------------");
        Console.WriteLine(fib);
        Console.WriteLine("--------------- Index -------------");
        Console.WriteLine(index);
        Console.WriteLine("--------------- Length -------------");
        Console.WriteLine((int)Math.Floor(BigInteger.Log10(fib) + 1));
        Console.WriteLine(fib.ToString().ToCharArray().Length);
        break;
    }
}

Console.ReadLine();