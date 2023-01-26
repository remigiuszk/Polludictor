using FluentResults;
using MediatR;
using Polludictor.Applicaton.Commands.DataRows.Model;

namespace Polludictor.Applicaton.Commands.DataRows
{
    public class AddDataRowCommandHandler : IRequestHandler<AddDataRowCommand, Result<AddDataRowResultDto>>
    {
        public async Task<Result<AddDataRowResultDto>> Handle(AddDataRowCommand request, CancellationToken cancellationToken)
        {
            return Result.Ok(new AddDataRowResultDto(1, "dataRow added successfully"));
        }
    }
}
