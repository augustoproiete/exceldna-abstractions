using System;
using System.Threading;

namespace ExcelDna.Integration
{
    public class ExcelAsyncUtilWrapper : ExcelAsyncUtilBase
    {
        [Obsolete("ExcelAsyncUtilWrapper.Initialize is no longer required. The call can be removed.")]
        public override void Initialize()
        {
            ExcelAsyncUtil.Initialize();
        }

        [Obsolete("ExcelAsyncUtilWrapper.Uninitialize is no longer required. The call can be removed.")]
        public override void Uninitialize()
        {
            ExcelAsyncUtil.Uninitialize();
        }

        public override object Observe(string callerFunctionName, object callerParameters, ExcelObservableSource observableSource)
        {
            return ExcelAsyncUtil.Observe(callerFunctionName, callerParameters, observableSource);
        }

        public override object Run(string callerFunctionName, object callerParameters, ExcelFunc asyncFunc)
        {
            return ExcelAsyncUtil.Run(callerFunctionName, callerParameters, asyncFunc);
        }

        public override void QueueMacro(string macroName)
        {
            ExcelAsyncUtil.QueueMacro(macroName);
        }

        public override void QueueAsMacro(ExcelAction action)
        {
            ExcelAsyncUtil.QueueAsMacro(action);
        }

        public override void QueueAsMacro(SendOrPostCallback callback, object state)
        {
            ExcelAsyncUtil.QueueAsMacro(callback, state);
        }
    }
}