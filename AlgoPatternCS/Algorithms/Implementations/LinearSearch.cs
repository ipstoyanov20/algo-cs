using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class LinearSearch: IBaseSearch
{
    public void Find(int x, int[] arr)
    {
        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                Console.WriteLine($"{x} Found at index {i}");
                found = true;
                break;
            }
        }
        if(!found)
            Console.WriteLine($"{x} Not Found");
    }
}