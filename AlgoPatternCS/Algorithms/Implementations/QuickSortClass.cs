using System.Data;
using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class QuickSortClass : IBase, IQuickSort
{
    public void Run(int[] arr)
    {
        Console.WriteLine("Original array: " + string.Join(", ", arr));

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", arr));    }

    public void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }

    public int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        int i = left - 1;

        for (int j = left + 1; j <= right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[left];
        arr[left] = temp1;

        return i + 1;
    }
}