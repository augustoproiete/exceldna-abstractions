#region Copyright 2013-2023 C. Augusto Proiete & Contributors
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

        [Obsolete("ExcelObservableOptions is obsolete. Can't support the NoAutoStartOnOpen option anymore.")]
        public virtual object Observe(string callerFunctionName, object callerParameters, ExcelObservableOptions options, ExcelObservableSource observableSource)
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
