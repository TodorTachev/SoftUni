using System;
using System.Text;


namespace Problem3_ProgrammerDNA
{
    class ProgrammerDNA
    {
        private static char letter;

        static void Main()
        {
            int chainLength = int.Parse(Console.ReadLine());
            letter = Convert.ToChar(Console.ReadLine());
            for (int row = 0; row < chainLength; row++)
            {
                switch (row % 7)
                {
                    case 0:
                    case 6:
                        PrintRow(1);
                        break;
                    case 1:
                    case 5:
                        PrintRow(3);
                        break;
                    case 2:
                    case 4:
                        PrintRow(5);
                        break;
                    case 3:
                        PrintRow(7);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintRow(int numberOfLetters)
        {
            StringBuilder lettersOnRow = new StringBuilder();
            for (int letter = 0; letter < numberOfLetters; letter++)
            {
                lettersOnRow.Append(GetLetter());
            }
            string dots = new String('.', (7 - numberOfLetters) / 2);
            Console.WriteLine(dots + lettersOnRow + dots);
        }

        private static char GetLetter()
        {
            char result = letter;
            if (letter == 'G')
            {
                letter = 'A';
                return result;
            }
            letter = (char)((byte)letter + 1);
            return result;
        }
    }
}
