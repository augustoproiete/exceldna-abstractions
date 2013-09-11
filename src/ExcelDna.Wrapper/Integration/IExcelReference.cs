using System;
using System.Collections.Generic;

namespace ExcelDna.Integration
{
    public interface IExcelReference
    {
        void AddReference(int rowFirst, int rowLast, int columnFirst, int columnLast);
        object GetValue();
        bool SetValue(object value);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
        int RowFirst { get; }
        int RowLast { get; }
        int ColumnFirst { get; }
        int ColumnLast { get; }
        IntPtr SheetId { get; }
        List<IExcelReference> InnerReferences { get; }
    }
}