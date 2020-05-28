using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelIntegrationBase : IExcelIntegration
    {
        public virtual IEnumerable<Assembly> GetExportedAssemblies()
        {
            throw new NotImplementedException();
        }

        public virtual object GetRegistrationInfo(string xllPath, double registrationUpdateVersion)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterMethods(List<MethodInfo> methods)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterMethods(List<MethodInfo> methods, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            throw new NotImplementedException();
        }

        // ReSharper disable InconsistentNaming
        public virtual object RegisterXLL(string xllPath)
        // ReSharper restore InconsistentNaming
        {
            throw new NotImplementedException();
        }

        // ReSharper disable InconsistentNaming
        public virtual void UnregisterXLL(string xllPath)
        // ReSharper restore InconsistentNaming
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            throw new NotImplementedException();
        }

        public virtual UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler()
        {
            throw new NotImplementedException();
        }
    }
}
