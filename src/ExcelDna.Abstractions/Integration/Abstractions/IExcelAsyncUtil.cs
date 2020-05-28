using System;
using System.Threading;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelAsyncUtil
    {
        [Obsolete("IExcelAsyncUtil.Initialize is no longer required. The call can be removed.")]
        void Initialize();

        [Obsolete("IExcelAsyncUtil.Uninitialize is no longer required. The call can be removed.")]
        void Uninitialize();

        object Observe(string callerFunctionName, object callerParameters, ExcelObservableSource observableSource);
        object Observe(string callerFunctionName, object callerParameters, ExcelObservableOptions options, ExcelObservableSource observableSource);

        object Run(string callerFunctionName, object callerParameters, ExcelFunc asyncFunc);
        void QueueMacro(string macroName);
        void QueueAsMacro(ExcelAction action);
        void QueueAsMacro(SendOrPostCallback callback, object state);

        event ExcelAction CalculationCanceled;
        event ExcelAction CalculationEnded;
    }
}
