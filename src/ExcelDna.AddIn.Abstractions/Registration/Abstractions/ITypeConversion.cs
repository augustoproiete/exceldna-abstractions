using System;
using System.Linq.Expressions;

namespace ExcelDna.Registration.Abstractions
{
    public interface ITypeConversion
    {
        LambdaExpression GetConversion(Type inputType, Type targetType);

        Expression GetConversion(Expression input, Type type);

        object GetDefault(Type type);

        string ConvertToString(object value);

        DateTime ConvertToDateTime(object value);

        bool ConvertToBoolean(object value);

        double ConvertToDouble(object value);

        long ConvertToInt64(object value);

        int ConvertToInt32(object value);

        short ConvertToInt16(object value);

        ushort ConvertToUInt16(object value);

        decimal ConvertToDecimal(object value);
    }
}
