#region Copyright 2013-2021 C. Augusto Proiete & Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

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

        [Obsolete("ExcelObservableOptions is obsolete. Can't support the NoAutoStartOnOpen option anymore.")]
        object Observe(string callerFunctionName, object callerParameters, ExcelObservableOptions options, ExcelObservableSource observableSource);

        object Run(string callerFunctionName, object callerParameters, ExcelFunc asyncFunc);
        void QueueMacro(string macroName);
        void QueueAsMacro(ExcelAction action);
        void QueueAsMacro(SendOrPostCallback callback, object state);

        event ExcelAction CalculationCanceled;
        event ExcelAction CalculationEnded;
    }
}
