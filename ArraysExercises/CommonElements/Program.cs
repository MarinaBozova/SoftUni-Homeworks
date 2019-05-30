using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            //bool areCommon = secondArray.SequenceEqual(firstArray);
            CheckIfEqual(firstArray, secondArray);
        }

        private static void CheckIfEqual(string[] firstArray, string[] secondArray)
        {
           
        }
    }
}
