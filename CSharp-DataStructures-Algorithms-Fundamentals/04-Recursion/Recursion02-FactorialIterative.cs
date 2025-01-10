namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class Recursion
    {
        public static int FactorialIterative(int num)
        {
            int total = 1;
            for (int i = num; i > 1; i--)
            {
                total *= i;
            }
            return total;
        }

    }
}