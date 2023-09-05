using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public class FindASubstringInString
    {
        public static bool Equals (string text, string query, int index)
        {
            for (int i = 0; i < query.Length; i++)
            {
                if (text[index + i] == query[i]) return false;
            }
            return true;
        }

        public static int IndexOf(string text, string query) 
        {
        //    for (int i = 0;i < text.Length - query.Length; i++ )
        //    {
        //        if(Equals(text,query,i)) return i;
        //    }
        //    return -1;
            if (text.Length < query.Length) return -1;

            var p = 1000;
            var textHash = 0;
            var queryHash = 0;
            var maxPower = 1;

            for (int i = 0; i < query.Length; i++)
            {
                textHash = textHash * p + text[i];
                queryHash = queryHash * p + query[i];
                maxPower *= p;

            }
            maxPower /= p;
            for (int i = 0; ; i++)
            {
                if (textHash == queryHash)
                {
                    if (Equals(text, query, 0))
                    {
                        return 0;
                    }
                }
                if (i >= text.Length - query.Length)
                    break;
                textHash -= text[0] * maxPower;
                textHash = textHash * p + text[query.Length];
            }

            return -1;
        }

    }
}
