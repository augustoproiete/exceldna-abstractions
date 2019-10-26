namespace ExcelDna.ComInterop.Abstractions
{
    public class ComServerWrapper : ComServerBase
    {
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
