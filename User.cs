namespace MediatorExample
{
    public abstract class User
    {
        protected Mediator mediator;
        protected String Name;

        public User(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.Name = name;
        }
        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}