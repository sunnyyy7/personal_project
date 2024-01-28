/* # Overview

{Important! Do not say in this section that this is college assignment. Talk about what you are trying to accomplish as a software engineer to further your learning.}

{Provide a description of the software that you wrote to demonstrate the C# language.}
The provided software is a text-based adventure game set in the Harry Potter Wizarding World. 
It is written in C# and is designed to run in a console environment. 
The game allows the player to navigate through different locations within Hogwarts School of Witchcraft and Wizardry, 
make choices, and experience various magical scenarios.



{Describe your purpose for writing this software.}

The purpose of writing this software is to showcase the use of C# programming language for creating a simple interactive game. 
The game demonstrates fundamental programming concepts such as user input handling, decision-making using switch statements, 
looping for gameplay, and the use of functions to modularize the code. Additionally, 
it features a save and quit functionality to persist player progress.

{Provide a link to your YouTube demonstration. It should be a 4-5 minute demo of the software running and a walkthrough of the code. Focus should be on sharing what you learned about the language syntax.}

[Software Demo Video](http://youtube.link.goes.here)

# Development Environment

{Describe the tools that you used to develop the software}: VS code, youtube, w3school website

{Describe the programming language that you used and any libraries.}

The primary programming language used for this software is C# (C Sharp). C# is a modern, object-oriented programming language developed by Microsoft, commonly used for building Windows applications, web applications, and games.

In this case, the code does not explicitly mention the use of external libraries. 
The game relies on the core functionality provided by the C# language itself, 
utilizing basic input/output operations and file handling. 
The code showcases the inherent capabilities of C# for building console-based applications without the need for extensive external libraries.

# Useful Websites

{Make a list of websites that you found helpful in this project}

- [Web Site Name](http://url.link.goes.here)
- [Web Site Name](http://url.link.goes.here)

# Future Work

{Make a list of things that you need to fix, improve, and add in the future.}

- Item 1: Story line haven't finish yet
- Item 2: Add more options for the story
- Item 3 */

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