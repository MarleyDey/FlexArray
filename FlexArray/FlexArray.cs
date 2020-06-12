using System;

namespace FlexArray
{
    public static class FlexArray
    {
        /**
         * <summary>
         *  This method is used to fill an array with
         *  a generic type.
         *
         *  <param name="array">The array to be filled</param>
         *  <param name="value">The value to fill array with</param>
         * </summary>
         */
        public static void Fill<TArray>(this TArray[] array, TArray value)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        /**
         * <summary>
         *  This method is used to replace an array with
         *  a generic type value of the same type as the
         *  array.
         *
         *  <param name="array">The array with value to replace</param>
         *  <param name="value">The value to replace</param>
         *  <param name="replaceValue">The value to be replaced with</param>
         * </summary>
         */
        public static void Replace<TArray>(this TArray[] array, TArray value, TArray replaceValue)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var x = array[i];
                if (!x.Equals(value)) continue;

                array[i] = replaceValue;
                break;
            }
        }

        /**
         * <summary>
         *  This method is used to replace all values of a specific
         *  value with another value of the array type.
         *
         *  <param name="array">The array with value to replace</param>
         *  <param name="value">The value(s) to replace</param>
         *  <param name="replaceValue">The value(s) to be replaced with</param>
         * </summary>
         */
        public static void ReplaceAll<TArray>(this TArray[] array, TArray value, TArray replaceValue)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var x = array[i];
                if (!x.Equals(value)) continue;

                array[i] = replaceValue;
            }
        }

    }
}
