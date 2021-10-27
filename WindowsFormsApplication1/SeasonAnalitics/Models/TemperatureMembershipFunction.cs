using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncOperationsApplication.Analys;
using FuncOperationsApplication.Models;

namespace FuncOperationsApplication
{
    public class TemperatureMembershipFunction : IMembershipFunction
    {
        public TemperatureMembershipFunction()
        {

        }

        public float GetAccuracy(float x)
        {
            float step = 1.25f;
            float center = 1.0f;
            var f = SymmetricTriangleFunction.FactoryMethod(center,step,1,0);
            if (x > 13 - step)
            {
                f.GetFunc()(x-12);
            }
            if (x > center + step) return 0;
            return f.GetFunc()(x);
        }
    }
}
