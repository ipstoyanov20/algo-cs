using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class SelectionSortClass : ISelectionSort, IBase
{
    public void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if(arr[j] < arr[minIndex]) minIndex = j;
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i]= temp;
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