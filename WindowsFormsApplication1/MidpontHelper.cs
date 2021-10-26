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
            var pointsx = x.ToArray();
            var sum = x.Sum();
            var lenght = x.Count();
            return x.Sum() / x.Count();
        }
        public static float GetPointsMidpoint(IEnumerable<PointF> x)
        {
            return GetPointsMidpoint(x.Select(p => p.X));
        }

        public static float GetIntervalsMidpoint(IEnumerable<Interval> intervals)
        {
            return intervals.Select(interval => ((float)Math.Pow(interval.End.X,2) - (float)Math.Pow(interval.Start.X,2))/2).Sum() / intervals.Select(interval => interval.End.X - interval.Start.X).Sum();
        }
    }
}
