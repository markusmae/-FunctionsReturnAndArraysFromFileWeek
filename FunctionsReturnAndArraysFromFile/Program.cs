using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            Displayrandomdrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = {"chicken wings", "pizza", "sushi", "popcorn", "salad"};
            Random rnd = new Random();
            int random = rnd.Next(0, foods.Length);

            string randomFood = foods[random];
            Console.WriteLine($"Computer picked: {randomFood}");
        }

        private static void Displayrandomdrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite"};
            Random rnd = new Random();
            int random = rnd.Next(0, drinks.Length);

            string randomdrink = drinks[random];
            Console.WriteLine($"Computer picked: {randomdrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "The Godfather", "Pulp Fiction", "Wolf of Wallstreet", "Spirited Away", "Catch me if you can" };
            Random rnd = new Random();
            int random = rnd.Next(0, movie.Length);

            string randommovie = movie[random];
            Console.WriteLine($"Computer picked: {randommovie}");
        }

    }
}
