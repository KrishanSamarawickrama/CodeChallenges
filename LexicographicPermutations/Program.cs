// Lexicographic permutations

IEnumerable<string> GetPermutations(string value)
{
    var strArr = value.ToCharArray();

    var size = strArr.Length;
    
    Array.Sort(strArr);

    var isCompleted = false;
    while (!isCompleted)
    {
        var output = new string(strArr);
        
        int index1;
        for (index1 = size - 2; index1 >= 0; --index1)
            if(strArr[index1] < strArr[index1+1]) break;

        if (index1 == -1)
            isCompleted = true;
        else
        {
            var index2 = FindCharIndex(strArr, strArr[index1], index1 + 1);
            Swap<char>(strArr, index1, index2);
            Array.Sort(strArr, index1 + 1, size - index1 - 1);
        }
        
        yield return output;
    }
}

int FindCharIndex(char[] strArr, char maxChar, int maxIndex)
{
    int index = maxIndex;
    for (int i = maxIndex + 1; i < strArr.Length; i++)
    {
        if (maxChar < strArr[i] && strArr[i] < strArr[index])
            index = i;
    }
    return index;
}

void Swap<T>(T[] strArr, int i, int r)
{
    (strArr[i], strArr[r]) = (strArr[r], strArr[i]);
}

var number = "0123456789";
//var number = "210";
//var number = "ABCD";

var i = 1;
foreach (var permutation in GetPermutations(number).Skip(999_999).Take(1))
{
    Console.Write(i++ + " - ");
    Console.WriteLine(permutation);
}

Console.WriteLine($"----------------------");
//Console.WriteLine(memCount.OrderByDescending(x => x).First());
Console.ReadLine();