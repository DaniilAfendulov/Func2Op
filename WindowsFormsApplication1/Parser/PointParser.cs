using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public class PointParser : IPointParser
    {
        public PointF[] ParsePoints(string s)
        {
            var PointFs = s.Split(new char[] { ';' });
            return PointFs.Select(p => ParsePoint(p)).ToArray();
        }

        public PointF ParsePoint(string s)
        {
            var values = s.Split(new char[] { ' ' }).Select(v => float.Parse(v)).ToArray();
            return new PointF(values[0], values[1]);
        }

        public string GetPointText(PointF point)
        {
            return point.X + " " + point.Y;
        }

        public string GetPointsText(IEnumerable<PointF> points)
        {
            return string.Join(";", points.Select(p => GetPointText(p)).ToArray());
        }
    }
}
