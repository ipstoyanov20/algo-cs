using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class InsertionSortClass : IInsertionSort, IBase
{
    public void Run(int[] arr)
    {
        Console.WriteLine("Original " + string.Join(",", arr));
        InsertionSort(arr);
        Console.WriteLine("Sorted array: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }

            arr[j + 1] = key;
        }
    }
}