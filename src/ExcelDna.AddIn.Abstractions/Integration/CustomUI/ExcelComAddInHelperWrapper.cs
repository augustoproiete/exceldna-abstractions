namespace ExcelDna.Integration.CustomUI
{
    public class ExcelComAddInHelperWrapper : ExcelComAddInHelperBase
    {
        public override void LoadComAddIn(ExcelComAddIn addIn)
        {
            ExcelComAddInHelper.LoadComAddIn(addIn);
        }
    }
}