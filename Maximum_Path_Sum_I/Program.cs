using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

List<int[]> list = new();

var lines = File.ReadLines("DataFile.txt");
foreach (var line in lines)
{
    int[] nums = line.Split(' ')?.Select(x => int.Parse(x)).ToArray();
    list.Add(nums);
}

int Sum(int i = 0, int c = 0, Dictionary<string,int> mem = null)
{
    if (mem == null) mem = new();
    if (mem.ContainsKey($"{i}-{0}")) return mem[$"{i}-{0}"];
    if (i == list.Count - 1)
        return list[i][c];

    int sum1 = list[i][c] + Sum(i + 1, c);
    int sum2 = list[i][c] + Sum(i + 1, c + 1);

    mem[$"{i}-{0}"] = (sum1 > sum2) ? sum1 : sum2;
    return mem[$"{i}-{0}"];
}

Console.WriteLine(Sum());