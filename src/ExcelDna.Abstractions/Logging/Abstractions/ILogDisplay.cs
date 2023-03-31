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

namespace ExcelDna.Logging.Abstractions
{
    public interface ILogDisplay
    {
        void Show();
        void Hide();
        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        void SetText(string text);
        void WriteLine(string format, params object[] args);
        void RecordLine(string format, params object[] args);
        void Clear();

        DisplayOrder DisplayOrder { get; set; }
    }
}
