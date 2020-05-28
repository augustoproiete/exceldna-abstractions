using System;

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public abstract class CustomTaskPaneFactoryBase : ICustomTaskPaneFactory
    {
        public virtual CustomTaskPane CreateCustomTaskPane(Type userControlType, string title)
        {
            throw new NotImplementedException();
        }

        public virtual CustomTaskPane CreateCustomTaskPane(Type userControlType, string title, object parent)
        {
            throw new NotImplementedException();
        }

        public virtual CustomTaskPane CreateCustomTaskPane(object userControl, string title)
        {
            throw new NotImplementedException();
        }

        public virtual CustomTaskPane CreateCustomTaskPane(object userControl, string title, object parent)
        {
            throw new NotImplementedException();
        }

        public virtual CustomTaskPane CreateCustomTaskPane(string controlProgId, string title)
        {
            throw new NotImplementedException();
        }

        public virtual CustomTaskPane CreateCustomTaskPane(string controlProgId, string title, object parent)
        {
            throw new NotImplementedException();
        }
    }
}
