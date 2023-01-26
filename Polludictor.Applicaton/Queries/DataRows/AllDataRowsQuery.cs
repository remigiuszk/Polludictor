using FluentResults;
using MediatR;
using Polludictor.Applicaton.Queries.DataRows.Dto;

namespace Polludictor.Applicaton.Queries.DataRows
{
    public class AllDataRowsQuery : IRequest<Result<DataRowsDto>>
    {
    }
}
