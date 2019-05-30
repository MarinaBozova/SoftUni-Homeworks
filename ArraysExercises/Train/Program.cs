using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
                sum += number;
            }
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine(sum);
        }
    }
}
