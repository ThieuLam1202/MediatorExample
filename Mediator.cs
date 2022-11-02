namespace MediatorExample
{
    public interface Mediator
    {
        void SendMessage(User user, string msg);
        void RegisterUser(User user);
    }
}