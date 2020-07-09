using System;

namespace ExcelDna.IntelliSense.Abstractions
{
    public abstract class IntelliSenseServerBase : IIntelliSenseServer
    {
        [Obsolete("IntelliSenseServer now requires matching calls to Install (inside AutoOpen) and Uninstall (inside AutoClose)", true)]
        public virtual void Register()
        {
            throw new NotImplementedException();
        }

        public virtual void Install()
        {
            throw new NotImplementedException();
        }

        public virtual void Uninstall()
        {
            throw new NotImplementedException();
        }

        public virtual void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
