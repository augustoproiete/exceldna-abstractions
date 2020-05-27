using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelIntegration
    {
        IEnumerable<Assembly> GetExportedAssemblies();

        object GetRegistrationInfo(string xllPath, double registrationUpdateVersion);

        void RegisterMethods(List<MethodInfo> methods);

        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
        UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler();
    }
}
