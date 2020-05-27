using System.Collections.Generic;

namespace ExcelDna.Registration.Abstractions
{
    public interface IExcelRegistration
    {
        IEnumerable<ExcelFunctionRegistrationBase> GetExcelFunctions();
        IEnumerable<ExcelCommandRegistrationBase> GetExcelCommands();

        void RegisterFunctions(IEnumerable<ExcelFunctionRegistrationBase> registrationEntries);
        void RegisterCommands(IEnumerable<ExcelCommandRegistrationBase> registrationEntries);
    }
}
