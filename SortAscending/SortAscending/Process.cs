using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAscending
{
    public class Process
    {
        public static void Show(int[] arr)
        {
            arr.ToList().ForEach(x => { Console.Write(x + "   "); });
            Console.WriteLine();
        }

        public static int GetValue()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


        public static void SortAsc_Basic(int[] arr)
        {
            Console.WriteLine($"Sort Asc array: ");                            // Sort asc
            Array.Sort(arr);
            Show(arr);
        }

        public static void SortDesc_Basic(int[] arr)
        {
            Console.WriteLine($"Sort Asc array: ");                            // Sort desc
            Array.Reverse(arr);
            Show(arr);
        }

        public static void SortArrayAsc(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public static void SortArrayDesc(int[] arr)
        {
            QuickSortv2(arr, 0, arr.Length - 1);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot) 
                    i++;

                while (arr[j] > pivot) 
                    j--;

                if (i <= j)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) 
                QuickSort(arr, left, j);

            if (i < right) 
                QuickSort(arr, i, right);
        }

        public static void QuickSortv2(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i >= j)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left > j)
                QuickSortv2(arr, left, j);

            if (i < right)
                QuickSortv2(arr, i, right);
        }
    }
}
