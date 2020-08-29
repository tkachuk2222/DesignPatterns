namespace Mediator.Structural
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        internal void SetMediator(Mediator mediator)
        {
            Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
