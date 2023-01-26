namespace Polludictor.Applicaton.Queries.DataRows.Dto
{
    public class DataRowsDto
    {
        public string Message { get; set; }
        public IEnumerable<DataRowDto> DataRows { get; set; }

        public DataRowsDto(string message, IEnumerable<DataRowDto> dataRows)
        {
            Message = message;
            DataRows = dataRows;
        }
    }
}
