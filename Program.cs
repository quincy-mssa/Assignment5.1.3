using System;

namespace Assignment5._1._3
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array elements separated by spaces: ");
            string input = Console.ReadLine();
            int[] nums = Array.ConvertAll(input.Split(), int.Parse);

            bool result = ContainsDuplicate(nums);
            Console.WriteLine($"Contains duplicates: {result}");
        }

        static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numCounts.ContainsKey(num))
                {
                    return true;
                }
                numCounts[num] = 1;
            }

            return false;
        }
    }
}
