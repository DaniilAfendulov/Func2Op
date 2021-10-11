using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public static class MidpontHelper
    {
        public static float GetPointsMidpoint(IEnumerable<float> x)
        {
            return x.Sum() / x.Count();
        }
        public static float GetPointsMidpoint(IEnumerable<PointF> x)
        {
            return GetPointsMidpoint(x.Select(p => p.X));
        }

        public static float GetIntervalsMidpoint(IEnumerable<Interval> intervals)
        {
            return intervals.Select(interval => (float)Math.Sqrt(interval.End.X) - (float)Math.Sqrt(interval.Start.X)).Sum() / intervals.Select(interval => interval.End.X - interval.Start.X).Sum();
        }
    }
}
