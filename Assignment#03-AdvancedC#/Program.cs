using System.Collections;
using System.Collections.Generic;
using System.Numerics;

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

            #region Q2) => Exercise 2: Leaderboard

            // 1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            SortedDictionary<int, string> entries = new SortedDictionary<int, string>
            { [500] = "Ahmed", [200] = "Sara", [800] = "Ali", [350] = "Mona" };


            // 2.Print all entries(they should be sorted by score automatically)
            Console.WriteLine($"{string.Join(",", entries)}\n");


            // 3.Access the first key and first value
            Console.WriteLine($"First Key: {entries.First().Key}, First value: {entries.First().Value}\n");


            // 4.Check if score 500 exists
            Console.WriteLine($"Check if score 500 exists: {entries.ContainsKey(500)}\n");

            // 5.Safely get the player with score 999
            if (entries.TryGetValue(999, out string? player))
                Console.WriteLine($"Player with score 999: {player}\n");
            else
                Console.WriteLine("Player with score 999 does not exist\n");


            // 6.Remove the player with score 200 and print the updated list
            Console.WriteLine($"Remove the player with score 200: {entries.Remove(200)}");
            Console.WriteLine("After Remove");
            Console.WriteLine($"{string.Join(",", entries)}\n");

            #endregion

        }
    }
}
