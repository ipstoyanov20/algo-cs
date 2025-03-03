namespace AlgoPatternCS.Patterns;


public interface IStrategy
{
    object Algo(object data);
}

public class Context
{
    private IStrategy _strategy;

    public Context()
    {
        
    }

    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void DoSomeWork()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
        var result = this._strategy.Algo(new List<string> { "a", "b", "c", "d", "e" });

        string resultStr = string.Empty;
        foreach (var element in result as List<string>)
        {
            resultStr += element + ",";
        }

        Console.WriteLine(resultStr);
    }
    
}

public class ConcreteStrategyA : IStrategy
{
    public object Algo(object data)
    {
        throw new NotImplementedException();
    }
}