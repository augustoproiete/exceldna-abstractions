using System;

namespace ExcelDna.Integration.Abstractions
{
    public abstract class XlCallBase : IXlCall
    {
        public virtual object Excel(int xlFunction, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public virtual XlCall.XlReturn TryExcel(int xlFunction, out object result, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public virtual object RTD(string progId, string server, params string[] topics)
        {
            throw new NotImplementedException();
        }
    }
}
