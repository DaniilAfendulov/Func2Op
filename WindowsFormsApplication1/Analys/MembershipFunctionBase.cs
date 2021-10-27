using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuncOperationsApplication.Analys
{
    public class MembershipFunctionBase : IMembershipFunction
    {
        Func<float, float> _strategy;
        public MembershipFunctionBase(Func<float, float> strategy)
        {
            _strategy = strategy;
        }
        public float GetAccuracy(float x)
        {
            return _strategy.Invoke(x);
        }
    }
}
