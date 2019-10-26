namespace ExcelDna.ComInterop.Abstractions
{
    public interface IComServer
    {
        int DllRegisterServer();
        int DllUnregisterServer();
    }
}
