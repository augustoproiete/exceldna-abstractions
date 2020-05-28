using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelIntegration
    {
        IEnumerable<Assembly> GetExportedAssemblies();

        object GetRegistrationInfo(string xllPath, double registrationUpdateVersion);

        void RegisterMethods(List<MethodInfo> methods);
        void RegisterMethods(List<MethodInfo> methods, List<object> methodAttributes, List<List<object>> argumentAttributes);

        void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes);

        // ReSharper disable InconsistentNaming
        object RegisterXLL(string xllPath);
        void UnregisterXLL(string xllPath);
        // ReSharper restore InconsistentNaming

        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
        UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler();
    }
}
