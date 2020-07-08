using System;
using System.Threading;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelAsyncUtilWrapper : ExcelAsyncUtilBase
    {
        public static readonly IExcelAsyncUtil Instance = new ExcelAsyncUtilWrapper();

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

        [Obsolete("ExcelObservableOptions is obsolete. Can't support the NoAutoStartOnOpen option anymore.")]
        public override object Observe(string callerFunctionName, object callerParameters, ExcelObservableOptions options, ExcelObservableSource observableSource)
        {
            return ExcelAsyncUtil.Observe(callerFunctionName, callerParameters, options, observableSource);
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

        public override event ExcelAction CalculationCanceled
        {
            add => ExcelAsyncUtil.CalculationCanceled += value;
            remove => ExcelAsyncUtil.CalculationCanceled -= value;
        }

        public override event ExcelAction CalculationEnded
        {
            add => ExcelAsyncUtil.CalculationEnded += value;
            remove => ExcelAsyncUtil.CalculationEnded -= value;
        }
    }
}
