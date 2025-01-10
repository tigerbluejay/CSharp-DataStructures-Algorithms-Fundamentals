namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class Recursion
    {
        public static int FactorialRecursive(int num)
        {
            if (num == 1)
                return 1;
            return num * FactorialRecursive(num - 1);
        }

    }
}