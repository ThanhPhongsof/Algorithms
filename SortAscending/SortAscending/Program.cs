using SortAscending;

Console.Write("Please enter element into the array:");
int n = Process.GetValue();                                                 // Get Value

int[] arr = new int[n];
for (int i = 0; i < n; i++)                                                 // Loop
{
    Console.WriteLine($"Value {i}: ");
    arr[i] = Process.GetValue();
}

//int[] arr = new int[] { -50, -1, 50, 40, 10, 11, 2, 4, 8, 178 };
int[] oldArr = arr;
Console.WriteLine($"Array: ");                                              // Array no sort
Process.Show(arr);

//Process.SortAsc_Basic(arr);
//Process.SortDesc_Basic(arr);

Console.WriteLine($"Sort Asc array by QuickSort: ");                         // Array
Process.SortArrayAsc(arr);
Process.Show(arr);

Console.WriteLine($"Sort Desc array by QuickSort: ");                         // Array
Process.SortArrayDesc(oldArr);
Process.Show(oldArr);



