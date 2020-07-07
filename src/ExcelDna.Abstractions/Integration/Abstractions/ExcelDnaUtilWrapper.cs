using System;
using System.IO;

namespace ExcelDna.Integration.Abstractions
{
    public class ExcelDnaUtilWrapper : ExcelDnaUtilBase
    {
        public static readonly IExcelDnaUtil Instance = new ExcelDnaUtilWrapper();

        public override bool IsInFunctionWizard()
        {
            return ExcelDnaUtil.IsInFunctionWizard();
        }

        public override int MainManagedThreadId => ExcelDnaUtil.MainManagedThreadId;

        public override IntPtr WindowHandle => ExcelDnaUtil.WindowHandle;

        public override object Application => ExcelDnaUtil.Application;

        public override double ExcelVersion => ExcelDnaUtil.ExcelVersion;

        public override ExcelLimits ExcelLimits => ExcelDnaUtil.ExcelLimits;

        public override string XllPath => ExcelDnaUtil.XllPath;

        public override FileInfo XllPathInfo => ExcelDnaUtil.XllPathInfo;

        public override bool SupportsDynamicArrays => ExcelDnaUtil.SupportsDynamicArrays;
    }
}
