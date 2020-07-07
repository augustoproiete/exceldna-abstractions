namespace ExcelDna.ComInterop.Abstractions
{
    public class ComServerWrapper : ComServerBase
    {
        public static readonly IComServer Instance = new ComServerWrapper();

        public override int DllRegisterServer()
        {
            return ComServer.DllRegisterServer();
        }

        public override int DllUnregisterServer()
        {
            return ComServer.DllUnregisterServer();
        }
    }
}
