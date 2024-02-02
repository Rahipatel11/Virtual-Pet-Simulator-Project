using System;
class pet
{
    // Static variables to store pet's attributes
    private static string name = "";
    private static int hunger = 5;
    private static int happiness = 5;
    private static int health = 5;

    //Method to feed the pet
    public static void feed()
    {
        // Decrease hunger, increase health
        if (hunger >= 2)
        {
            hunger -= 2;
        }
        else
        {
            hunger = 0;
        }

        if (health <= 9)
        {
            health++;
        }

        // Display message
        Console.WriteLine($"yum! {name} devoured the food. Hunger decreased, health increased.");

    }

    // Method to play with the pet
    public static void Play()
    {
        // Increase happiness, increase hunger
        if (happiness <=8)
        {
            happiness += 2;
        }
        else
        {
            happiness = 10;
        }
        if (hunger <= 9)
        {
            hunger++;
        }

        // Display message
        Console.WriteLine($"{name} is having a blast playing! Happiness increased, hunger increased.");

    }

    // Method to let the pet rest
    public static void Rest()
    {
        // Increase health, decrease happiness slightly
        if (health <= 8)
        {
            health += 2;
        }
        else
        {
            health = 10;
        }
        if (happiness >= 1)
        {
            happiness--;
        }

        // Display message
        Console.WriteLine($"{name} is taking a nap. Health increased, happiness decreased slightly.");
    }


    // Method to display pet's stats
    public static void Displaystats()
    {
        // Display pet's name and current stats
        Console.WriteLine($"{name} - Hunger: {hunger}, Happiness:{happiness},Health:{health}");
    }

   
    
    // Main method to run the program
    public static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Virtual pet Simulator!");

        // User input for pet type and name
        Console.Write("Choose a pet type(Dog,Rabbit,Cat,Horse):");
        string petType = Console.ReadLine();

        Console.Write("Give your pet a name:");
        name = Console.ReadLine();

        while(true)
        {
            Console.WriteLine("\n🎮 Main menu 🎮:")

        while (true)
        {
            Console.WriteLine("\n🎮 Main menu 🎮:")




            // Main game loop
            while (true)
            {
                // Display main menu options
                Console.WriteLine("\n Main menu :");
                Console.WriteLine("1.Feed him");
                Console.WriteLine("2.Play with the pet");
                Console.WriteLine("3.Let the pet take a nap");
                Console.WriteLine("4.Check pet's stats");
                Console.WriteLine("5.Exit");

                // User input for menu choice
                Console.Write("Select an option(1-5):");
                string choice = Console.ReadLine();

                // Execute chosen action based on user input
                if (choice == "1")
                {
                    feed();
                }

      

                else if (choice == "5")
                {
                    // Exit the program with a farewell message
                    Console.WriteLine($"{name} is waving Goodbye with a smile! Thanks for playing with {name}! Adios!!!!");
                    break;
                }

                else
                {
                    // Display error message for invalid input
                    Console.WriteLine("Invaild choice, Please Choose Between the no 1to5");
                }

                // Simulate the passage of time (1 hour per action)
                hunger++;
                happiness--;

            }
        }
    }
}

<<<<<<<<< Temporary merge branch 1
=========

>>>>>>>>> Temporary merge branch 2
