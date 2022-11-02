namespace MediatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new ConcreteMediator();

            User QLam = new ConcreteUser(mediator, "QLam");
            User DTam = new ConcreteUser(mediator, "DTam");
            User User3 = new ConcreteUser(mediator, "User3");
            User User4 = new ConcreteUser(mediator, "User4");

            mediator.RegisterUser(QLam);
            mediator.RegisterUser(DTam);
            mediator.RegisterUser(User3);
            mediator.RegisterUser(User4);

            QLam.Send("Hello DTam.");
            DTam.Send("Hi QLam.");

            Console.Read();
        }
    }
}
