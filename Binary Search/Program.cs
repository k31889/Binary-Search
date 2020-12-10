using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 6, 10 };
            int lower = 0;
            int upper = A.Length - 1; //Array length
            int mid = 0;
            int search = 3;
            bool found = false;

            while (found == false && lower <= upper)
            {
                mid = upper + lower / 2;
                if (A[mid] == search)
                {
                    found = true;
                    Console.WriteLine("Found");
                }
                if (A[mid] > search)
                {
                    upper = mid - 1;
                }
                if (A[mid] < search)
                {
                    lower = mid + 1;
                }
            }
        }
    }
}
