internal class ProgramBase
{

    private static bool CheckForLine(int[,] bingoCard, int[] numbers)
    {
        for (int row = 0; row < bingoCard.GetLength(0); row++)
        {
            int colMatchesInRow = 0;

            for (int col = 0; col < bingoCard.GetLength(1); col++)
            {
                for (int numIndex = 0; numIndex < numbers.Length; numIndex++)
                {
                    if (bingoCard[row, col] != numbers[numIndex])
                    {
                        continue;
                    }

                    colMatchesInRow++;
                    break;
                }
            }
        }
    }
}