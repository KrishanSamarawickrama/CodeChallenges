using System;
using System.Collections.Generic;

long Traveler(int m, int n, Dictionary<string, long> memo = null)
{
    if (memo == null) memo = new();
    var key = $"{m}-{n}";
    if (memo.ContainsKey(key)) return memo[key];

    //if (n == 1 && m == 1) return 1;
    if (n == 0 || m == 0) return 1;

    memo[key] = Traveler(m - 1, n, memo) + Traveler(m, n - 1, memo);
    return memo[key];
}


Console.WriteLine(Traveler(20, 20));
