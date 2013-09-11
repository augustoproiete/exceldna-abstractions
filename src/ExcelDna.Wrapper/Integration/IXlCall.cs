namespace ExcelDna.Integration
{
    public interface IXlCall
    {
        object Excel(int xlFunction, params object[] parameters);
        XlCall.XlReturn TryExcel(int xlFunction, out object result, params object[] parameters);
// ReSharper disable InconsistentNaming
        object RTD(string progId, string server, params string[] topics);
// ReSharper restore InconsistentNaming
    }
}