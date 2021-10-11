using System.Collections.Generic;
using System.Drawing;

namespace FuncOperationsApplication
{
    public interface IPointParser
    {
        string GetPointsText(IEnumerable<PointF> points);
        string GetPointText(PointF point);
        PointF ParsePoint(string s);
        PointF[] ParsePoints(string s);
    }
}