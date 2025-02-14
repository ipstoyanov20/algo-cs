using AlgoPatternCS.Algorithms.Contracts;
using AlgoPatternCS.Algorithms.Implementations;

namespace AlgoPatternCS;
class Program
{
    
    static void Main(string[] args)
    {
        
        IBase algo = new InsertionSortClass();
        
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        algo.Run(arr);
    }
}