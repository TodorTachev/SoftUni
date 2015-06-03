using System;

namespace Problem2_StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int joinedCable = 3;
            int cables = int.Parse(Console.ReadLine());
            for (int input = 0; input < cables; input++)
            {
                int cableLength = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    cableLength *= 100;
                }
                if (cableLength >= 20)
                {
                    joinedCable += cableLength;
                    joinedCable -= 3;
                }
            }
            Console.WriteLine(joinedCable / 504);
            Console.WriteLine(joinedCable % 504);
        }
    }
}
