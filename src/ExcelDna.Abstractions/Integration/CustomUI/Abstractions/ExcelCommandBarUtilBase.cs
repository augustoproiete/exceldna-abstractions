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

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public abstract class ExcelCommandBarUtilBase : IExcelCommandBarUtil
    {
        public virtual CommandBars GetCommandBars()
        {
            throw new NotImplementedException();
        }

        public virtual void LoadCommandBars(string xmlCustomUI)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadCommandBars(string xmlCustomUI, GetImageDelegate getImage)
        {
            throw new NotImplementedException();
        }

        public virtual void UnloadCommandBars()
        {
            throw new NotImplementedException();
        }
    }
}
