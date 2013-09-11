using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelDna.Integration
{
    public class ExcelReferenceWrapper : ExcelReferenceBase
    {
        private readonly ExcelReference excelReference;

        public ExcelReferenceWrapper(ExcelReference excelReference)
        {
            if (excelReference == null)
            {
                throw new ArgumentNullException("excelReference");
            }

            this.excelReference = new ExcelReference(
                excelReference.RowFirst,
                excelReference.RowLast,
                excelReference.ColumnFirst,
                excelReference.ColumnLast,
                excelReference.SheetId);
        }

        public ExcelReferenceWrapper(int row, int column)
        {
            excelReference = new ExcelReference(row, column);
        }
        
        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast)
        {
            excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast);
        }
        
        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast, IntPtr sheetId)
        {
            excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast, sheetId);
        }

        public ExcelReferenceWrapper(int rowFirst, int rowLast, int columnFirst, int columnLast, string sheetName)
        {
            excelReference = new ExcelReference(rowFirst, rowLast, columnFirst, columnLast, sheetName);
        }

        public override void AddReference(int rowFirst, int rowLast, int columnFirst, int columnLast)
        {
            excelReference.AddReference(rowFirst, rowLast, columnFirst, columnLast);
        }

        public override object GetValue()
        {
            return excelReference.GetValue();
        }

        public override bool SetValue(object value)
        {
            return excelReference.SetValue(value);
        }

        public override int RowFirst
        {
            get { return excelReference.RowFirst; }
        }

        public override int RowLast
        {
            get { return excelReference.RowLast; }
        }

        public override int ColumnFirst
        {
            get { return excelReference.ColumnFirst; }
        }

        public override int ColumnLast
        {
            get { return excelReference.ColumnLast; }
        }

        public override IntPtr SheetId
        {
            get { return excelReference.SheetId; }
        }

        public override List<IExcelReference> InnerReferences
        {
            get
            {
                return excelReference.InnerReferences
                    .Select(r => (IExcelReference)new ExcelReferenceWrapper(r))
                    .ToList();
            }
        }
    }
}