using System;

namespace Fridaynightrandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            Displayrandomdrink();
            DisplayRandomMovie();
        }

        private static int rndindex(string[] someArray)
        {
            Random rnd = new Random();
            int randomi = rnd.Next(0, someArray.Length);

            return randomi;
        }
      

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
                        
            Console.WriteLine($"Computer picked: {foods[rndindex(foods)]}");
        }

        private static void Displayrandomdrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
                                   
            Console.WriteLine($"Computer picked:  {drinks[rndindex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "The Godfather", "Pulp Fiction", "Wolf of Wallstreet", "Spirited Away", "Catch me if you can" };
                                   
            Console.WriteLine($"Computer picked: {movie[rndindex(movie)]}");
        }
    }
}
