using System;
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

        public override object GetRegistrationInfo(string xllPath, double registrationUpdateVersion)
        {
            return ExcelIntegration.GetRegistrationInfo(xllPath, registrationUpdateVersion);
        }

        public override void RegisterMethods(List<MethodInfo> methods)
        {
            ExcelIntegration.RegisterMethods(methods);
        }

        public override void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            ExcelIntegration.RegisterDelegates(delegates, methodAttributes, argumentAttributes);
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
