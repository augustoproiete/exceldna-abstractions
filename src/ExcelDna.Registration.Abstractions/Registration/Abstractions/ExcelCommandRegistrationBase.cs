using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExcelDna.Integration;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class ExcelCommandRegistrationBase
    {
        public virtual LambdaExpression CommandLambda
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual ExcelCommandAttribute CommandAttribute
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual List<object> CustomAttributes
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        internal virtual ExcelCommandRegistration ExcelCommandRegistrationInstance => throw new NotImplementedException();
    }
}
