namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public class ExcelCommandBarUtilWrapper : ExcelCommandBarUtilBase
    {
        public static readonly IExcelCommandBarUtil Instance = new ExcelCommandBarUtilWrapper();

        public override CommandBars GetCommandBars()
        {
            return ExcelCommandBarUtil.GetCommandBars();
        }

        public override void LoadCommandBars(string xmlCustomUI)
        {
            ExcelCommandBarUtil.LoadCommandBars(xmlCustomUI);
        }

        public override void LoadCommandBars(string xmlCustomUI, GetImageDelegate getImage)
        {
            ExcelCommandBarUtil.LoadCommandBars(xmlCustomUI, getImage);
        }

        public override void UnloadCommandBars()
        {
            ExcelCommandBarUtil.UnloadCommandBars();
        }
    }
}
