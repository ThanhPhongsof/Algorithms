using SortAscending;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter element into the array:");
int n = Process.GetValue();                                                 // Get Value

int[] arr = new int[n];
for (int i = 0; i < n; i++)                                                 // Loop
{
    Console.WriteLine($"Value {i}: ");
    arr[i] = Process.GetValue();
}
Console.WriteLine($"Array: ");                                              // Array no sort
Process.Show(arr);

//Process.SortAsc_Basic(arr);
//Process.SortDesc_Basic(arr);

//Console.WriteLine($"Sort Asc array by QuickSort: ");                         // Array
//Process.SortArrayAsc(arr);
//Process.Show(arr);

Console.WriteLine($"Sort Asc array by QuickSort: ");                         // Array
Process.SortArrayDesc(arr);
Process.Show(arr);



