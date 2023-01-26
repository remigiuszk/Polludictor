using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Polludictor.API.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        protected IMediator _mediator;
        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
