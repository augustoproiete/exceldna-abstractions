using System;

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public class CustomTaskPaneFactoryWrapper : CustomTaskPaneFactoryBase
    {
        public static readonly ICustomTaskPaneFactory Instance = new CustomTaskPaneFactoryWrapper();

        public override CustomTaskPane CreateCustomTaskPane(Type userControlType, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControlType, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(Type userControlType, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControlType, title, parent);
        }

        public override CustomTaskPane CreateCustomTaskPane(object userControl, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControl, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(object userControl, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(userControl, title, parent);
        }

        public override CustomTaskPane CreateCustomTaskPane(string controlProgId, string title)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(controlProgId, title);
        }

        public override CustomTaskPane CreateCustomTaskPane(string controlProgId, string title, object parent)
        {
            return CustomTaskPaneFactory.CreateCustomTaskPane(controlProgId, title, parent);
        }
    }
}
