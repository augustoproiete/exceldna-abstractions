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

        public virtual void RegisterMethods(List<MethodInfo> methods)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            throw new NotImplementedException();
        }
    }
}
