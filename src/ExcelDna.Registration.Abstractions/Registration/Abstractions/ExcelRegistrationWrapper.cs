using System.Collections.Generic;
using System.Linq;

namespace ExcelDna.Registration.Abstractions
{
    public class ExcelRegistrationWrapper : ExcelRegistrationBase
    {
        public static readonly IExcelRegistration Instance = new ExcelRegistrationWrapper();

        public override IEnumerable<ExcelFunctionRegistrationBase> GetExcelFunctions()
        {
            return ExcelRegistration.GetExcelFunctions()
                .Select(f => (ExcelFunctionRegistrationBase)new ExcelFunctionRegistrationWrapper(f));
        }

        public override IEnumerable<ExcelCommandRegistrationBase> GetExcelCommands()
        {
            return ExcelRegistration.GetExcelCommands()
                .Select(c => (ExcelCommandRegistrationBase)new ExcelCommandRegistrationWrapper(c));
        }

        public override void RegisterFunctions(IEnumerable<ExcelFunctionRegistrationBase> registrationEntries)
        {
            // ReSharper disable InvokeAsExtensionMethod
            ExcelRegistration.RegisterFunctions(registrationEntries.Select(f => f.ExcelFunctionRegistrationInstance));
            // ReSharper restore InvokeAsExtensionMethod
        }

        public override void RegisterCommands(IEnumerable<ExcelCommandRegistrationBase> registrationEntries)
        {
            // ReSharper disable InvokeAsExtensionMethod
            ExcelRegistration.RegisterCommands(registrationEntries.Select(f => f.ExcelCommandRegistrationInstance));
            // ReSharper restore InvokeAsExtensionMethod
        }
    }
}
