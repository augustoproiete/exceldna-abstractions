using System.Threading;

namespace ExcelDna.Integration
{
    public interface IExcelAsyncUtil
    {
        void Initialize();
        void Uninitialize();
        object Observe(string callerFunctionName, object callerParameters, ExcelObservableSource observableSource);
        object Run(string callerFunctionName, object callerParameters, ExcelFunc asyncFunc);
        void QueueMacro(string macroName);
        void QueueAsMacro(ExcelAction action);
        void QueueAsMacro(SendOrPostCallback callback, object state);
    }
}
