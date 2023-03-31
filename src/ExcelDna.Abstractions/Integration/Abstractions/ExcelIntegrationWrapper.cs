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
    public class ExcelIntegrationWrapper : ExcelIntegrationBase
    {
        public static readonly IExcelIntegration Instance = new ExcelIntegrationWrapper();

        public override IEnumerable<Assembly> GetExportedAssemblies()
        {
            return ExcelIntegration.GetExportedAssemblies();
        }

        public override object GetRegistrationInfo(string xllPath, double registrationUpdateVersion)
        {
            return ExcelIntegration.GetRegistrationInfo(xllPath, registrationUpdateVersion);
        }

        public override void RegisterMethods(List<MethodInfo> methods)
        {
            ExcelIntegration.RegisterMethods(methods);
        }

        public override void RegisterMethods(List<MethodInfo> methods, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            ExcelIntegration.RegisterMethods(methods, methodAttributes, argumentAttributes);
        }

        public override void RegisterDelegates(List<Delegate> delegates, List<object> methodAttributes, List<List<object>> argumentAttributes)
        {
            ExcelIntegration.RegisterDelegates(delegates, methodAttributes, argumentAttributes);
        }

        public override object RegisterXLL(string xllPath)
        {
            return ExcelIntegration.RegisterXLL(xllPath);
        }

        public override void UnregisterXLL(string xllPath)
        {
            ExcelIntegration.UnregisterXLL(xllPath);
        }

        public override void RegisterUnhandledExceptionHandler(UnhandledExceptionHandler exceptionHandler)
        {
            ExcelIntegration.RegisterUnhandledExceptionHandler(exceptionHandler);
        }

        public override UnhandledExceptionHandler GetRegisterUnhandledExceptionHandler()
        {
            return ExcelIntegration.GetRegisterUnhandledExceptionHandler();
        }
    }
}
