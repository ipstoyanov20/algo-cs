using AlgoPatternCS.Algorithms.Contracts;
using AlgoPatternCS.Algorithms.Implementations;
using AlgoPatternCS.Patterns;

namespace AlgoPatternCS;
class Program
{
    public static  void ShowProg(Progress progress)
    {
        Console.WriteLine(progress.ProgressNumber);
    }
    static void Main(string[] args)
    {
        // PROTOTYPE
        // CarPrototype prototypePattern = new CarPrototype();
        // prototypePattern.Run();

        // SINGLETON
        //Singleton.Run(); 
        
        //Command
        // var worker = new Worker();
        // var command = CommandBuilder.CreateFrom<Progress>(ShowProg);
        // worker.LoadData(command);

        //SORTING AND FINDING ALGO
        IBase algo = new QuickSortClass();
        IBaseSearch s = new BinarySearch();
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        algo.Run(arr);
        s.Find(3, arr);
    }
}