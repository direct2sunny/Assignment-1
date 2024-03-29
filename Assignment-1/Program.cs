using System;

class VirtualPet
{
    // Attributes
    private string petType;
    private string petName;
    private int hunger;
    private int happiness;
    private int health;

    // Constructor
    public VirtualPet(string type, string name)
    {
        petType = type;
        petName = name;
        hunger = 10;
        happiness = 10;
        health = 10;
    }

    // Pet status
    public void displayPetStatus()
    {
        Console.WriteLine($"\n{petName}'s Status : ");
        Console.WriteLine($" Hunger: {hunger}");
        Console.WriteLine($" Happiness: {happiness}");
        Console.WriteLine($" Health: {health}");
    }

    // Pet is Feeding
    public void feed()
    {
        Console.WriteLine($"\nYou fed {petName}. His hunger decreases, and health improves slightly.");
        hunger = Math.Max(1, hunger - 2);
        happiness = Math.Min(10, happiness + 2);
        health = Math.Min(10, health + 2);
    }

    // Pet is Playing
    public void play()
    {
        Console.WriteLine($"\nYou played with {petName}. His happiness increases, but he's bit hungrier.");
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
        health = Math.Max(1, health - 1);
    }

    // Pet Resting
    public void rest()
    {
        Console.WriteLine($"\n{petName} is resting. His health is increases, but he's happiness decreases slightly.");
        health = Math.Min(10, health + 2);
        happiness = Math.Max(1, happiness - 1);
    }

    // Time-based changes
    public void timePasses()
    {
        hunger = Math.Min(10, hunger + 1);
        happiness = Math.Max(1, happiness - 1);

        // Check for critical conditions
        if (hunger >= 8)
            Console.WriteLine($"\n{petName} is very hungry! Feed {petName} soon!");
        if (happiness <= 3)
            Console.WriteLine($"\n{petName} is unhappy! Play with {petName} to make it happy!");
        if (health <= 3)
            Console.WriteLine($"\n{petName}'s health is low! Consider letting {petName} rest!");
    }

    // Main method
    static void Main()
    {
        string choice;
        do
        {
          Console.WriteLine
          ("Please choose a type of pet : \n1.Cat \n2.Dog \n3.Rabbit\n4.Exit ");
        Console.Write("User Input: ");
        string petType = Console.ReadLine();

        // Decide type of pet
        switch (petType)
        {
            case "1":
                petType = "Cat";
                break;

            case "2":
                petType = "Dog";
                break;

            case "3":
                petType = "Rabbit";
                break;

            case "4":
                    Console.WriteLine("Invalid choice!");
                Environment.Exit(0);
                break;
        }

        Console.Write($"\nYou've chosen a {petType}. What would you like to name your pet: ");
        string petName = Console.ReadLine();

        Console.WriteLine($"\nWelcome, {petName}! Let's take good care of him.");
        VirtualPet pet = new VirtualPet(petType, petName);
        while (true)
        {

            Console.WriteLine();
            Console.WriteLine("Main Menu:");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let {petName} Rest");
            Console.WriteLine($"4. Check {petName}'s Status");
            Console.WriteLine("5. Choose another pet");
            Console.WriteLine("6. Exit completely");

            Console.Write("\nUser Input : ");
             choice = Console.ReadLine();
            if(choice=="5"){break;}
            switch (choice)
            {
                case "1":
                    pet.feed();
                    break;

                case "2":
                    pet.play();
                    break;

                case "3":
                    pet.rest();
                    break;


                case "4":
                    pet.displayPetStatus();
                    break;
                case "5": break;
                case "6":
                    Console.WriteLine($"Thank you for playing with {petName}. Goodbye!");
                    Environment.Exit(0);
                    break;
            }

            // Simulate the passage of time
            pet.timePasses();
        }

        }
        while (choice=="5");
   }
        
}


