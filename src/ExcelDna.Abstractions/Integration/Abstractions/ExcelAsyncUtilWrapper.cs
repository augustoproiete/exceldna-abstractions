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
