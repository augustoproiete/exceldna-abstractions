﻿#region Copyright 2013-2023 C. Augusto Proiete & Contributors
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
    public class LogDisplayWrapper : LogDisplayBase
    {
        public static readonly ILogDisplay Instance = new LogDisplayWrapper();

        public override void Show()
        {
            LogDisplay.Show();
        }

        public override void Hide()
        {
            LogDisplay.Hide();
        }

        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        public override void SetText(string text)
        {
            LogDisplay.SetText(text);
        }

        public override void WriteLine(string format, params object[] args)
        {
            LogDisplay.WriteLine(format, args);
        }

        public override void RecordLine(string format, params object[] args)
        {
            LogDisplay.RecordLine(format, args);
        }

        public override void Clear()
        {
            LogDisplay.Clear();
        }

        public override DisplayOrder DisplayOrder
        {
            get => (DisplayOrder)LogDisplay.DisplayOrder;
            set => LogDisplay.DisplayOrder = (Logging.DisplayOrder)value;
        }
    }
}
