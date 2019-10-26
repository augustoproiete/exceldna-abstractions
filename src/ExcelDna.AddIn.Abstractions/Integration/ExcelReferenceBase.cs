using System;
using System.Collections.Generic;

namespace ExcelDna.Integration
{
    public abstract class ExcelReferenceBase : IExcelReference
    {
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

        public virtual int RowFirst
        {
            get { throw new NotImplementedException(); }
        }

        public virtual int RowLast
        {
            get { throw new NotImplementedException(); }
        }

        public virtual int ColumnFirst
        {
            get { throw new NotImplementedException(); }
        }

        public virtual int ColumnLast
        {
            get { throw new NotImplementedException(); }
        }

        public virtual IntPtr SheetId
        {
            get { throw new NotImplementedException(); }
        }

        public virtual List<IExcelReference> InnerReferences
        {
            get { throw new NotImplementedException(); }
        }
    }
}