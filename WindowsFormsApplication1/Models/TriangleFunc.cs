using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lf = System.Func<float, float>;

namespace FuncOperationsApplication
{
    public class TriangleFunc : Function
    {
        public TriangleFunc(PointF[] p)
            : base(p)
        {
        }
    }
}
