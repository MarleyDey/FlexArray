using System;

namespace FlexArray
{
    public static class FlexArray
    {
        public static void Fill<TArray>(this TArray[] array, TArray value)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

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
