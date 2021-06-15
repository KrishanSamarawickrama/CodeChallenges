using System;
using System.Collections.Generic;

long target_number = 600851475143;

long getFactors(long target)
{
    if (target <= 1) return 1;
    long divider = (long)Math.Sqrt(Convert.ToDouble(target - 1));

    while (divider > 0)
    {
        if ((target % divider) == 0)
        {
            Console.WriteLine($"{target} % {divider}");
            if (getFactors(divider) == 1)
            {
                Console.WriteLine(divider);
                return divider;
            }
        }
        divider--;
    }

    return 0;
}

var factor = getFactors(target_number);

Console.WriteLine($"Largest prime factor : {factor}");
