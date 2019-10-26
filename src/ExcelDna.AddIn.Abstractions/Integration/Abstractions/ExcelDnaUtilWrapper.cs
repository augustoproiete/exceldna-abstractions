using System;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelDnaUtilWrapper : ExcelDnaUtilBase
    {
        public override bool IsInFunctionWizard()
        {
            return ExcelDnaUtil.IsInFunctionWizard();
        }

        public override IntPtr WindowHandle => ExcelDnaUtil.WindowHandle;

        public override object Application => ExcelDnaUtil.Application;

        public override double ExcelVersion => ExcelDnaUtil.ExcelVersion;

        public override ExcelLimits ExcelLimits => ExcelDnaUtil.ExcelLimits;
    }
}
