using System;

namespace ExcelDna.IntelliSense.Abstractions
{
    public class IntelliSenseServerWrapper : IntelliSenseServerBase
    {
        [Obsolete("IntelliSenseServer now requires matching calls to Install (inside AutoOpen) and Uninstall (inside AutoClose)", true)]
        public override void Register()
        {
            IntelliSenseServer.Register();
        }

        public override void Install()
        {
            IntelliSenseServer.Install();
        }

        public override void Uninstall()
        {
            IntelliSenseServer.Uninstall();
        }

        public override void Refresh()
        {
            IntelliSenseServer.Refresh();
        }
    }
}
