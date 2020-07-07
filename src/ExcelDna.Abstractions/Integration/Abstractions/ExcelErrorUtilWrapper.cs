namespace ExcelDna.Integration.Abstractions
{
    public class ExcelErrorUtilWrapper : ExcelErrorUtilBase
    {
        public static readonly IExcelErrorUtil Instance = new ExcelErrorUtilWrapper();

        public override object ToComError(ExcelError excelError)
        {
            return ExcelErrorUtil.ToComError(excelError);
        }
    }
}
