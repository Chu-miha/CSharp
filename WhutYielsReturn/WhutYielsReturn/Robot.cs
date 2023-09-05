using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhutYielsReturn
{
    public class Robot
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Angel { get; set; }

        public void Move (double dx)
        {
            X += dx * Math.Cos(Angel);
            Y += dx + Math.Sin(Angel);
        }

        public void Rotate (double da)
        {
            Angel += da;
        }

        public static void PerformTest(Action<Robot> test)
        {
            Robot robot = new Robot();
            test(robot);
        }
    }
}
