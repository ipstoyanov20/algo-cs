using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class SelectionSortClass : ISelectionSort, IBase
{
    public void SelectionSort(int[] arr)
    {
        
        int n = arr.Length;
        for(int i = 0; i <= n - 1; i++)
        {
            int minIn = i;
            for(int j = i + 1; j <= n; j++)
            {
                if(arr[j] < arr[minIn]) minIn = j;
            }
            int temp = arr[minIn];
            arr[minIn] = arr[i];
            arr[i] = temp;
        }
    }

    public void Run(int[] arr)
    {
        Console.WriteLine("Original " + string.Join(",", arr));
        SelectionSort(arr);
        Console.WriteLine("Sorted array: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}