using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4_MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main()
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int magicWeight = int.Parse(Console.ReadLine());
            List<string> carNumbers = new List<string>();
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int X = 0; X < letters.Length; X++)
                    {
                        for (int Y = 0; Y < letters.Length; Y++)
                        {
                            if (40 + 4 * a + ((int)letters[X] % 32) * 10 + ((int)letters[Y] % 32) * 10 == magicWeight)
                            {
                                carNumbers.Add(string.Format("CA{0}{0}{0}{0}{1}{2}", a, letters[X], letters[Y]));
                            }
                            if (40 + 3 * a + b + ((int)letters[X] % 32) * 10 + ((int)letters[Y] % 32) * 10 == magicWeight)
                            {
                                carNumbers.Add(string.Format("CA{0}{0}{0}{1}{2}{3}", a, b, letters[X], letters[Y]));
                            }
                            if (40 + 3 * b + a + ((int)letters[X] % 32) * 10 + ((int)letters[Y] % 32) * 10 == magicWeight)
                            {
                                carNumbers.Add(string.Format("CA{0}{1}{1}{1}{2}{3}", a, b, letters[X], letters[Y]));
                            }
                            if (40 + 2 * a + 2 * b + ((int)letters[X] % 32) * 10 + ((int)letters[Y] % 32) * 10 == magicWeight)
                            {
                                carNumbers.Add(string.Format("CA{0}{0}{1}{1}{2}{3}", a, b, letters[X], letters[Y]));
                                carNumbers.Add(string.Format("CA{0}{1}{1}{0}{2}{3}", a, b, letters[X], letters[Y]));
                                carNumbers.Add(string.Format("CA{0}{1}{0}{1}{2}{3}", a, b, letters[X], letters[Y]));
                            }
                        }
                    }
                }
            }
            Console.WriteLine(carNumbers.Distinct().Count());
        }
    }
}