namespace MediatorExample
{
    public class ConcreteMediator : Mediator
    {
        private List<User> UserList = new List<User>();

        public void RegisterUser(User user)
        {
            UserList.Add(user);
        }

        public void SendMessage(User user, String msg)
        {
            foreach (var u in UserList)
            {
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}