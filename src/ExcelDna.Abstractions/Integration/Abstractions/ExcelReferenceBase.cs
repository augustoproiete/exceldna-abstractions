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
