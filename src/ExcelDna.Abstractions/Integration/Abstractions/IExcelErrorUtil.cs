namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelErrorUtil
    {
        object ToComError(ExcelError excelError);
    }
}
