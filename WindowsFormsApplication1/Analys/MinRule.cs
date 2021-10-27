using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncOperationsApplication;

namespace FuncOperationsApplication.Analys
{
    public class MinRule : IRule
    {
        public IMembershipFunction Compose(IMembershipFunction[] functions)
        {
            var f = new System.Func<float, float>[functions.Length];
            for (int i = 0; i < functions.Length; i++)
            {
                f[i] = functions[i].GetAccuracy;
            }
            return new MembershipFunctionBase(FuncOp.Intersection(f));
        }
    }
}
