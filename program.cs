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
