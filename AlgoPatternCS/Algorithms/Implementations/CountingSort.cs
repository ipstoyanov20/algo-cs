using System.ComponentModel;
using AlgoPatternCS.Algorithms.Contracts;

namespace AlgoPatternCS.Algorithms.Implementations;

public class CountingSort : ICountingSort, IBase
{
    public void Run(int[] arr)
    {
        Console.WriteLine("Original " + string.Join(",", arr));
        CountingS(arr);
        Console.WriteLine("Sorted arr: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
            //if last iteration display /n
            if (item == arr[arr.Length - 1])
            {
                Console.WriteLine();
            }
            
        }
    }

    public void CountingS(int[] arr)
    {
        if (arr.Length == 0) return;
        //намираме мин макс
        int min = 0, max = 0;
        foreach (var num in arr)
        {
            if (num > max) max = num;
            else if (num < min) min = num;
        }
        //отиваме към попълване на count
        int range = max - min + 1;
        int[] count = new int[range];
        foreach (var num in arr)
        {
            count[num - min]++;
        }
        // намираме комулативната
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        int[] output = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int val = arr[i];
            count[val - min]--;
            output[count[val - min]] = val;
        }
        
        Array.Copy(output, 0, arr, 0, arr.Length);


    }
}