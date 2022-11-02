namespace MediatorExample
{
    public class ConcreteUser : User
    {
        public ConcreteUser(Mediator mediator, string name) : base (mediator, name)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine(this.Name + " (Receive): " + msg);
            Thread.Sleep(1000);
            Console.WriteLine();
        }
        public override void Send(string msg)
        {
            Console.WriteLine(this.Name + " (Send): " + msg + "\n");
            mediator.SendMessage(this, msg);
            Thread.Sleep(1000);
            Console.WriteLine();
        }
    }
}