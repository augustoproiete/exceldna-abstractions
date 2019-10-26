using System;

namespace ExcelDna.ComInterop
{
    public abstract class ComServerBase : IComServer
    {
        public virtual int DllRegisterServer()
        {
            throw new NotImplementedException();
        }

        public virtual int DllUnregisterServer()
        {
            throw new NotImplementedException();
        }
    }
}