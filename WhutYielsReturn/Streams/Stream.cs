using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    public class Stream
    {
        //протстой пример потока 
        public static void MakeWork (int number)
        {
            double a = 1;

            for (int i = 0; i < 1000000; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    a /= 1.01;
                }
            }
            Console.WriteLine(number);
         
        }
    }
}
