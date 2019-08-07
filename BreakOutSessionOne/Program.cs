using System;
using System.Collections.Generic;

namespace BreakOutSessionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can I have your age please?");
            var input = Console.ReadLine();
            int inputNumber;


            while(true)
            {
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Please enter a valid input.");
                    return;
                }

                if (inputNumber < 21)
                {
                    Console.WriteLine("Please enter an age Greater than 21");
                    return;
                }

                break;
            }

            Console.WriteLine("What do you want to drink?");

            var drinkList = new List<string>();
            drinkList.Add("Old Fashion");
            drinkList.Add("PBR");
            drinkList.Add("Bloody Mary");

            foreach (var drink in drinkList)//for each item in your drink list I want to do x
            {
                Console.WriteLine(drink);
            }


            while(true)
            {
                foreach (var drink in drinkList)//for each item in your drink list I want to do x
                {
                    Console.WriteLine(drink);
                }

                var userDrink = Console.ReadLine();
                var isDrinkEqual = false;

                foreach (var drink in drinkList)
                {
                    if (drink.Equals(userDrink, StringComparison.OrdinalIgnoreCase))
                    {
                        isDrinkEqual = true;
                    }
                }

                if (isDrinkEqual)
                {
                    break;
                }

                Console.WriteLine("Drink does not exist in list.");
                Console.WriteLine("What do you want to drink?");
            }
        }
    }
}
