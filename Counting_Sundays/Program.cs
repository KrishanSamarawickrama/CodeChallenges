using System;

int rnYear = 1901;
int rnMonth = 1;

int inYear = 2000;
int inMonth = 12;

int sundayCount = 0;

while (rnYear <= inYear && rnMonth <= inMonth)
{
    var k = 1;
    var m = rnMonth;
    var C = int.Parse(rnYear.ToString().Substring(0, 2));
    var Y = rnYear;

    var W = (k + ((2.6 * m) - 0.2) - (2 * C) + Y + (Y / 4) + (C / 4)) % 7;

    var W2 = new DateTime(rnYear, rnMonth, 1).DayOfWeek;
    if (W2 == DayOfWeek.Sunday)
    {
        Console.WriteLine($"{rnYear}-{rnMonth}-{k} : {W}");
        sundayCount++;
    }

    if(rnMonth == 12)
    {
        rnYear++;
        rnMonth = 1;
    }
    else
    {
        rnMonth++;
    }
    
}

Console.WriteLine($"Sundays between 1901-1 to {inYear}-{inMonth} is : {sundayCount}");