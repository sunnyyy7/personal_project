// # Overview

// {Important! Do not say in this section that this is college assignment. Talk about what you are trying to accomplish as a software engineer to further your learning.}

// {Provide a description of the software that you wrote to demonstrate the C# language.}

// {Describe your purpose for writing this software.}

// {Provide a link to your YouTube demonstration. It should be a 4-5 minute demo of the software running and a walkthrough of the code. Focus should be on sharing what you learned about the language syntax.}

// [Software Demo Video](http://youtube.link.goes.here)

// # Development Environment

// {Describe the tools that you used to develop the software}

// {Describe the programming language that you used and any libraries.}

// # Useful Websites

// {Make a list of websites that you found helpful in this project}

// - [Web Site Name](http://url.link.goes.here)
// - [Web Site Name](http://url.link.goes.here)

// # Future Work

// {Make a list of things that you need to fix, improve, and add in the future.}

// - Item 1
// - Item 2
// - Item 3



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");
        Console.WriteLine("Choose your path:");

        // Starting point of the adventure
        StartAdventure();

        Console.ReadLine(); // Keep the console window open
    }

    static void StartAdventure()
    {
        Console.WriteLine("1. Go through the enchanted forest");
        Console.WriteLine("2. Enter the mysterious cave");

        int choice = GetPlayerChoice(1, 2);

        if (choice == 1)
        {
            Console.WriteLine("You venture into the enchanted forest...");
            // Implement the story for the forest path
        }
        else if (choice == 2)
        {
            Console.WriteLine("You enter the mysterious cave...");
            // Implement the story for the cave path
        }
    }

    static int GetPlayerChoice(int min, int max)
    {
        int choice;
        do
        {
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (choice < min || choice > max);

        return choice;
    }
}

// Example of a simple class
class Player
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
    }
}

// Example of a simple structure
struct Item
{
    public string Name;
    public int Value;

    public Item(string name, int value)
    {
        Name = name;
        Value = value;
    }
}

