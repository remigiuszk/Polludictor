using FluentResults;
using MediatR;
using Polludictor.Applicaton.Queries.DataRows.Dto;

namespace Polludictor.Applicaton.Queries.DataRows
{
    public class AllDataRowsQueryHandler : IRequestHandler<AllDataRowsQuery, Result<DataRowsDto>>
    {
        public async Task<Result<DataRowsDto>> Handle(AllDataRowsQuery request, CancellationToken cancellationToken)
        {
            return Result.Ok(new DataRowsDto("Rows fetched successfully.", new List<DataRowDto>()));
        }
    }
}
