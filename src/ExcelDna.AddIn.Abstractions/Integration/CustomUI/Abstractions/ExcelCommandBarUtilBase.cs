using System;

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public abstract class ExcelCommandBarUtilBase : IExcelCommandBarUtil
    {
        public virtual CommandBars GetCommandBars()
        {
            throw new NotImplementedException();
        }

        public virtual void LoadCommandBars(string xmlCustomUI)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadCommandBars(string xmlCustomUI, GetImageDelegate getImage)
        {
            throw new NotImplementedException();
        }

        public virtual void UnloadCommandBars()
        {
            throw new NotImplementedException();
        }
    }
}
