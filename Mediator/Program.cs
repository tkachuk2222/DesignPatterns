using Mediator.Structural;

namespace Mediator
{
    // Mediator - I define communication between colleagues
    // Colleague - I communicate only with Mediator
    // Concrete Mediator - I implement communication between colleagues
    // Concrete Colleague - I receive messages from the mediator
    class Program
    {
        static void Main(string[] args)
        {
            var concreteMediator = new ConcreteMediator();

            var c1 = concreteMediator.CreateColleague<Colleague1>();
            var c2 = concreteMediator.CreateColleague<Colleague2>();

            c1.Send("Hello world! (from c1)");
            c2.Send("Hi, there! (from c2)");
        }
    }
}
