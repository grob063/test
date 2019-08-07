using System;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinosaur = new Dinosaur(500);


            Console.WriteLine($"I am {dinosaur.Age} years old");

            var output = dinosaur.Roar("Huuungry");

            Console.WriteLine(output);

            Animal animal = new Dinosaur(600);
            animal.SaySomething();
            dinosaur.SaySomething();
        }
    }
}
