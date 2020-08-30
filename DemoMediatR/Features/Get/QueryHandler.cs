using System.Threading;
using System.Threading.Tasks;
using DemoMediatR.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoMediatR.Features.Get
{
    public class QueryHandler : IRequestHandler<Query, Contact>
    {
        private readonly ContactsContext _contactsContext;

        public QueryHandler(ContactsContext contactsContext) => _contactsContext = contactsContext;

        public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _contactsContext.Contacts.SingleOrDefaultAsync(e => e.Id == request.Id, cancellationToken: cancellationToken);
        }
    }
}
