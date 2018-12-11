using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to find");
            int num = int.Parse(Console.ReadLine());
            int[] arr =new int[] { 1, 28, 34, 4, 53, 6, 71, 82, 9, 10, 15, 16, 84, 65, 21, 64, 47 };
            int index = BinarySearch(arr,num);

            Console.WriteLine(index);
            foreach (var item in arr)
            {
                Console.WriteLine(BinarySearch(arr, item));
            }
        }

        private static int BinarySearch(int[] nums, int valueToSearch)
        {
            for (int start = 0, end = nums.Length - 1; start <= end;)
            {
                int middleIndex = (start + end) / 2;
                if (nums[middleIndex] == valueToSearch)
                {
                    return middleIndex;
                }
                else if (valueToSearch < nums[middleIndex])
                {
                    end = middleIndex - 1;
                }
                else
                {
                    start = middleIndex + 1;
                }

            }
            return -1;
        }
    }
}
