namespace AlgoPatternCS.Patterns;

public interface ICommand
{
    void Execute(object param);
}

public class Command<T> : ICommand where T : class
{
    private readonly Action<T> action;

    public Command(Action<T> action)
    {
        this.action = action;
    }

    public void Execute(object param)
    {
        this.action.Invoke(param as T); 
    }
}

public static class CommandBuilder
{
    public static ICommand CreateFrom<T>(Action<T> action) where T : class
    {
        return new Command<T>(action);
    }
}

public class Worker
{
    public void LoadData(ICommand notify)
    {
        Thread.Sleep(1000);
        notify.Execute(new Progress() {ProgressNumber = 100});
        Thread.Sleep(1000);
    }
}

public class Progress
{
    public int ProgressNumber { get; set; }
}