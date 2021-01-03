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

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public class ExcelCommandBarUtilWrapper : ExcelCommandBarUtilBase
    {
        public static readonly IExcelCommandBarUtil Instance = new ExcelCommandBarUtilWrapper();

        public override CommandBars GetCommandBars()
        {
            return ExcelCommandBarUtil.GetCommandBars();
        }

        public override void LoadCommandBars(string xmlCustomUI)
        {
            ExcelCommandBarUtil.LoadCommandBars(xmlCustomUI);
        }

        public override void LoadCommandBars(string xmlCustomUI, GetImageDelegate getImage)
        {
            ExcelCommandBarUtil.LoadCommandBars(xmlCustomUI, getImage);
        }

        public override void UnloadCommandBars()
        {
            ExcelCommandBarUtil.UnloadCommandBars();
        }
    }
}
