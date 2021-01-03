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
