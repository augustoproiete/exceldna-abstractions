using System;

namespace ExcelDna.Integration.CustomUI.Abstractions
{
    public interface ICustomTaskPaneFactory
    {
        CustomTaskPane CreateCustomTaskPane(Type userControlType, string title);
        CustomTaskPane CreateCustomTaskPane(Type userControlType, string title, object parent);
        CustomTaskPane CreateCustomTaskPane(object userControl, string title);
        CustomTaskPane CreateCustomTaskPane(object userControl, string title, object parent);
        CustomTaskPane CreateCustomTaskPane(string controlProgId, string title);
        CustomTaskPane CreateCustomTaskPane(string controlProgId, string title, object parent);
    }
}
