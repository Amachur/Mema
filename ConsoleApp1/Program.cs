using System;

class Program : ProgramBase
{
    static void Main()
    {
        const int numberOfRows = 3;
        const int numberOfColumnns = 3;
        const int numbersExtracted = 15;
        int[,] bingoCard = ReadBingoCard(numberOfRows, numberOfColumnns);
        int[] numbers = ReadNumbersExtracted(numbersExtracted);
        object value = PrintResult(bingoCard, numbers);
    }

    private static object PrintResult(int[,] bingoCard, int[] numbers)
    {
        throw new NotImplementedException();
    }

    static int[,] ReadBingoCard(int rowsNumber, int columnNumber)
    {
        int[,] card = new int[rowsNumber, columnNumber];

        for (int i = 0; i < rowsNumber; i++)
        {
            string[] array = Console.ReadLine().Split(' ');

            for (int j = 0; j < columnNumber; j++)
            {
                card[i, j] = Convert.ToInt32(array[j]);
            }
        }

        return card;
    }

    static int[] ReadNumbersExtracted(int numbersExtracted)
    {
        int[] numbers = new int[numbersExtracted];

        for (int i = 0; i < numbersExtracted; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        return numbers;
    }



    static bool CheckForBingo(int[,] bingoCard, int[] numbers)
    {
        int numMatchesFound = 0;
        foreach (var number in bingoCard)
        {
            for (int numIndex = 0; numIndex < numbers.Length; numIndex++)
            {
                if (number == numbers[numIndex])
                {
                    numMatchesFound++;
                    break;
                }
            }
        }

        return numMatchesFound == bingoCard.Length;
    }

    private static void PrintResult1(int[,] bingoCard, int[] numbersExtracted)
    {
        if (bingoCard is null)
        {
            throw new ArgumentNullException(nameof(bingoCard));
        }

        if (CheckForBingo(bingoCard, numbersExtracted))
        {
            Console.WriteLine("bingo");
        }
        else if (CheckForLine(bingoCard, numbersExtracted))
        {
            Console.WriteLine("line");
        }
        else
        {
            Console.WriteLine("nothing");
        }
    }

    private static bool CheckForLine(int[,] bingoCard, int[] numbersExtracted)
    {
        throw new NotImplementedException();
    }
}
