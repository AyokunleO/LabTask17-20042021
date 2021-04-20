using System;

namespace SequenceOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 4,9,16,9,7,4,9,11};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += numbers[i];
                }else{
                    sum -= numbers[i];
                }  
            }Console.WriteLine($"Sum is {sum}");
        }
    }
}
