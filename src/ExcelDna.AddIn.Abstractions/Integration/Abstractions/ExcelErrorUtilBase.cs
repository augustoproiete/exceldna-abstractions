namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelErrorUtilBase : IExcelErrorUtil
    {
        public virtual object ToComError(ExcelError excelError)
        {
            throw new System.NotImplementedException();
        }
    }
}
