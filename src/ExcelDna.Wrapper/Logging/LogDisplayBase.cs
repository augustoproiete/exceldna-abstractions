using System;

namespace ExcelDna.Logging
{
    public abstract class LogDisplayBase : ILogDisplay
    {
        public virtual void Show()
        {
            throw new NotImplementedException();
        }

        public virtual void Hide()
        {
            throw new NotImplementedException();
        }

        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        public virtual void SetText(string text)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public virtual void RecordLine(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }
    }
}