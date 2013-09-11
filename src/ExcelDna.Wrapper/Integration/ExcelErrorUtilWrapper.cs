namespace ExcelDna.Integration
{
    public class ExcelErrorUtilWrapper : ExcelErrorUtilBase
    {
        public override object ToComError(ExcelError excelError)
        {
            return ExcelErrorUtil.ToComError(excelError);
        }
    }
}