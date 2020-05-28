using System;
using System.Collections.Generic;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class AsyncRegistrationBase : IAsyncRegistration
    {
        public virtual IEnumerable<ExcelFunctionRegistrationBase> ProcessAsyncRegistrations(IEnumerable<ExcelFunctionRegistrationBase> registrations, bool nativeAsyncIfAvailable = false)
        {
            throw new NotImplementedException();
        }
    }
}
