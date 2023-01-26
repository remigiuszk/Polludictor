using FluentResults;
using MediatR;
using Polludictor.Applicaton.Commands.DataRows.Model;

namespace Polludictor.Applicaton.Commands.DataRows
{
    public class AddDataRowCommand : IRequest<Result<AddDataRowResultDto>>
    {
        public int Id { get; }
    }
}
