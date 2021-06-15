using System;
using System.IO;
using System.Linq;
using System.Text;

var numbersTextList = File.ReadAllLines("NumberList.txt").ToArray();

int rowCount = numbersTextList.Length;
int colCount = numbersTextList[0].Length;

int[,] Grid = new int[rowCount, colCount];

for (int i = 0; i < rowCount; i++)
{
    var charList = numbersTextList[i].ToCharArray().Select(c => c.ToString()).ToArray();
    Array.Reverse(charList);
    for (int r = 0; r < charList.Length; r++)
    {
        Grid[i, r] = int.Parse(charList[r]);
    }
}

string sumStr = "";
StringBuilder largeSum = new();
int balance = 0;
for (int col = 0; col < colCount; col++)
{
    int sum = balance;

    for (int row = 0; row < rowCount; row++)
    {
        sum += Grid[row, col];
    }

    if (col == (colCount - 1))
    {
        char[] charArray = largeSum.ToString().ToCharArray();
        Array.Reverse(charArray);
        sumStr = sum.ToString() + new string(charArray);
        break;
    }

    var strSum = sum.ToString().Substring(sum.ToString().Length - 1);
    var strBal = sum.ToString().Substring(0, sum.ToString().Length - 1);
    balance = int.Parse(strBal);
    largeSum.Append(strSum);
}

Console.WriteLine(sumStr);
Console.WriteLine(sumStr.Substring(0, 10));