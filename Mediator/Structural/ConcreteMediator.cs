using System.Collections.Generic;
using System.Linq;

namespace Mediator.Structural
{
    public class ConcreteMediator:Mediator
    {
        public List<Colleague> Colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            Colleagues.Add(colleague);
        }
        public override void Send(string message, Colleague colleague)
        {
            Colleagues.Where(e => e!= colleague).ToList().ForEach(e => e.HandleNotification(message));
        }
    }
}
