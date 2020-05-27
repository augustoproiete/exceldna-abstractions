using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelIntegrationWrapper : ExcelIntegrationBase
    {
        public override IEnumerable<Assembly> GetExportedAssemblies()
        {
            return ExcelIntegration.GetExportedAssemblies();
        }

        public override void RegisterMethods(List<MethodInfo> methods)
        {
            ExcelIntegration.RegisterMethods(methods);
        }

        public override void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            ExcelIntegration.RegisterUnhandledExceptionHandler(exceptionHandler);
        }

        public override UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler()
        {
            return ExcelIntegration.GetRegisterUnhandledExceptionHandler();
        }
    }
}
