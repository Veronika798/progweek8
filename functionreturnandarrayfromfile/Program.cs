using System;

namespace functionreturnandarrayfromfile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();

        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "burger", "salad", "sushi" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}.");
        }


        private static void DisplayRandomDrink()
        {
            string[] drinks = { "sprite", "juice", "coca", "fanta"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}.");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "anime", "cartoons", "thriller", "horrors" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movie.Length);

            string randomMovie = movie[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}.");
        }
    }
} 
