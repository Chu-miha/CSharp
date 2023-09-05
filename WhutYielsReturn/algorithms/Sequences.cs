using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace algorithms
{
    public class Sequences
    {
    
        public static IEnumerable<int> Fibonacci 
        { 
            get 
            {
                int previous = 1;
                int current = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var newValue = current + previous;
                    previous = current;
                    current = newValue;
                    yield return current;
                }
            } 
        }
    }
    //можно так или так но тогда в get надо писать return FibonacciSequence()


    //public class FibonacciSequence : IEnumerable<int>
    //{
    //    public IEnumerator<int> GetEnumerator()
    //    {
    //        int previous = 1;
    //        int current = 1;
    //        yield return 1;
    //        yield return 1;
    //        while (true)
    //        {
    //            var newValue = current + previous;
    //            previous = current;
    //            current = newValue;
    //            yield return current;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}
}
