using System;
using System.Threading;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelAsyncUtilBase : IExcelAsyncUtil
    {
        [Obsolete("ExcelAsyncUtilBase.Initialize is no longer required. The call can be removed.")]
        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        [Obsolete("ExcelAsyncUtilBase.Uninitialize is no longer required. The call can be removed.")]
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

        public virtual event ExcelAction CalculationCanceled
        {
            add => throw new NotImplementedException();
            remove => throw new NotImplementedException();
        }

        public virtual event ExcelAction CalculationEnded
        {
            add => throw new NotImplementedException();
            remove => throw new NotImplementedException();
        }
    }
}
