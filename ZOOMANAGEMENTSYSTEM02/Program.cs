using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Buffalo;


using static System.Net.Mime.MediaTypeNames;

// Interfaces
interface IFeedable
{
    void Eat();
}

interface IMovable
{
    void Move();
}
interface IClimbable
{
    void Climb();
}

interface ISwimmable
{
    void Swim();
}

interface IFlyable
{
    void Fly();
}

// Base class Animal
public abstract class Animal
{
    // Fields made private
    private string _name;
    private string _type;
    private int _age;
    private float _weight;
    private string _gender;
    private float _height;
    private string _lifeExpectancy;
    private string _food;

    // Properties for controlled access
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public float Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public float Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public string LifeExpectancy
    {
        get { return _lifeExpectancy; }
        set { _lifeExpectancy = value; }
    }

    public string Food
    {
        get { return _food; }
        set { _food = value; }
    }

    // Constructor
    public Animal(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
    {
        // Setting values using properties to ensure validation if needed
        Name = name;
        Type = type;
        Age = age;
        Weight = weight;
        Gender = gender;
        Height = height;
        LifeExpectancy = lifeExpectancy;
        Food = food;
    }

    public abstract void Eat();
    public abstract void Move();
    public abstract void Speak();

    // Methods remain the same


}

// Derived classes
public class Lion : Animal, IFeedable, IMovable
{
    public Lion(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
        : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the lion is eating meat.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the lion is sleeping in the shade.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the lion is walking majestically.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} the lion roars.");
    }
}

public class Elephant : Animal, IFeedable, IMovable
{
    public Elephant(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
        : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the elephant is eating leaves.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the elephant is sleeping in the shade.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the elephant is walking slowly.");
    }

    public override void Speak()
    {
        throw new NotImplementedException();
    }
}

public class Rhino : Animal, IFeedable, IMovable
{
    public Rhino(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
        : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the rhino is eating grass.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the rhino is sleeping in the shade.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the rhino is running.");
    }

    public override void Speak()
    {
        throw new NotImplementedException();
    }
}

public class Leopard : Animal, IFeedable, IMovable
{
    public Leopard(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
        : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the leopard is eating meat.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the leopard is sleeping.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the leopard is running.");
    }

    public override void Speak()
    {
        throw new NotImplementedException();
    }
}

public class Buffalo : Animal, IFeedable, IMovable
{
    public Buffalo(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
        : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the buffalo is eating grass.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the buffalo is sleeping in the shade.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the buffalo is running.");
    }

    public override void Speak()
    {
        throw new NotImplementedException();
    }

    //Task 01 FA3
    // Additional structures and enumerations
    public struct DietInfo
    {
        public string DietaryRequirements { get; set; }
        public string FeedingSchedule { get; set; }
    }
    public enum AnimalType
    {
        Lion,
        Leopard,
        Buffalo,
        Elephant,
        Rhino,

    }

    public enum FoodType
    {
        Meat,
        Vegetation,
        Mixed
    }

    public enum HabitatType
    {
        Desert,
        Forest,
        Grassland,
        Wetland,
    }

}
// Extended classes with additional behaviors
public class Monkey : Animal, IClimbable
{
    //CONSTRUCTOR
    public Monkey(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
   : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }



    public override void Eat()
    {
        Console.WriteLine($"{Name} the monkey is eating bananas.");
    }

    public void Climb()
    {
        Console.WriteLine($"{Name} the monkey is climbing a tree.");
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override void Speak()
    {
        throw new NotImplementedException();
    }
}

public class Octapuse : Animal, ISwimmable
{
    //CONSTRUCTOR
    public Octapuse(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
    : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the octapuse is eating fish.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the octapuse is swimming.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} the octapuse clicks.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} the octapuse is swimming in the water.");
    }
}
// Additional classes with new behaviors
public class Dove : Animal, IFlyable
{
    public Dove(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
    : base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Dove is eating prey.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the Dove is soaring.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} the Dove screeches.");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the Dove is flying high in the sky.");
    }
}

public class Bat : Animal, IFlyable
{
    public Bat(string name, string type, int age, float weight, string gender, float height, string lifeExpectancy, string food)
: base(name, type, age, weight, gender, height, lifeExpectancy, food) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the bat is eating prey.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the bat is soaring.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} the bat screeches.");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the bat is flying high in the sky.");
    }
}


public class AnimalAlreadyExistsException : Exception
{
    public AnimalAlreadyExistsException() { }

    public AnimalAlreadyExistsException(string message)
        : base(message) { }

    public AnimalAlreadyExistsException(string message, Exception innerException)
        : base(message, innerException) { }
}

// Custom exception for when trying to add an invalid animal type
public class InvalidAnimalTypeException : Exception
{
    public InvalidAnimalTypeException() { }

    public InvalidAnimalTypeException(string message)
        : base(message) { }

    public InvalidAnimalTypeException(string message, Exception innerException)
        : base(message, innerException) { }
}

// Custom exception for when an animal cannot perform a specific action
public class AnimalCannotDoActionException : Exception
{
    public AnimalCannotDoActionException() { }

    public AnimalCannotDoActionException(string message)
        : base(message) { }

    public AnimalCannotDoActionException(string message, Exception innerException)
        : base(message, innerException) { }
}
// Main program
class Program
{
    static void Main(string[] args)
    {
        List<Animal> zooAnimals = new List<Animal>
        {
            new Lion("Simba", "Lion", 5, 190, "M", 1.2f, "10-14 years", "Carnivore"),
            new Leopard("Nala", "Leopard", 3, 80, "F", 0.7f, "12-17 years", "Carnivore"),
            new Buffalo("Bessy", "Buffalo", 7, 600, "M", 1.5f, "18-22 years", "Herbivore"),
            new Elephant("Hercules", "Elephant", 10, 5000, "M", 3.0f, "60-70 years", "Herbivore"),
            new Rhino("Pachyderms", "Rhino", 12, 2200, "M", 1.8f, "40-50 years", "Herbivore"),
            new Octapuse("Ollie","Octapuse",20,200,"F",20.7f,"10-20 years","Carnivore"),
            new Bat("Binky","Bat",16,100,"M",300f,"20-15 years","Carnivore"),
            new Monkey("Milo", "Monkey", 6, 20, "M", 0.5f, "15-20 years", "Omnivore"),
            new Dove("Luna", "Dove", 4, 220,"F", 28.5f, "5-10 years" ,"Herbivores"),

        };

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("The Big Five Zoo");
            Console.WriteLine("1. Display all animals");
            Console.WriteLine("2. Add an animal");
            Console.WriteLine("3. Make animals move");
            Console.WriteLine("4. Feed animals");
            Console.WriteLine("5.Which Animal can Fly:");
            Console.WriteLine("6.Which animal can Swim:");
            Console.WriteLine("7.Which animal can Climb:");
            Console.WriteLine("8.Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayAnimals(zooAnimals);
                    break;
                case "2":
                    AddAnimal(zooAnimals);
                    break;
                case "3":
                    MoveAnimals(zooAnimals);
                    break;
                case "4":
                    FeedAnimals(zooAnimals);
                    break;
                case "5":
                    FlyAnimals(zooAnimals);
                    break;
                case "6":
                    SwimAnimals(zooAnimals);
                    break;
                case "7":
                    ClimbAnimals(zooAnimals);
                    break;

                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void ClimbAnimals(List<Animal> zooAnimals)
    {

        foreach (var animal in zooAnimals)
        {
            if (animal is IClimbable Climable)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }

    private static void SwimAnimals(List<Animal> zooAnimals)
    {

        foreach (var animal in zooAnimals)
        {
            if (animal is ISwimmable swimmable)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }

    private static void FlyAnimals(List<Animal> zooAnimals)
    {
        foreach (var animal in zooAnimals)
        {
            if (animal is IFlyable flyable)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }


    private static void DisplayAnimals(List<Animal> zooAnimals)
    {
        Console.WriteLine("Animals in the zoo:");
        foreach (var animal in zooAnimals)
        {
            Console.WriteLine($"{animal.Name} the {animal.Type}");
        }
    }

    private static void AddAnimal(List<Animal> zooAnimals)
    {
        try
        {
            Console.Write("Enter animal type (Lion/Leopard/Rhino/Buffalo/Elephant/Monkey/Dove,Bat/Octapuse): ");
            string type = Console.ReadLine();
            // Check if the entered animal type is valid
            if (!IsValidAnimalType(type))
            {
                throw new InvalidAnimalTypeException($"Invalid animal type: {type}");
            }
            // Check if an animal with the same name already exists in the zoo
            Console.Write("Enter animal name: ");
            string name = Console.ReadLine();
            if (zooAnimals.Any(animal => animal.Name == name))
            {
                throw new AnimalAlreadyExistsException($"An animal with the name '{name}' already exists in the zoo.");
            }
            // Get other details of the animal
            Console.Write("Enter animal age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter animal weight (kg): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Animal Gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Enter height of animal (m): ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Life Expectancy of animal: ");
            string life = Console.ReadLine();
            Console.Write("Type of feed (Carnivore/Herbivore/Omnivore): ");
            string food = Console.ReadLine();

            // Add the animal to the zoo based on the provided details
            switch (type.ToLower())
            {
                case "lion":
                    zooAnimals.Add(new Lion(name, type, age, weight, gender, height, life, food));
                    break;
                case "rhino":
                    zooAnimals.Add(new Rhino(name, type, age, weight, gender, height, life, food));
                    break;
                case "leopard":
                    zooAnimals.Add(new Leopard(name, type, age, weight, gender, height, life, food));
                    break;
                case "elephant":
                    zooAnimals.Add(new Elephant(name, type, age, weight, gender, height, life, food));
                    break;
                case "buffalo":
                    zooAnimals.Add(new Buffalo(name, type, age, weight, gender, height, life, food));
                    break;
                case "monkey":
                    zooAnimals.Add(new Monkey(name, type, age, weight, gender, height, life, food));
                    break;
                case "bat":
                    zooAnimals.Add(new Bat(name, type, age, weight, gender, height, life, food));
                    break;
                case "octapuse":
                    zooAnimals.Add(new Octapuse(name, type, age, weight, gender, height, life, food));
                    break;
                case "dove":
                    zooAnimals.Add(new Dove(name, type, age, weight, gender, height, life, food));
                    break;
                default:
                    // If the type is not recognized, throw an exception
                    throw new InvalidAnimalTypeException($"Invalid animal type: {type}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while adding the animal: {ex.Message}");
        }
    }

    // Helper method to validate animal type
    private static bool IsValidAnimalType(string type)
    {
        string[] validTypes = { "lion", "leopard", "rhino", "buffalo", "elephant", "monkey", "dove", "bat", "octapuse" };
        return validTypes.Contains(type.ToLower());
    }


    private static void MoveAnimals(List<Animal> zooAnimals)
    {
        foreach (var animal in zooAnimals)
        {
            animal.Move();
        }
    }

    private static void FeedAnimals(List<Animal> zooAnimals)
    {
        foreach (var animal in zooAnimals)
        {
            animal.Eat();
        }
    }
}