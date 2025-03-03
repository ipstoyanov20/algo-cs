namespace AlgoPatternCS.Algorithms.Contracts;

public interface IQuickSort
{
    void QuickSort(int[] arr, int left, int right);

    int Partition(int[] arr, int left, int right);
    
    
}