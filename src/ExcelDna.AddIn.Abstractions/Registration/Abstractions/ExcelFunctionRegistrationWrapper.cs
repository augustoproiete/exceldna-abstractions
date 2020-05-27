using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExcelDna.Integration;

namespace ExcelDna.Registration.Abstractions
{
    public class ExcelFunctionRegistrationWrapper : ExcelFunctionRegistrationBase
    {
        private readonly ExcelFunctionRegistration _excelFunctionRegistration;

        public ExcelFunctionRegistrationWrapper(ExcelFunctionRegistration excelFunctionRegistration)
        {
            _excelFunctionRegistration = excelFunctionRegistration ?? throw new ArgumentNullException(nameof(excelFunctionRegistration));
        }

        public override LambdaExpression FunctionLambda
        {
            get => _excelFunctionRegistration.FunctionLambda;
            set => _excelFunctionRegistration.FunctionLambda = value;
        }

        public override ExcelFunctionAttribute FunctionAttribute
        {
            get => _excelFunctionRegistration.FunctionAttribute;
            set => _excelFunctionRegistration.FunctionAttribute = value;
        }

        public override List<ExcelParameterRegistration> ParameterRegistrations => _excelFunctionRegistration.ParameterRegistrations;

        public override List<object> CustomAttributes => _excelFunctionRegistration.CustomAttributes;

        public override ExcelReturnRegistration ReturnRegistration => _excelFunctionRegistration.ReturnRegistration;

        internal override ExcelFunctionRegistration ExcelFunctionRegistrationInstance => _excelFunctionRegistration;
    }
}
