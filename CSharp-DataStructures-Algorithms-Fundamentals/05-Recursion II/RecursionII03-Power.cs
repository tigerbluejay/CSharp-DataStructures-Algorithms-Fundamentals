using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionII
    {
        public static int Power(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * Power(baseNum, exponent - 1);
        }

    }
}

/*
Power(2, 5) -> 32
    Power(2, 4) -> 16
        Power(2, 3) -> 8
            Power(2, 2) -> 4
                Power(2, 1) -> 2
                    Power(2, 0) -> 1

In the end the return is 2 * ( 2 * ( 2 * ( 2 * (2 * 1))))


Power(2, 1) = 2 * Power(2, 0) = 2 * 1 = 2
Power(2, 2) = 2 * Power(2, 1) = 2 * 2 = 4
Power(2, 3) = 2 * Power(2, 2) = 2 * 4 = 8
Power(2, 4) = 2 * Power(2, 3) = 2 * 8 = 16
Power(2, 5) = 2 * Power(2, 4) = 2 * 16 = 32
Final Output:
The result of Power(2, 5) is 32.

/*
Power

Write a function called power which accepts a base and an exponent. 
The function should return the power of the base to the exponent. 
This function should mimic the functionality of Math.Pow() - do not worry 
about negative bases and exponents.

 */