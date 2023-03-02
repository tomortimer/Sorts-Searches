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

        static int[] bubbleSortFor(int[] arr)
        {
            //complexity O(n^2)
            for(int x = 0; x < arr.Length - 1; x++)
            {
                //-x for fasterness
                for(int y = 0; y < arr.Length - 1 - x; y++)
                {
                    if(arr[y] > arr[y + 1])
                    {
                        //swap values
                        int tmp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = tmp;
                    }
                }
            }
            return arr;
        }

        static int[] bubbleSortWhile(int[] arr)
        {
            bool sorted = false;
            int x = 0;
            //sorted something seotnhing probably more efficient because for loop can detect if array is sorted and quite out if so
            while (!sorted)
            {
                sorted = true;
                for (int y = 0; y < arr.Length - 1 - x; y++)
                {
                    if(arr[y] > arr[y + 1])
                    {
                        int tmp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = tmp;
                        sorted = false;
                    }
                }
            }
            return arr;
        }
    }
}
