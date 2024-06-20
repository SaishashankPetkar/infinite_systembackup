using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicproject
{
    public class array
    {
        public static void singledimentionarr()
        {
            int x,i;
            Console.WriteLine("Enter the length of array");
            x = int.Parse(Console.ReadLine()); 
            int[] arr = new int[x];

            for( i=0; i<arr.Length; i++)
            {
                Console.Write($"Enter the {i+1} element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int j in arr)
            {
                Console.WriteLine($"The elemets of array are: {j}");
            }
            int max = arr.Max();
            Console.WriteLine("The max element in array is : " + max);
            Array.Sort(arr);

        }
    }
}
