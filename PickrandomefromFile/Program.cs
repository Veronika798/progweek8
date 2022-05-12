using System;
using System.IO;

namespace PickrandomefromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("food.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");


            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
            
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"BOOTCAMP C:\Users\veron\samples\{fileName}";
            // kasutam Maci peal bootcampi abil windowsid, ei saanud aru miks ei toota ja kuidas teha
            string[] datafromFile = File.ReadAllLines(filePath);
            string randomElement = datafromFile[GenerateRandomIndex(datafromFile)];

            return randomElement;
        }

    }
}
