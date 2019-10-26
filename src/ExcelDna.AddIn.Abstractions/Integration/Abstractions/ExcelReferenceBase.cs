using System;
using System.Collections.Generic;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelReferenceBase : IExcelReference
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

        public virtual List<IExcelReference> InnerReferences => throw new NotImplementedException();
    }
}
