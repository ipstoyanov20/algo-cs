namespace AlgoPatternCS.Patterns;

public interface IObserver
{
    public void Update(string message);
}
public class User : IObserver
{
    private string userName;
    public User(string userName)
    {
        this.userName = userName;
    }
    public void Update(string message)
    {
        Console.WriteLine($"{userName} recieved a message: {message}");
    }
}
public class Car : IObserver
{
    private string model;
    public Car(string model)
    {
        this.model = model;
    }
    public void Update(string message)
    {
        Console.WriteLine($"{model} recieved a message: {message}");
    }
}
public class NewsAgancy
{
    private List<IObserver> observers = new List<IObserver>();
    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(message);
        }
    }
}