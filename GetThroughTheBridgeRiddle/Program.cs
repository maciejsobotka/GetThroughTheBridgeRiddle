using System;
using System.Linq;

namespace GetThroughTheBridgeRiddle
{
    internal class Program
    {
        #region Private methods

        private static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Gimmie some sprinters");
                    string sprintersString = Console.ReadLine();
                    string[] sprintersStringTab = sprintersString.Split(' ');
                    int[] sprinters = sprintersStringTab.Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine($"Fastest way to get through: {Algorithm.GetAllThroughTheBridge(sprinters)}");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        #endregion
    }
}