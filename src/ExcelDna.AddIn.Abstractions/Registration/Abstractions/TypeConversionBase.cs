using System;
using System.Linq.Expressions;

namespace ExcelDna.Registration.Abstractions
{
    public abstract class TypeConversionBase : ITypeConversion
    {
        public virtual LambdaExpression GetConversion(Type inputType, Type targetType)
        {
            throw new NotImplementedException();
        }

        public virtual Expression GetConversion(Expression input, Type type)
        {
            throw new NotImplementedException();
        }

        public virtual object GetDefault(Type type)
        {
            throw new NotImplementedException();
        }

        public virtual string ConvertToString(object value)
        {
            throw new NotImplementedException();
        }

        public virtual DateTime ConvertToDateTime(object value)
        {
            throw new NotImplementedException();
        }

        public virtual bool ConvertToBoolean(object value)
        {
            throw new NotImplementedException();
        }

        public virtual double ConvertToDouble(object value)
        {
            throw new NotImplementedException();
        }

        public virtual long ConvertToInt64(object value)
        {
            throw new NotImplementedException();
        }

        public virtual int ConvertToInt32(object value)
        {
            throw new NotImplementedException();
        }

        public virtual short ConvertToInt16(object value)
        {
            throw new NotImplementedException();
        }

        public virtual ushort ConvertToUInt16(object value)
        {
            throw new NotImplementedException();
        }

        public virtual decimal ConvertToDecimal(object value)
        {
            throw new NotImplementedException();
        }
    }
}
