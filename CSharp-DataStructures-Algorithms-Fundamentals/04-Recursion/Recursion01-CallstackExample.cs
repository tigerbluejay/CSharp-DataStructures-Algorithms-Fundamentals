namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public partial class Recursion
    {

        public static void WakeUp()
        {
            TakeShower();
            EatBreakfast();
            Console.WriteLine("Ok ready to go to work!");
        }

        static string TakeShower()
        {
            return "Showering!";
        }

        static string EatBreakfast()
        {
            string meal = CookFood();
            return $"Eating {meal}";
        }

        static string CookFood()
        {
            string[] items = { "Oatmeal", "Eggs", "Protein Shake" };
            Random rand = new Random();
            int randomIndex = rand.Next(items.Length);
            return items[randomIndex];
        }
    }
}