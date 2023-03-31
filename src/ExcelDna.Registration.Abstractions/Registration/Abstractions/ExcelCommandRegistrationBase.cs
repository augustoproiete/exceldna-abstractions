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
using System.Linq.Expressions;
using ExcelDna.Integration;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class ExcelCommandRegistrationBase
    {
        public virtual LambdaExpression CommandLambda
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual ExcelCommandAttribute CommandAttribute
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual List<object> CustomAttributes
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        internal virtual ExcelCommandRegistration ExcelCommandRegistrationInstance => throw new NotImplementedException();
    }
}
