using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChuck;
            randomChuck = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"{randomChuck}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"BOOTCAMP C:\Users\veron\samples\chuck.txt";
            // kasutam Maci peal bootcampi abil windowsid, ei saanud aru miks ei toota ja kuidas teha
            string[] datafromFile = File.ReadAllLines(filePath);
            string randomElement = datafromFile[GenerateRandomIndex(datafromFile)];

            return randomElement;
        }
    }
}
