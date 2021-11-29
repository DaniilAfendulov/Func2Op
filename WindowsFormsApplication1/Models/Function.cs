using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lf = System.Func<float, float>;
using FuncOperationsApplication.Models;

namespace FuncOperationsApplication
{
    public class Function : IRule
    {
        public PointF[] Points;
        public lf[] Functions;
        public Function(PointF[] p)
        {
            Points = p;

            Functions = new lf[p.Length+1];
            Functions[0] = x => Points[0].Y;
            for (int i = 0; i < p.Length-1; i++)
            {
                Functions[i+1] = FuncOp.LineF(Points[i], Points[i + 1]);
            }
            Functions[p.Length] = x => Points[p.Length-1].Y;
        }
        public lf GetFunc()
        {
            return x => (x<=Points[0].X?Functions[0]:Functions[Points.ToList().FindLastIndex(point => point.X < x)+1])(x);
        }
    }
}
