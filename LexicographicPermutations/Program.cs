// Lexicographic permutations

HashSet<string> memCount = new HashSet<string>();

void Permute(string value, int la, int lb)
{
    if (la == lb)
    {
        if (memCount.Count > 1000000) return;
        Console.WriteLine($"{value} | {memCount.Count}");
        memCount.Add(value);
    }
    else
    {
        for (int i = la; i < lb; i++)
        {
            value = Swap(value, la, i);
            Permute(value, la + 1, lb);
            value = Swap(value, la, i);
        }
    }
}

string Swap(string value, int i, int r)
{
    var valChars = value.Select(x => x.ToString()).ToArray();
    (valChars[i], valChars[r]) = (valChars[r], valChars[i]);
    return string.Join("", valChars);
}

var number = "0123456789";
//var number = "012";
Permute(number, 0, number.Length);

Console.WriteLine($"----------------------");
Console.WriteLine(memCount.OrderByDescending(x => x).First());
Console.ReadLine();