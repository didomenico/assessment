using System;
using System.Linq;

namespace Assessment2
{
    class Solution
    {
        static readonly Action<string> print = Console.WriteLine;

        public int solution(int[] A)
        {
            //int[] sorted = new SortedSet<int>(A).ToArray();
            int[] sorted = HeapSort(A);

            int leftTupleProduct = sorted[0] * sorted[1];
            int rightTupleProduct = sorted[sorted.Length - 3] * sorted[sorted.Length - 2];

            int largestTupleProduct = leftTupleProduct > rightTupleProduct ? leftTupleProduct : rightTupleProduct;
            return largestTupleProduct * A.Last();
        }

        // Worst-case time complexity: O(n*log n)    
        // Worst-case space complexity: O(1)
        public int[] HeapSort(int[] unsorted)
        {       
            int[] sorted = MaxHeap(unsorted);
            
            for (int n = sorted.Length - 1; n > 0; n--)
            {
                (sorted[0], sorted[n]) = (sorted[n], sorted[0]);

                sorted = Heapify(sorted, 0, n);

                print("n = " + n + "  ");
                DrawHeap(sorted);
            }            

            return sorted;
        }

        public int[] MaxHeap(int[] array)
        {
           for (int i = array.Length / 2 - 1; i >= 0; i--)
           {
                array = Heapify(array, i);
           }

            return array;
        }

        public int[] Heapify(int[] array, int i, int n = -1)
        {
            if (n == -1) { n = array.Length; }

            int left = 2 * i + 1;
            int right = 2 * i + 2;            

            bool isLeaf = left >= n;
            if(isLeaf) { return array; }

            bool hasSingleChild = (n == 2 * i + 2);
            int larger = hasSingleChild ||
                         array[left] > array[right] ?
                         left : right;

            if (array[larger] > array[i])
            { // Swap
                (array[i], array[larger]) = (array[larger], array[i]);
                
                array = Heapify(array, larger, n);
            }
            
            return array;
        }        

        static public void Main(String[] args)
        {
            print("===============================\n");
            print("MAX. TRIPLET PRODUCT: " + new Solution().solution(
                new int[] { 5, 97, 64, -93, 37, 90, -102 } ).ToString("N0") + "\n");
            print("===============================");
        }

        public static void DrawHeap(int[] array)
        {

            Console.Write("[");
            foreach (int value in array) { Console.Write(value + " | "); }
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.WriteLine("]\n");


            for (int i = 0; i < array.Length; i++)
            {   // Quick & dirty approach, optimize later if necessary
                if (i == 0 || i == 1 || i == 3 || i == 7|| i == 15)
                {                    
                    Console.Write(new string(' ', (int)(1.5*array.Length - 1.7*i)));
                }           

                Console.Write("( " + array[i] + " )");

                if (i == 0 || i == 2 || i == 6 || i == 14)
                {
                    Console.WriteLine();
                }
            }            

            Console.ReadLine();
        }
    }
}
