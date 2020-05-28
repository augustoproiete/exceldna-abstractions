using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExcelDna.Integration;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class ExcelFunctionRegistrationBase
    {
        public virtual LambdaExpression FunctionLambda
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual ExcelFunctionAttribute FunctionAttribute
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual List<ExcelParameterRegistration> ParameterRegistrations => throw new NotImplementedException();

        public virtual List<object> CustomAttributes => throw new NotImplementedException();

        public virtual ExcelReturnRegistration ReturnRegistration => throw new NotImplementedException();

        internal virtual ExcelFunctionRegistration ExcelFunctionRegistrationInstance => throw new NotImplementedException();
    }
}
