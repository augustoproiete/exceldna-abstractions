using System.Collections.Generic;
using System.Linq;

namespace ExcelDna.Registration.Abstractions
{
    public class AsyncRegistrationWrapper : AsyncRegistrationBase
    {
        public static readonly IAsyncRegistration Instance = new AsyncRegistrationWrapper();

        public override IEnumerable<ExcelFunctionRegistrationBase> ProcessAsyncRegistrations(IEnumerable<ExcelFunctionRegistrationBase> registrationEntries, bool nativeAsyncIfAvailable = false)
        {
            var materializedEntries = registrationEntries.ToArray();

            // ReSharper disable InvokeAsExtensionMethod
            var _ = AsyncRegistration.ProcessAsyncRegistrations(materializedEntries.Select(f => f.ExcelFunctionRegistrationInstance));
            // ReSharper restore InvokeAsExtensionMethod

            return materializedEntries;
        }
    }
}
