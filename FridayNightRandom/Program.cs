using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex( string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "burger", "salad", "sushi" }; 
            
            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}.");
        }


        private static void DisplayRandomDrink()
        {
            string[] drinks = { "sprite", "juice", "coca", "fanta" };
            
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}.");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "anime", "cartoons", "thriller", "horrors" };
            
            Console.WriteLine($"Computer picked: {movie[GenerateRandomIndex(movie)]}.");
        }
    }
}
