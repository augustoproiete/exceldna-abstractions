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

namespace ExcelDna.IntelliSense.Abstractions
{
    public abstract class IntelliSenseServerBase : IIntelliSenseServer
    {
        [Obsolete("IntelliSenseServer now requires matching calls to Install (inside AutoOpen) and Uninstall (inside AutoClose)", true)]
        public virtual void Register()
        {
            throw new NotImplementedException();
        }

        public virtual void Install()
        {
            throw new NotImplementedException();
        }

        public virtual void Uninstall()
        {
            throw new NotImplementedException();
        }

        public virtual void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
