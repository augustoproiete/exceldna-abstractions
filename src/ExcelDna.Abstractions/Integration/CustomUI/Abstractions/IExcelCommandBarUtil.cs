namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public interface IExcelCommandBarUtil
    {
        CommandBars GetCommandBars();

        void LoadCommandBars(string xmlCustomUI);
        void LoadCommandBars(string xmlCustomUI, GetImageDelegate getImage);

        void UnloadCommandBars();
    }
}
