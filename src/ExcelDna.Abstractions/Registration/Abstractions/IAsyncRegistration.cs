using System.Collections.Generic;

namespace ExcelDna.Registration.Abstractions
{
    public interface IAsyncRegistration
    {
        IEnumerable<ExcelFunctionRegistrationBase> ProcessAsyncRegistrations(IEnumerable<ExcelFunctionRegistrationBase> registrations, bool nativeAsyncIfAvailable = false);
    }
}
