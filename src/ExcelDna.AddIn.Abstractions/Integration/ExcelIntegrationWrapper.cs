using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration
{
    public class ExcelIntegrationWrapper : ExcelIntegrationBase
    {
        public override void RegisterMethods(List<MethodInfo> methods)
        {
            ExcelIntegration.RegisterMethods(methods);
        }

        public override void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            ExcelIntegration.RegisterUnhandledExceptionHandler(exceptionHandler);
        }
    }
}