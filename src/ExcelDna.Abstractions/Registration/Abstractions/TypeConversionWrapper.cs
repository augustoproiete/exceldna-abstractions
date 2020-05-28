using System;
using System.Linq.Expressions;

namespace ExcelDna.Registration.Abstractions
{
    public class TypeConversionWrapper : TypeConversionBase
    {
        public override LambdaExpression GetConversion(Type inputType, Type targetType)
        {
            return TypeConversion.GetConversion(inputType, targetType);
        }

        public override Expression GetConversion(Expression input, Type type)
        {
            return TypeConversion.GetConversion(input, type);
        }

        public override object GetDefault(Type type)
        {
            return TypeConversion.GetDefault(type);
        }

        public override string ConvertToString(object value)
        {
            return TypeConversion.ConvertToString(value);
        }

        public override DateTime ConvertToDateTime(object value)
        {
            return TypeConversion.ConvertToDateTime(value);
        }

        public override bool ConvertToBoolean(object value)
        {
            return TypeConversion.ConvertToBoolean(value);
        }

        public override double ConvertToDouble(object value)
        {
            return TypeConversion.ConvertToDouble(value);
        }

        public override long ConvertToInt64(object value)
        {
            return TypeConversion.ConvertToInt64(value);
        }

        public override int ConvertToInt32(object value)
        {
            return TypeConversion.ConvertToInt32(value);
        }

        public override short ConvertToInt16(object value)
        {
            return TypeConversion.ConvertToInt16(value);
        }

        public override ushort ConvertToUInt16(object value)
        {
            return TypeConversion.ConvertToUInt16(value);
        }

        public override decimal ConvertToDecimal(object value)
        {
            return TypeConversion.ConvertToDecimal(value);
        }
    }
}
