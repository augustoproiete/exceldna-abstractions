using System;

namespace ExcelDna.Logging.Abstractions
{
    public class LogDisplayWrapper : LogDisplayBase
    {
        public override void Show()
        {
            LogDisplay.Show();
        }

        public override void Hide()
        {
            LogDisplay.Hide();
        }

        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        public override void SetText(string text)
        {
            LogDisplay.SetText(text);
        }

        public override void WriteLine(string format, params object[] args)
        {
            LogDisplay.WriteLine(format, args);
        }

        public override void RecordLine(string format, params object[] args)
        {
            LogDisplay.RecordLine(format, args);
        }

        public override void Clear()
        {
            LogDisplay.Clear();
        }

        public override DisplayOrder DisplayOrder
        {
            get => LogDisplay.DisplayOrder;
            set => LogDisplay.DisplayOrder = value;
        }
    }
}
