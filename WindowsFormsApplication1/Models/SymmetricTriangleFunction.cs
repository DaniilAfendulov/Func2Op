using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.Models
{
    public class SymmetricTriangleFunction : TriangleFunc
    {
        private SymmetricTriangleFunction(PointF[] points) : base(points)
        {
        } 

        public static SymmetricTriangleFunction FactoryMethod(float center, float step, float maxY, float minY)
        {
            PointF[] points = new PointF[3]
            {
                new PointF(center - step, minY),
                new PointF(center, maxY),
                new PointF(center + step, minY)
            };
            return new SymmetricTriangleFunction(points);
        }
    }
}
