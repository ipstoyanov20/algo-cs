using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class BinarySearch : IBaseSearch
{
    public void Find(int x, int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
            {
                Console.WriteLine($"{x} Found at index {mid}");
                found = true;
                break;
            }
            else if (arr[mid] < x)
            {
                // Търсим в дясната половина на масива
                left = mid + 1;
            }
            else
            {
                // Търсим в лявата половина на масива
                right = mid - 1;
            }
        }

        if (!found)
        {
            Console.WriteLine($"{x} Not Found");
        }
    }

}