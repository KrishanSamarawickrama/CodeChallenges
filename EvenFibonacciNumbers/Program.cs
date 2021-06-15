using System;
using System.Collections.Generic;

int max = 4000000;

int sum = 0;
int curruntFib = 0;

int Fib(int n, Dictionary<int,int> mem = null)
{
    if (mem == null) mem = new Dictionary<int, int>();
    if (mem.ContainsKey(n)) return mem[n];
    if (n <= 2) return 1;

    int output = Fib(n - 1,mem) + Fib(n - 2,mem);
    mem[n] = output;
    return output;
}

int i = 2;
while (curruntFib < max)
{
    curruntFib = Fib(i);
    if ((curruntFib % 2) == 0)
        sum += curruntFib;
    i++;

    Console.WriteLine($"Currunt Fib : {curruntFib}");
}

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Method 1");

Console.WriteLine($"sum of the even-valued terms is : {sum}");

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Method 2");


int a = 1;
int b = 1;
sum = 0;

while (b < max)
{
    if (b % 2 == 0) sum += b;
    var h = a + b;
    a = b;
    b = h;
}

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Method 2");

Console.WriteLine($"sum of the even-valued terms is : {sum}");

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");

a = 1;
b = 1;
int c = a + b;

sum = 0;

while (c < max)
{
    sum += c;
    a = c + b;
    b = c + a;
    c = b + a;
}

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Method 3");

Console.WriteLine($"sum of the even-valued terms is : {sum}");

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("");