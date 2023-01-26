using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Polludictor.API.Controllers
{
    [Route("api/v1/data-rows")]
    [ApiController]
    public partial class DataRowController : ApiControllerBase
    {
        public DataRowController(IMediator mediator) : base(mediator)
        {
        }
    }
}
