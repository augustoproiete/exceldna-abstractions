using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExcelDna.Integration;

namespace ExcelDna.Registration.Abstractions
{
    public class ExcelCommandRegistrationWrapper : ExcelCommandRegistrationBase
    {
        private readonly ExcelCommandRegistration _excelCommandRegistration;

        public ExcelCommandRegistrationWrapper(ExcelCommandRegistration excelCommandRegistration)
        {
            _excelCommandRegistration = excelCommandRegistration ?? throw new ArgumentNullException(nameof(excelCommandRegistration));
        }

        public override LambdaExpression CommandLambda
        {
            get => _excelCommandRegistration.CommandLambda;
            set => _excelCommandRegistration.CommandLambda = value;
        }

        public override ExcelCommandAttribute CommandAttribute
        {
            get => _excelCommandRegistration.CommandAttribute;
            set => _excelCommandRegistration.CommandAttribute = value;
        }

        public override List<object> CustomAttributes
        {
            get => _excelCommandRegistration.CustomAttributes;
            set => _excelCommandRegistration.CustomAttributes = value;
        }

        internal override ExcelCommandRegistration ExcelCommandRegistrationInstance => _excelCommandRegistration;
    }
}
