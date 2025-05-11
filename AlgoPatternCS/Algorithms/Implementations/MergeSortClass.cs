using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class MergeSortClass : IMergeSort, IBase
{
    public void MergeSort(int[] arr, int l, int r)
    {
        if(l>=r) return;
        int mid = l + (r - l) / 2;
        MergeSort(arr, l, mid);
        MergeSort(arr, mid + 1, r);
        Merge(arr, l, mid, r);
    }

    public void Merge(int[] arr, int l, int m, int r)
    {
        int lsize = m - l + 1;
        int rsize = r - m;

        int[] larr = new int[lsize];
        int[] rarr = new int[rsize];
        
        Array.Copy(arr, l, larr, 0, lsize);
        Array.Copy(arr, m + 1, rarr, 0, rsize);

        int i = 0, j = 0, k = l;
        while (i < lsize && j < rsize)
        {
            arr[k++] = (rarr[j] <= larr[i]) ? rarr[j++] : larr[i++];
        }

        while (i < lsize)
        {
            arr[k++] = larr[i++];
        }
        
        while (j < rsize)
        {
            arr[k++] = rarr[j++];
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