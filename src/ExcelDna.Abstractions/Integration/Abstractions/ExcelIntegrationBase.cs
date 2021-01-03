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

        public virtual object GetRegistrationInfo(string xllPath, double registrationUpdateVersion)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterMethods(List<MethodInfo> methods)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterMethods(List<MethodInfo> methods, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            throw new NotImplementedException();
        }

        // ReSharper disable InconsistentNaming
        public virtual object RegisterXLL(string xllPath)
        // ReSharper restore InconsistentNaming
        {
            throw new NotImplementedException();
        }

        // ReSharper disable InconsistentNaming
        public virtual void UnregisterXLL(string xllPath)
        // ReSharper restore InconsistentNaming
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            throw new NotImplementedException();
        }

        public virtual UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler()
        {
            throw new NotImplementedException();
        }
    }
}
