using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"A cat named {name} has appeared!");
            }
            public string Name //Name getter
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void Sleep()
            {
                Console.WriteLine("*Sleeps*");
                hungriness += 0.2; 
            }
            public void showcatdata()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine($"Level of Hungriness: {Hungriness}");
            }
            public void Meow()
            {
                Console.WriteLine($"{Name} meows.");
            }
        }

        static void Main(string[] args)
        {
            Cat mycat = new Cat("Tiff", "Black");
            
            while(mycat.Hungriness != 1)
            {
                mycat.Sleep();
            }
            mycat.Meow();
            Console.WriteLine($"Do u wish the see the cats properties. If yes press '.', if no press 'n'");
            string userinput = Console.ReadLine();
            if (userinput == ".")
            {
                mycat.showcatdata();
            }
            else
            {
                mycat.Meow();
            }
        }
    }
}
