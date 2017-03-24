using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static int pivot; //instantiate pivot var
        public static int maxNumber; //instantiate maxNumber var

        public static void selectKth(int[] arr, int k) //selection rank algorithm
        {
            int from = 0, to = arr.Length - 1;

            // if from == to we reached the kth element
            while (from < to)
            {
                int r = from, w = to;
                int mid = arr[(r + w) / 2];

                // stop if the reader and writer meets
                while (r < w)
                {

                    if (arr[r] >= mid)
                    { // put the large values at the end
                        int tmp = arr[w];
                        arr[w] = arr[r];
                        arr[r] = tmp;
                        w--;
                    }
                    else
                    { // the value is smaller than the pivot, skip
                        r++;
                    }
                }

                // if we stepped up (r++) we need to step one down
                if (arr[r] > mid)
                    r--;

                // the r pointer is on the end of the first k elements
                if (k <= r)
                {
                    to = r;
                }
                else
                {
                    from = r + 1;
                }

                pivot = k;
            }
        }

        static void Main(string[] args)
        {
            //initialize array
            int[] arr = { 8,7,6,5,4,3,2,1,0};

            Console.WriteLine("Please enter a max number for search: ");
            string userEntry = Console.ReadLine();
            maxNumber = Convert.ToInt32(userEntry);

            //call algorithm and pass it the array and set the max number of search
            selectKth(arr, maxNumber);

            //write all elements that are less than max number and greater than the max number given above
            try
            {
                for (int i = 0; i < arr[pivot]; i++)
                {
                    Console.WriteLine(arr[i] + " is smaller than max number of " + pivot);
                }
                for (int i = pivot; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + " is greater than or equal to " + pivot);
                }
             } catch
            {
                Console.WriteLine("Search number cannot be greater than maximum number within data!");
            }

            //done
            Console.ReadKey();
        }

    }
}
