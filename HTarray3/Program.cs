using System;

namespace HTarray3
{
    class Program
    {
        static void AtherSide(ref int[] array)
        {
            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write(array[^i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 5, 6, 7, 8, 9 };

            AtherSide(ref myArray);
        }
    }
}
