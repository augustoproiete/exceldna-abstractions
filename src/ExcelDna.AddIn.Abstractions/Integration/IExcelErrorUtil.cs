namespace ExcelDna.Integration
{
    public interface IExcelErrorUtil
    {
        object ToComError(ExcelError excelError);
    }
}