using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelIntegration
    {
        IEnumerable<Assembly> GetExportedAssemblies();

        void RegisterMethods(List<MethodInfo> methods);

        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
        UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler();
    }
}
