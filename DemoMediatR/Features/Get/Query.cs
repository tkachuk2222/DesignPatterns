using DemoMediatR.Data;
using MediatR;

namespace DemoMediatR.Features.Get
{
    public class Query : IRequest<Contact>
    {
        public int Id { get; set;  }
    }
}
