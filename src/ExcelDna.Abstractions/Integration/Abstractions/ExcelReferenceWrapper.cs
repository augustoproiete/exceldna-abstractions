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
using System.Linq;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelReferenceWrapper : ExcelReferenceBase
    {
        private readonly ExcelReference _excelReference;

        public ExcelReferenceWrapper(ExcelReference excelReference)
        {
            if (excelReference == null)
            {
                throw new ArgumentNullException(nameof(excelReference));
            }

            _excelReference = new ExcelReference(
                excelReference.RowFirst,
                excelReference.RowLast,
                excelReference.ColumnFirst,
                excelReference.ColumnLast,
                excelReference.SheetId);
        }

        public ExcelReferenceWrapper(int row, int column)
        {
            _excelReference = new ExcelReference(row, column);
        }

        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast)
        {
            _excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast);
        }

        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast, IntPtr sheetId)
        {
            _excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast, sheetId);
        }

        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast, string sheetName)
        {
            _excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast, sheetName);
        }

        public ExcelReferenceWrapper(int[][] rectangles, IntPtr sheetId)
        {
            _excelReference = new ExcelReference(rectangles, sheetId);
        }

        public ExcelReferenceWrapper(IEnumerable<ExcelReference> references)
        {
            _excelReference = new ExcelReference(references);
        }

        [Obsolete("An ExcelReference should never be modified.")]
        public override void AddReference(int rowFirst, int rowLast, int columnFirst, int columnLast)
        {
            _excelReference.AddReference(rowFirst, rowLast, columnFirst, columnLast);
        }

        public override object GetValue()
        {
            return _excelReference.GetValue();
        }

        public override bool SetValue(object value)
        {
            return _excelReference.SetValue(value);
        }

        public override int RowFirst => _excelReference.RowFirst;

        public override int RowLast => _excelReference.RowLast;

        public override int ColumnFirst => _excelReference.ColumnFirst;

        public override int ColumnLast => _excelReference.ColumnLast;

        public override IntPtr SheetId => _excelReference.SheetId;

        public override List<ExcelReferenceBase> InnerReferences
        {
            get
            {
                return _excelReference.InnerReferences
                    .Select(r => (ExcelReferenceBase)new ExcelReferenceWrapper(r))
                    .ToList();
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ExcelReferenceBase) || _excelReference.Equals(obj as ExcelReference);
        }

        public override bool Equals(ExcelReferenceBase other)
        {
            if (other is null)
            {
                return false;
            }

            return _excelReference.Equals(other.ExcelReferenceBaseInstance);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return _excelReference.ToString();
        }

        internal override ExcelReference ExcelReferenceBaseInstance => _excelReference;
    }
}
