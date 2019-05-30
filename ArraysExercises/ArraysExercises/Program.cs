using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] peeps = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < peeps.Length; j++)
                {
                    sum += peeps[i];
                }
                Console.Write(string.Join(" ", peeps));
            }
            Console.WriteLine($"{sum}");
        }
    }
}
