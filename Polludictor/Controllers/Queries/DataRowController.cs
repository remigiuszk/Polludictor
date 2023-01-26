using Microsoft.AspNetCore.Mvc;
using Polludictor.API.ActionResults;
using Polludictor.Applicaton.Queries.DataRows;
using Polludictor.Applicaton.Queries.DataRows.Dto;
using System.Net;

namespace Polludictor.API.Controllers
{
    public partial class DataRowController
    {
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(DataRowsDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<DataRowsDto>> GetDocuments(CancellationToken cancellationToken)
        {
            var query = new AllDataRowsQuery();
            var result = await _mediator.Send(query, cancellationToken);

            return result.ToActionResult();
        }
    }
}
