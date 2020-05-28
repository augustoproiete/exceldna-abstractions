using System;

namespace ExcelDna.Integration.Abstractions
{
    public interface IExcelDnaUtil
    {
        bool IsInFunctionWizard();
        IntPtr WindowHandle { get; }
        object Application { get; }
        double ExcelVersion { get; }
        ExcelLimits ExcelLimits { get; }
        string XllPath { get; }
    }
}
