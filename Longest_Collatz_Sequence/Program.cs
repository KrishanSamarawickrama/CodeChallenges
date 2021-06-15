using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

long max = 1000000;
long highest = 0;
long highestStartingNum = 0;

for (long i = max - 1; i > 0; i--)
{
    var cal = CollatzCountDynamic(i);   

    var count = await cal;
    if (highest < count)
    {
        highest = count;
        highestStartingNum = i;
    }

    Console.Write($"\r                                              ");
    Console.Write($"\rRunningNum : {i}");
}

//long CollztzCount(long num)
//{
//    long count = 1;

//    while (num > 1)
//    {
//        count++;

//        if (num % 2 == 0)
//        {
//            num /= 2;
//        }
//        else
//        {
//            num = (num * 3) + 1;
//        }
//    }

//    return count;
//}


async Task<long> CollatzCountDynamic(long num, Dictionary<long,long> mem = null)
{
    if (num == 1) return 1;
    if (mem == null) mem = new();
    if (mem.ContainsKey(num)) return mem[num];
    if (num % 2 == 0)
    {
        mem[num] = 1 + await CollatzCountDynamic(num / 2, mem);
    }
    else
    {
        mem[num] = 2 + await CollatzCountDynamic(((num * 3) + 1) / 2, mem);
    }

    return mem[num];
}


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"Starting number, under {max}, produces the longest chain is : {highestStartingNum}");