using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = RandomFromFile("chuck.txt");
            Console.WriteLine(randomJoke);
        }

        private static int GenerateNr(string[] someArray)
        {
            Random rnd = new Random();
            int randomI = rnd.Next(0, someArray.Length);
            return randomI;
        }

        private static string RandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateNr(dataFromFile)];
            return randomElement;
                       
        }
        
    }
}
