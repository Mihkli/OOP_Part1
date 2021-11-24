using System;

namespace OOP_PartI
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots) //constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");

            }

            //getters
            public string Name //Name getter
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }
            public void Wags()
            {
                Console.WriteLine($"{Name}: Wiggle-wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }
            public void showdogdata()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Spots: {Spots}");
                Console.WriteLine($"Level of happiness: {Happiness}");
            }
        }
        

        static void Main(string[] args)
        {
            Dog mydog = new Dog("Sulg", 15);
            mydog.Barks();
            Console.WriteLine($"{mydog.Name}'s level of happiness: {mydog.Happiness}");
            Dog newdog = new Dog("Piirut", 2);
            Console.WriteLine($"{newdog.Name}'s level of happiness: {newdog.Happiness}");

            while(mydog.Happiness != 1)
            {
                mydog.Barks();
            }
            mydog.Wags();

            Console.WriteLine($"Enter a new name for the dog '{mydog.Name}'");
            string userinput = Console.ReadLine();
            mydog.Rename(userinput);
            mydog.showdogdata();
        }
    }
}
