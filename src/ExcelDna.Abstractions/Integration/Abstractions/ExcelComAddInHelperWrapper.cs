namespace ExcelDna.Integration.Abstractions
{
    public class ExcelComAddInHelperWrapper : ExcelComAddInHelperBase
    {
        public static readonly IExcelComAddInHelper Instance = new ExcelComAddInHelperWrapper();

        public override void LoadComAddIn(ExcelComAddIn addIn)
        {
            ExcelComAddInHelper.LoadComAddIn(addIn);
        }
    }
}
