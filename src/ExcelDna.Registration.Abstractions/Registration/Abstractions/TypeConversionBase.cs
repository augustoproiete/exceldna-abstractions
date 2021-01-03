#region Copyright 2013-2021 C. Augusto Proiete & Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

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
