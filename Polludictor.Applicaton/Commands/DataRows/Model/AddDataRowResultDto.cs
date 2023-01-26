namespace Polludictor.Applicaton.Commands.DataRows.Model
{
    public class AddDataRowResultDto
    {
        public int DataRowId { get; }
        public string Message { get; }

        public AddDataRowResultDto(int dataRowId, string message)
        {
            DataRowId = dataRowId;
            Message = message;
        }
    }
}
