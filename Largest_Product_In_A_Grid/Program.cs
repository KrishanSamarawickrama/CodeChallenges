using System;
using System.IO;
using System.Linq;

string path = @"F:\BATCAVE\Code Practice\Project Euler\Largest_Product_In_A_Grid\GridText.txt";

var gridData = File.ReadLines(path).ToArray();

var colCount = gridData[0].Split(' ').Length;
var rowCount = gridData.Length;

int[,] MainGrid = new int[rowCount, colCount];

for (int i = 0; i < rowCount; i++)
{
    var colValues = gridData[i].Split(' ');
    for (int n = 0; n < colValues.Length; n++)
    {
        if (int.TryParse(colValues[n], out int result))
            MainGrid[i, n] = result;
        else
            MainGrid[i, n] = 0;
    }
}

int maxValue = 0;

for (int row = 0; row < rowCount; row++)
{
    for (int col = 0; col < colCount; col++)
    {
        int curruntVal = 0;

        //Right
        if ((col + 3) < colCount)
        {
            curruntVal = MainGrid[row, col] * MainGrid[row, col + 1] * MainGrid[row, col + 2] * MainGrid[row, col + 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Left
        if ((col - 3) >= 0)
        {
            curruntVal = MainGrid[row, col] * MainGrid[row, col - 1] * MainGrid[row, col - 2] * MainGrid[row, col - 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Down
        if ((row + 3) < rowCount)
        {
            curruntVal = MainGrid[row, col] * MainGrid[row + 1, col] * MainGrid[row + 2, col] * MainGrid[row + 3, col];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Up
        if ((row - 3) >= 0)
        {
            curruntVal = MainGrid[row, col] * MainGrid[row - 1, col] * MainGrid[row - 2, col] * MainGrid[row - 3, col];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Diagonally Right Down
        if (((col + 3) < colCount) && ((row + 3) < rowCount))
        {
            curruntVal = MainGrid[row, col] * MainGrid[row + 1, col + 1] * MainGrid[row + 2, col + 2] * MainGrid[row + 3, col + 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Diagonally Right Up 
        if (((col + 3) < colCount) && ((row - 3) >= 0))
        {
            curruntVal = MainGrid[row, col] * MainGrid[row - 1, col + 1] * MainGrid[row - 2, col + 2] * MainGrid[row - 3, col + 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Diagonally Left Down
        if (((col - 3) >= 0) && ((row + 3) < rowCount))
        {
            curruntVal = MainGrid[row, col] * MainGrid[row + 1, col - 1] * MainGrid[row + 2, col - 2] * MainGrid[row + 3, col - 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

        //Diagonally Left Down
        if (((col - 3) >= 0) && ((row - 3) >= 0))
        {
            curruntVal = MainGrid[row, col] * MainGrid[row - 1, col - 1] * MainGrid[row - 2, col - 2] * MainGrid[row - 3, col - 3];
            if (maxValue < curruntVal) maxValue = curruntVal;
        }

    }
}


Console.WriteLine($"The greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the {rowCount}×{colCount} grid is : ");
Console.WriteLine(maxValue);