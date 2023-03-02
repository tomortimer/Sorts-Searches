using System;

namespace SortAndSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aihraiohawg = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(binarySearch(aihraiohawg, 3));
            Console.WriteLine(binarySearch(aihraiohawg, 1));
            Console.WriteLine(binarySearch(aihraiohawg, 6));
            Console.WriteLine(binarySearch(aihraiohawg, 5));
            Console.WriteLine(binarySearch(aihraiohawg, 7));
        }

        static int binarySearch(int[] arr, int val)
        {
            int lower = 0;
            int higher = arr.Length - 1;
            int mid = 0;
            bool found = false;

            
            while (found == false && lower <= higher)
            {
                //calculate midpoint
                mid = (lower + higher) / 2;
                if (arr[mid] == val) { found = true; }
                else if (val < arr[mid]) { higher = mid - 1; }
                else { lower = mid + 1; }

                //:(
                //if (arr[higher] == val) { found = true; mid = higher; }
            }

            if (!found) { mid = -1; }

            return mid;
        }
    }
}
