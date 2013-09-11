using System;

namespace ExcelDna.Integration
{
    public class ExcelDnaUtilWrapper : ExcelDnaUtilBase
    {
        public override bool IsInFunctionWizard()
        {
            return ExcelDnaUtil.IsInFunctionWizard();
        }

        public override IntPtr WindowHandle
        {
            get { return ExcelDnaUtil.WindowHandle; }
        }

        public override object Application
        {
            get { return ExcelDnaUtil.Application; }
        }

        public override double ExcelVersion
        {
            get { return ExcelDnaUtil.ExcelVersion; }
        }

        public override ExcelLimits ExcelLimits
        {
            get { return ExcelDnaUtil.ExcelLimits; }
        }
    }
}