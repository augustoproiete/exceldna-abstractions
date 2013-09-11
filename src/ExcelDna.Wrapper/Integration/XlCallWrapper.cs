namespace ExcelDna.Integration
{
    public class XlCallWrapper : XlCallBase
    {
        public override object Excel(int xlFunction, params object[] parameters)
        {
            return XlCall.Excel(xlFunction, parameters);
        }

        public override XlCall.XlReturn TryExcel(int xlFunction, out object result, params object[] parameters)
        {
            return XlCall.TryExcel(xlFunction, out result, parameters);
        }

        public override object RTD(string progId, string server, params string[] topics)
        {
            return XlCall.RTD(progId, server, topics);
        }
    }
}
