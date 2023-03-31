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
using System.Collections.Generic;
using System.Reflection;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelIntegration
    {
        IEnumerable<Assembly> GetExportedAssemblies();

        object GetRegistrationInfo(string xllPath, double registrationUpdateVersion);

        void RegisterMethods(List<MethodInfo> methods);
        void RegisterMethods(List<MethodInfo> methods, List<object> methodAttributes, List<List<object>> argumentAttributes);

        void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes);

        // ReSharper disable InconsistentNaming
        object RegisterXLL(string xllPath);
        void UnregisterXLL(string xllPath);
        // ReSharper restore InconsistentNaming

        void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler);
        UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler();
    }
}
