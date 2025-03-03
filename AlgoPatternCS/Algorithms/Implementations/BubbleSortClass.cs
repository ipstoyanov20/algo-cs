using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class BubbleSortClass : IBubbleSort, IBase
{
    public void Run(int[] arr)
    {
        Console.WriteLine("Original " + string.Join(",", arr));
        BubbleSort(arr);
        Console.WriteLine("Sorted array: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}