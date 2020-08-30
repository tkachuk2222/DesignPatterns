using System.Threading.Tasks;
using DemoMediatR.Data;
using DemoMediatR.Features.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IMediator _mediator;

        public ContactsController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<Contact> GetContactAsync([FromRoute] Query query)
        {
            return await _mediator.Send(query);
        }
    }
}
