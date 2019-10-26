namespace ExcelDna.ComInterop
{
    public interface IComServer
    {
        int DllRegisterServer();
        int DllUnregisterServer();
    }
}
