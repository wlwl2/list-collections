using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkingWithStrings();
            WorkingWithIntegers();
        }

        public static void WorkingWithIntegers()
        {
            // Creates a list of integers, and sets the first two integers
            // to the value 1.
            var fibonacciNumbers = new List<int> {1, 1};

            for (int i = 0; i < 18; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.WriteLine(fibonacciNumbers.Count);
        }

        public static void WorkingWithStrings()
        {
            var names = new List<string> { "William", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // One important aspect of this List<T> type is that it can grow or
            // shrink, enabling you to add or remove elements.
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // The List<T> enables you to reference individual items by index as
            // well. You place the index between [ and ] tokens following the
            // list name. C# uses 0 for the first index. Indices start at 0, so
            // the largest valid index is one less than the number of items in
            // the list.
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            // You can check how long the list is using the Count property.
            Console.WriteLine($"The list has {names.Count} people in it");

            // The IndexOf method searches for an item and returns the index of the item.
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            } else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            // The IndexOf method searches for an item and returns the index of the item.
            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            } else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            // The Sort method sorts all the items in the list in their normal
            // order (alphabetically in the case of strings).
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


        }
    }
}
