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
            QuickSortForAscending(arr, 0, arr.Length - 1);
        }

        public static void SortArrayDesc(int[] arr)
        {
            QuickSortForDescending(arr, 0, arr.Length - 1);
        }

        public static void QuickSortForAscending(int[] arr, int left, int right)
        {
            int teamp;

            if (left < right)
            {
                int middle = arr[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;

                while (true)
                {
                    while (arr[++i] < middle && i < right) ; // fine elements smaller than the middle value form the left
                    while (arr[--j] > middle && j > 0) ;     // fine elements large than the middle value form the right

                    if (i >= j)
                        break;

                    teamp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = teamp;
                }

                QuickSortForAscending(arr, left, i - 1);
                QuickSortForAscending(arr, j + 1, right);
            }
        }

        public static void QuickSortForDescending(int[] arr, int left, int right)
        {
            int teamp;

            if (left < right)
            {
                int middle = arr[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;

                while (true)
                {
                    while (arr[++i] > middle && i < right) ; // fine elements smaller than the middle value form the left
                    while (arr[--j] < middle && j > 0) ;     // fine elements large than the middle value form the right

                    if (i >= j)
                        break;

                    teamp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = teamp;
                }

                QuickSortForDescending(arr, left, i - 1);
                QuickSortForDescending(arr, j + 1, right);
            }
        }
    }
}
