using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDelegate
{
    public class AlphabeticComparer
    {
        public bool Descending { get; set; }
        public int Compare(string x, string y)
        {
            return x.CompareTo(y) * (Descending ? -1 : 1) ;
        }
    }
}
