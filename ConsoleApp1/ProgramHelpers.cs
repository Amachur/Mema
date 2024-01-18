using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoCard
{
    internal class Program
    {
        private const int BingoSpacing = 5;
        private const int BingoBallBuckets = 15;
        private const int BingoCardLength = 5;

        private static Random random = new Random();

        static void Main()
        {
            var table = new string[BingoCardLength, BingoCardLength];
            PopulateBingoBoard(table);
            PrintBoard(table);

            Console.ReadKey();
        }

        private static void PopulateBingoBoard(string[,] table)
        {
            for (var col = 0; col < table.GetLength(0); col++)
            {
                var allNumbers = Enumerable.Range(1 + (col * BingoBallBuckets), BingoBallBuckets).ToList();

                for (var row = 0; row < table.GetLength(1); row++)
                {
                    var chosenIndex = random.Next(allNumbers.Count);
                    table[row, col] = allNumbers[chosenIndex].ToString();
                    allNumbers.RemoveAt(chosenIndex);
                }
            }

            table[table.GetLength(0) / 2, table.GetLength(1) / 2] = "FREE";
        }

        private static void PrintBoard(string[,] table)
        {
            Console.WriteLine(new string('-', BingoSpacing * BingoCardLength + BingoCardLength + 1));

            Console.Write("|");
            string[] headings = { "B", "I", "N", "G", "O" };
            for (var i = 0; i < headings.Length; i++)
            {
                Console.Write(headings[i].PadRight(BingoSpacing) + "|");
            }
            Console.WriteLine();

            Console.WriteLine(new string('-', BingoSpacing * BingoCardLength + BingoCardLength + 1));

            for (var i = 0; i < table.GetLength(0); i++)
            {
                Console.Write("|");
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j].PadRight(BingoSpacing) + "|");
                }
                Console.WriteLine();

                Console.WriteLine(new string('-', BingoSpacing * BingoCardLength + BingoCardLength + 1));
            }
        }
    }
}
