using Microsoft.AspNetCore.Mvc;
using Polludictor.API.ActionResults;
using Polludictor.Applicaton.Commands.DataRows;
using Polludictor.Applicaton.Commands.DataRows.Model;
using System.Net;

namespace Polludictor.API.Controllers
{
    public partial class DataRowController
    {

        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(AddDataRowResultDto), (int)HttpStatusCode.OK)]
        [HttpPost]
        public async Task<ActionResult<AddDataRowResultDto>> AddDataRow([FromBody] AddDataRowCommand addDataRowCommand, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(addDataRowCommand, cancellationToken);

            return result.ToActionResult();
        }
    }
}
