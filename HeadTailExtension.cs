using System;
using System.Collections.Generic;

namespace HeadTailSample
{
    public static class HeadTailExtension
    {
        public static T HeadTail<T>(this IEnumerable<T> values, out IEnumerable<T> tail)
        {
            var enumerator = values.GetEnumerator();
            enumerator.MoveNext();
            var head = enumerator.Current;

            IEnumerable<T> enumTail()
            {
                while (enumerator.MoveNext())
                {
                    yield return enumerator.Current;
                }
            }
            tail = enumTail();

            return head;
        }
    }
}
