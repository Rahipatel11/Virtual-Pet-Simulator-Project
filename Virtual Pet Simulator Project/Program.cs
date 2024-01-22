using System;
 class pet
{
    private static string name = "";
    private static int hunger = 5;
    private static int happiness = 5;
    private static int health = 5;

    public static void feed()
    {
        if(hunger>2)
        {
            hunger-= 2;
        }
        else
        {
            hunger = 0;
        }
        
        if(health<=9) 
        {
            health++;
        }
        Console.WriteLine($"yum!{name}devoured the food. Hunger decreased, health increased.");

    }

    public static void Play()
    {
        if(happiness<=8)
        {
            happiness += 2;
        }
        else
        { 
            happiness = 10;
        }
        if(hunger<=9)
        { 
            hunger++;
        }

        Console.WriteLine($"{name} is having a blast playing! Happiness increased, hunger increased.");
        
    }

    public static void Rest()
    {
        if(health<=8)
        {
            health += 2;
        }
        else
        {
          health=10;
        }
        if(happiness>=1)
        {
            happiness--;
        }

        Console.writeline($"{name}is taking a nap. Health increased, happiness decreased slightly.");
    }


}