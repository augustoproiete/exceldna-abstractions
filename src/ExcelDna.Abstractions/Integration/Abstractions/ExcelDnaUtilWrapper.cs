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
using System.IO;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelDnaUtilWrapper : ExcelDnaUtilBase
    {
        public static readonly IExcelDnaUtil Instance = new ExcelDnaUtilWrapper();

        public override bool IsInFunctionWizard()
        {
            return ExcelDnaUtil.IsInFunctionWizard();
        }

        public override int MainManagedThreadId => ExcelDnaUtil.MainManagedThreadId;

        public override IntPtr WindowHandle => ExcelDnaUtil.WindowHandle;

        public override object Application => ExcelDnaUtil.Application;

        public override double ExcelVersion => ExcelDnaUtil.ExcelVersion;

        public override ExcelLimits ExcelLimits => ExcelDnaUtil.ExcelLimits;

        public override string XllPath => ExcelDnaUtil.XllPath;

        public override FileInfo XllPathInfo => ExcelDnaUtil.XllPathInfo;

        public override bool SupportsDynamicArrays => ExcelDnaUtil.SupportsDynamicArrays;
    }
}
