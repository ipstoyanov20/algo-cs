namespace AlgoPatternCS.Patterns;

public sealed class Singleton
{
    public static void TestSinglton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);

    }

    public static void Run()
    {
        Thread process1 = new Thread(() =>
        {
            TestSinglton("FOO");
        });
        
        Thread process2 = new Thread(() =>
        {
            TestSinglton("DOS");
        });
        
        process1.Start();
        process2.Start();
        
        process2.Join();
        process2.Join();
    }
    
    private Singleton() {}

    public string Value { get; set; }
    private static readonly object _lock = new object(); 
    
    private static Singleton _instance;

    public static Singleton GetInstance(string val)
    {
        if (_instance == null)
        {
            lock (_lock)
            {

                if (_instance == null)
                {
                        _instance = new Singleton();
                        _instance.Value = val;
                }
            }
        }

        return _instance;
    }

}