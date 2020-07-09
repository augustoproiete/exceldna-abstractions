namespace ExcelDna.IntelliSense.Abstractions
{
    public interface IIntelliSenseServer
    {
        void Register();
        void Install();
        void Uninstall();
        void Refresh();
    }
}
