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

namespace ExcelDna.Logging.Abstractions
{
    public abstract class LogDisplayBase : ILogDisplay
    {
        public virtual void Show()
        {
            throw new NotImplementedException();
        }

        public virtual void Hide()
        {
            throw new NotImplementedException();
        }

        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        public virtual void SetText(string text)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public virtual void RecordLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }

        public virtual DisplayOrder DisplayOrder
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
