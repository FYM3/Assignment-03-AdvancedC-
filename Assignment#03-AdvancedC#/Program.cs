using System.Collections.Generic;

namespace Assignment_03_AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1) => Exercise 1: Student Grade Manager

            //// 1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> Numbers = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };


            //// 2.Print the collection, Count, first and last grade
            //Console.WriteLine($"Collection items: {string.Join(",", Numbers)}");
            //Console.WriteLine($"Count number: {Numbers.Count()}");
            //Console.WriteLine($"First item: {Numbers.First()}");
            //Console.WriteLine($"Last  item: {Numbers.Last()}\n");


            //// 3.Sort the grades ascending, then print
            //Console.WriteLine("After sort asce"); Numbers.Sort();
            //Console.WriteLine($"Collection items: {string.Join(",", Numbers)}\n");


            //// 4.Get the first grade above 90
            //Console.WriteLine($"First grade above 90: {Numbers.Find(X => X > 90)}\n");


            //// 5.Get all grades below 75(failing grades)
            //Console.WriteLine($"All grade below 75(failing grades): {string.Join(",", Numbers.FindAll(X => X < 75))}\n");


            //// 6.Remove all failing grades(below 75)
            //Console.WriteLine($"Remove all failing grades (below 75): {Numbers.RemoveAll(X => X < 75)}");
            //Console.WriteLine($"After Remove");
            //Console.WriteLine($"Collection items: {string.Join(",", Numbers)}\n");


            //// 7.Check if any grade equals 100
            //Console.WriteLine($"Check if any grade equals 100: {Numbers.Any(X => X == 100)}");


            //// 8.Create a List<string> where each grade becomes "Grade: X"
            //List<string> ListNumber = new List<string>();

            //foreach (int i in Numbers)
            //    ListNumber.Add($"Grade: {i}");

            //Console.WriteLine($"{string.Join(",", ListNumber)}");

            #endregion

        }
    }
}
