using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class MergeSortClass : IMergeSort, IBase
{
    public void MergeSort(int[] arr, int left, int right)
    {
        if(left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    public void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];
        
        
        
        Array.Copy(arr, left, leftArr, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArr, 0, rightSize);

        int i = 0, j = 0, k = left;
        while (i < leftSize && j < rightSize)
        {
            arr[k++] = (leftArr[i] <= rightArr[j]) ? leftArr[i++] : rightArr[j++];
        }

        while (i < leftSize)
        {
            arr[k++] = leftArr[i++];
        }
        while (j < rightSize)
        {
            arr[k++] = rightArr[j++];
        }


    }

    public void Run(int[] arr)
    {
        Console.WriteLine("Original " + string.Join(",", arr));
        IMergeSort algo = new MergeSortClass();
        
        algo.MergeSort(arr, 0, arr.Length - 1);
        

        Console.WriteLine("Sorted " + string.Join(",", arr));
    }
}