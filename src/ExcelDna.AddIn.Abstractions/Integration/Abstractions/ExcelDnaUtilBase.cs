using System;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelDnaUtilBase : IExcelDnaUtil
    {
        public virtual bool IsInFunctionWizard()
        {
            throw new NotImplementedException();
        }

        public virtual IntPtr WindowHandle => throw new NotImplementedException();

        public virtual object Application => throw new NotImplementedException();

        public virtual double ExcelVersion => throw new NotImplementedException();

        public virtual ExcelLimits ExcelLimits => throw new NotImplementedException();
    }
}
