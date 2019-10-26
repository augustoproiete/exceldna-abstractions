using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration
{
    public interface IExcelIntegration
    {
        void RegisterMethods(List<MethodInfo> methods);
        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
    }
}