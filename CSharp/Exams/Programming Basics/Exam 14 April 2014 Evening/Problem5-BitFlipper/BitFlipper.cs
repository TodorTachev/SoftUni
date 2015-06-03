using System;
using System.Text;
using System.Numerics;

namespace Problem5_BitFlipper
{
    class BitFlipper
    {
        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());
            string binary = Convert.ToString((long)input, 2).PadLeft(64, '0');
            StringBuilder bitMask = new StringBuilder(new String('0', 64));
            for (int index = 0; index < binary.Length - 2; index++)
            {
                if (binary[index] == binary[index + 1] && binary[index] == binary[index + 2])
                {
                    bitMask[index] = '1';
                    bitMask[index + 1] = '1';
                    bitMask[index + 2] = '1';
                    index += 2;
                }
            }

            ulong mask = Convert.ToUInt64(bitMask.ToString(), 2);
            BigInteger result = input ^ mask;
            Console.WriteLine(result);
        }
    }
}
