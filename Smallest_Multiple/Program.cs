using System;

int maxNumber = 20;
int minNumber = 1;
int increment = 20;
int curruntNumber = 20;

while (true)
{
    bool isFound = false;
    for (int i = minNumber; i <= maxNumber; i++)
    {
        if (curruntNumber % i == 0)
            isFound = true;
        else
        {
            isFound = false;
            break;
        }
    }
    if (isFound) break;    
    curruntNumber += increment;
}

Console.WriteLine($"The smallest positive number that is evenly divisible by all of the numbers from {minNumber} to {maxNumber} : {curruntNumber}");
