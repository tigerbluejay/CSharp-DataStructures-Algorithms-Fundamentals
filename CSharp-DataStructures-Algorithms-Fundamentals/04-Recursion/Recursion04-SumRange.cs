namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class Recursion
    {
        public static int SumRange(int num)
        {
            if (num == 1) return 1;
            return num + SumRange(num - 1);
        }

    }
}