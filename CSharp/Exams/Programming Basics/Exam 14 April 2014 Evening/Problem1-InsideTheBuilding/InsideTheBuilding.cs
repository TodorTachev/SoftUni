using System;
using System.Text;

namespace Problem1_InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main()
        {
            StringBuilder output = new StringBuilder();
            int blockSize = int.Parse(Console.ReadLine());
            for (int input = 0; input < 5; input++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                output.AppendLine(IsCoordinatesInside(x, y, blockSize));
            }
            Console.WriteLine(output);
        }

        private static string IsCoordinatesInside(int x, int y, int blockSize)
        {
            if ((x >= 0 && x <= 3 * blockSize && y >= 0 && y <= blockSize) ||
                (x >= blockSize && x <= 2 * blockSize && y >= blockSize && y <= 4 * blockSize))
            {
                return "inside";
            }
            else
            {
                return "outside";
            }
        }
    }
}
