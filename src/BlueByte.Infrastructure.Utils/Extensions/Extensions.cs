using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;

namespace BlueByte.Infrastructure.Utils.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Clamping a value to be sure it is between two values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static T Clamp<T>(this T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0) return min;
            else if (value.CompareTo(max) > 0) return max;
            else return value;
        }

        public static EBehavior ToBehavior(this string value)
        {
            if(Enum.TryParse(value, out EBehavior behavior))
            {
                return behavior;
            }
            else
            {
                throw new InvalidCastException();
            }
        }
    }
}
