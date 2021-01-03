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
using System.Collections.Generic;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelReferenceBase
    {
        [Obsolete("An ExcelReference should never be modified.")]
        public virtual void AddReference(int rowFirst, int rowLast, int columnFirst, int columnLast)
        {
            throw new NotImplementedException();
        }

        public virtual object GetValue()
        {
            throw new NotImplementedException();
        }

        public virtual bool SetValue(object value)
        {
            throw new NotImplementedException();
        }

        public virtual int RowFirst => throw new NotImplementedException();

        public virtual int RowLast => throw new NotImplementedException();

        public virtual int ColumnFirst => throw new NotImplementedException();

        public virtual int ColumnLast => throw new NotImplementedException();

        public virtual IntPtr SheetId => throw new NotImplementedException();

        public virtual List<ExcelReferenceBase> InnerReferences => throw new NotImplementedException();

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public virtual bool Equals(ExcelReferenceBase other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        internal virtual ExcelReference ExcelReferenceBaseInstance => throw new NotImplementedException();
    }
}
