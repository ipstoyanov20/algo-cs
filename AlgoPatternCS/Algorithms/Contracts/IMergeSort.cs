namespace AlgoPatternCS.Algorithms.Contracts;

public interface IMergeSort
{
      void MergeSort(int[] arr, int left, int right);
      void Merge(int[] arr, int left, int mid, int right);

}