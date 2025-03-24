using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        char choice;
        
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear list");
            Console.WriteLine("Q - Quit");
            Console.Write("Enter your choice: ");
            
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'P':
                    PrintNumbers(numbers);
                    break;
                case 'A':
                    AddNumber(numbers);
                    break;
                case 'M':
                    DisplayMean(numbers);
                    break;
                case 'S':
                    DisplaySmallest(numbers);
                    break;
                case 'L':
                    DisplayLargest(numbers);
                    break;
                case 'F':
                    FindNumber(numbers);
                    break;
                case 'C':
                    numbers.Clear();
                    Console.WriteLine("List cleared. Count: " + numbers.Count);
                    break;
                case 'Q':
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 'Q');
    }

    static void PrintNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
            Console.WriteLine("The list is empty.");
        else
            Console.WriteLine("Numbers (Count: " + numbers.Count + "): " + string.Join(", ", numbers));
    }

    static void AddNumber(List<int> numbers)
    {
        Console.Write("Enter a number to add: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            numbers.Add(num);
            Console.WriteLine("Number added. Count: " + numbers.Count);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

    static void DisplayMean(List<int> numbers)
    {
        if (numbers.Count == 0)
            Console.WriteLine("Cannot calculate mean. The list is empty.");
        else
            Console.WriteLine("Mean: " + numbers.Average());
    }

    static void DisplaySmallest(List<int> numbers)
    {
        if (numbers.Count == 0)
            Console.WriteLine("The list is empty.");
        else
            Console.WriteLine("Smallest number: " + numbers.Min());
    }

    static void DisplayLargest(List<int> numbers)
    {
        if (numbers.Count == 0)
            Console.WriteLine("The list is empty.");
        else
            Console.WriteLine("Largest number: " + numbers.Max());
    }

    static void FindNumber(List<int> numbers)
    {
        Console.Write("Enter a number to find: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (numbers.Contains(num))
                Console.WriteLine($"{num} is in the list. Count: " + numbers.Count);
            else
                Console.WriteLine($"{num} is not in the list. Count: " + numbers.Count);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
