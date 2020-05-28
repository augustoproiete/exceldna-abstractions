using System;
using System.Collections.Generic;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class ExcelRegistrationBase : IExcelRegistration
    {
        public virtual IEnumerable<ExcelFunctionRegistrationBase> GetExcelFunctions()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<ExcelCommandRegistrationBase> GetExcelCommands()
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterFunctions(IEnumerable<ExcelFunctionRegistrationBase> registrationEntries)
        {
            throw new NotImplementedException();
        }

        public virtual void RegisterCommands(IEnumerable<ExcelCommandRegistrationBase> registrationEntries)
        {
            throw new NotImplementedException();
        }
    }
}
