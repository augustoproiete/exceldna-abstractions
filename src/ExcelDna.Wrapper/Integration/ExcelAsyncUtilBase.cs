using System;
using System.Threading;

namespace ExcelDna.Integration
{
    public abstract class ExcelAsyncUtilBase : IExcelAsyncUtil
    {
        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        public virtual void Uninitialize()
        {
            throw new NotImplementedException();
        }

        public virtual object Observe(string callerFunctionName, object callerParameters, ExcelObservableSource observableSource)
        {
            throw new NotImplementedException();
        }

        public virtual object Run(string callerFunctionName, object callerParameters, ExcelFunc asyncFunc)
        {
            throw new NotImplementedException();
        }

        public virtual void QueueMacro(string macroName)
        {
            throw new NotImplementedException();
        }

        public virtual void QueueAsMacro(ExcelAction action)
        {
            throw new NotImplementedException();
        }

        public virtual void QueueAsMacro(SendOrPostCallback callback, object state)
        {
            throw new NotImplementedException();
        }
    }
}