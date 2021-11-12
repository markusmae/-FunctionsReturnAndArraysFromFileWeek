using System;

namespace FridayNightRamdonReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movie = { "The Godfather", "Pulp Fiction", "Wolf of Wallstreet", "Spirited Away", "Catch me if you can" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movie);
            Console.WriteLine($"Tonight you will havce some {randomFood} with {randomDrink} and watch {randomMovie}.");
        }

        private static int rndindex(string[] someArray)
        {
            Random rnd = new Random();
            int randomi = rnd.Next(0, someArray.Length);

            return randomi;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[rndindex(someArray)];

            return randomElement;
        }


    }
}