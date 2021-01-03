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

namespace ExcelDna.Integration.Abstractions
{
    public class XlCallWrapper : XlCallBase
    {
        public static readonly IXlCall Instance = new XlCallWrapper();

        public override object Excel(int xlFunction, params object[] parameters)
        {
            return XlCall.Excel(xlFunction, parameters);
        }

        public override XlCall.XlReturn TryExcel(int xlFunction, out object result, params object[] parameters)
        {
            return XlCall.TryExcel(xlFunction, out result, parameters);
        }

        public override object RTD(string progId, string server, params string[] topics)
        {
            return XlCall.RTD(progId, server, topics);
        }
    }
}
