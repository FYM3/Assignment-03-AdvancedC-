using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

            //// 1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedDictionary<int, string> entries = new SortedDictionary<int, string>
            //{ [500] = "Ahmed", [200] = "Sara", [800] = "Ali", [350] = "Mona" };


            //// 2.Print all entries(they should be sorted by score automatically)
            //Console.WriteLine($"{string.Join(",", entries)}\n");


            //// 3.Access the first key and first value
            //Console.WriteLine($"First Key: {entries.First().Key}, First value: {entries.First().Value}\n");


            //// 4.Check if score 500 exists
            //Console.WriteLine($"Check if score 500 exists: {entries.ContainsKey(500)}\n");

            //// 5.Safely get the player with score 999
            //if (entries.TryGetValue(999, out string? player))
            //    Console.WriteLine($"Player with score 999: {player}\n");
            //else
            //    Console.WriteLine("Player with score 999 does not exist\n");


            //// 6.Remove the player with score 200 and print the updated list
            //Console.WriteLine($"Remove the player with score 200: {entries.Remove(200)}");
            //Console.WriteLine("After Remove");
            //Console.WriteLine($"{string.Join(",", entries)}\n");

            #endregion

            #region Q3) => Exercise 3: Phone Book

            //// 1. Create a Collection  with 4 contacts (name → phone number)
            //Dictionary<string, int> pairs = new Dictionary<string, int>
            //{ ["Mona"] = 1546, ["Ahmed"] = 435, ["Sara"] = 567, ["Ali"] = 1235 };


            //// 2.Add a new contact using [] syntax (add or update)
            //pairs["Yousef"] = 8574; // Add
            //pairs["Mona"] = 7005; // update


            //// 3.Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    pairs.Add("Yousef", 8588); // duplicate => Error
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}\n");
            //}


            //// 4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            //bool result = pairs.TryAdd("Yousef", 8574);
            //Console.WriteLine($"TryAdd succeeded: {result}\n");


            //// 5.Search for a contact that doesn’t exist
            //Console.WriteLine($"Check if Aya exists: {pairs.ContainsKey("Aya")}\n");


            //// 6.Get a contact with a fallback of "Not Found"
            //if (!pairs.ContainsKey("Osama"))
            //    Console.WriteLine("Not Found\n");
            //else
            //    Console.WriteLine("Found\n");


            //// 7.Print all Keys on one line, then all Values on another line
            //Console.WriteLine("All Keys:");
            //Console.WriteLine($"{string.Join(",", pairs.Keys)}\n");

            //Console.WriteLine("All Values:");
            //Console.WriteLine($"{string.Join(",", pairs.Values)}");

            #endregion

        }
    }
}
