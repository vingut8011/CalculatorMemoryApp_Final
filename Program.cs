// Author: Vincent Y. Gutierrez
// Project Week 3 - Calculator Memory Functions

using System;
using CalculatorMemoryApp_Final;

namespace CalculatorMemoryApp_Final
{
    class Program
    {
        static MemoryStore memory = new MemoryStore();

        static void Main()
        {
            Console.WriteLine("=== Project Week 3: Calculator Memory — Vincent Y. Gutierrez ===\n");
            Console.WriteLine("Welcome! This program demonstrates storing values in memory.\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("[1] Single Memory Value");
                Console.WriteLine("[2] Collection of up to 10 Values");
                Console.WriteLine("[Q] Quit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "1": SingleValueMenu(); break;
                    case "2": CollectionMenu(); break;
                    case "Q": running = false; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }

            Console.WriteLine("\nThank you for using the app!");
        }

        // Single Value Menu
        static void SingleValueMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\nSingle Value Memory Menu:");
                Console.WriteLine("[1] Store Value");
                Console.WriteLine("[2] Retrieve Value");
                Console.WriteLine("[3] Clear Value");
                Console.WriteLine("[4] Replace Value");
                Console.WriteLine("[B] Back");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "1":
                        memory.StoreSingle(GetInt("Enter value to store: "));
                        Console.WriteLine("Value stored.");
                        break;

                    case "2":
                        Console.WriteLine(memory.RetrieveSingle()?.ToString() ?? "No value stored.");
                        break;

                    case "3":
                        memory.ClearSingle();
                        Console.WriteLine("Memory cleared.");
                        break;

                    case "4":
                        memory.ReplaceSingle(GetInt("Enter new value: "));
                        Console.WriteLine("Value replaced.");
                        break;

                    case "B": back = true; break;
                }
            }
        }

        // Collection Menu
        static void CollectionMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\nCollection Memory Menu:");
                Console.WriteLine("[1] Display All Values");
                Console.WriteLine("[2] Add Value");
                Console.WriteLine("[3] Remove Value");
                Console.WriteLine("[4] Count Values");
                Console.WriteLine("[5] Sum");
                Console.WriteLine("[6] Average");
                Console.WriteLine("[7] Difference (First - Last)");
                Console.WriteLine("[8] Clear All Values");
                Console.WriteLine("[B] Back");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "1":
                        Console.WriteLine("Values: " + string.Join(", ", memory.GetValues()));
                        break;

                    case "2":
                        if (!memory.AddValue(GetInt("Enter value: ")))
                            Console.WriteLine("List full (10 max).");
                        break;

                    case "3":
                        memory.RemoveValue(GetInt("Enter value to remove: "));
                        break;

                    case "4":
                        Console.WriteLine("Count: " + memory.Count());
                        break;

                    case "5":
                        Console.WriteLine("Sum: " + memory.Sum());
                        break;

                    case "6":
                        Console.WriteLine("Average: " + memory.Average());
                        break;

                    case "7":
                        Console.WriteLine("Difference: " + memory.FirstMinusLast());
                        break;

                    case "8":
                        memory.ClearAll();
                        Console.WriteLine("All cleared.");
                        break;

                    case "B":
                        back = true; break;
                }
            }
        }

        static int GetInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}

    

