using System;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class ExcelDnaUtilBase : IExcelDnaUtil
    {
        public virtual bool IsInFunctionWizard()
        {
            throw new NotImplementedException();
        }

        public virtual IntPtr WindowHandle
        {
            get { throw new NotImplementedException(); }
        }
        
        public virtual object Application
        {
            get { throw new NotImplementedException(); }
        }
        
        public virtual double ExcelVersion
        {
            get { throw new NotImplementedException(); }
        }
        
        public virtual ExcelLimits ExcelLimits
        {
            get { throw new NotImplementedException(); }
        }
    }
}
