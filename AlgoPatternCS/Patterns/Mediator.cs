namespace AlgoPatternCS.Patterns;

public interface IUser
{
    public void SendMessage(string message);
    public void RecieveMessage(string message);
}

public class Mediator
{
    public List<IUser> users = new List<IUser>();

    public void AddUser(IUser user)
    {
        users.Add(user);
    }

    public void SendMessage(string message, IUser sender)
    {
        foreach (IUser user in users)
        {
            if (user != sender)
            {
                user.RecieveMessage(message);
            }
        }
    }
}
