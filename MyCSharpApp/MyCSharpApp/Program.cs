// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Introduction
        Console.WriteLine("Welcome to the Harry Potter Wizard World Adventure Game!");

        // Player setup
        Console.Write("Enter your character's name: ");
        string playerName = Console.ReadLine();

        // Starting point
        Console.WriteLine($"Hello, {playerName}! Sorting hat said you are in Gryffindor!");

        // Game loop
        while (true)
        {
            Console.WriteLine("\nYou are back to the the entrance of Hogwarts School of Witchcraft and Wizardry, what do you want to go?:");
            Console.WriteLine("1. Go to the Great Hall");
            Console.WriteLine("2. Visit the Forbidden Forest");
            Console.WriteLine("3. Explore the Quidditch Pitch");
            Console.WriteLine("4. Save and Quit");

            // Player choice
            int choice = GetPlayerChoice(1, 4);

            // Process player's choice
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You enter the Great Hall and enjoy a magical feast.");
                    break;

                case 2:
                    Console.WriteLine("You venture into the Forbidden Forest and encounter dangerous creatures.");

                    // Additional choices after Forbidden Forest
                    Console.WriteLine("\nChoose:");
                    Console.WriteLine("5. Explore the Secret Chamber");
                    Console.WriteLine("6. Attend a Magical Class");
                    int forestChoice = GetPlayerChoice(5, 6);

                    // Process additional choices
                    switch (forestChoice)
                    {
                        case 5:
                            Console.WriteLine("You discover the Secret Chamber and unravel ancient mysteries.");
                            break;

                        case 6:
                            Console.WriteLine("You attend a Professor Snape's class in the Lacock Abbey and learn new spells.");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("You visit the Quidditch Pitch and watch an exciting game. Gryffindor Wins!");
                    break;

                case 4:
                    // Save and Quit
                    SavePlayerProgress(playerName);
                    Console.WriteLine($"Progress saved for {playerName}. Goodbye!");
                    return;
            }
        }
    }

    // Function to get a valid player choice
    static int GetPlayerChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    // Function to save player progress to a file
    static void SavePlayerProgress(string playerName)
    {
        string fileName = $"{playerName}_progress.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Player: {playerName}");
            writer.WriteLine("Current Location: Hogwarts Entrance");
            // Add more information to save if needed
        }
        Console.WriteLine($"Progress saved to {fileName}.");
    }
}