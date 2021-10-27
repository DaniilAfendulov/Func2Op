using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncOperationsApplication.Analys;
using FuncOperationsApplication;

namespace FuncOperationsApplication
{
    public abstract class ComposedRuleBase : IComposedRule
    {
        public IMembershipFunction Compose(IRule[] rules, IMembershipFunction[][] functions)
        {
            var rulesResults = new Func<float, float>[rules.Length];
            for (int i = 0; i < rules.Length; i++)
			{
                rulesResults[i] = rules[i].Compose(functions[i]).GetAccuracy;
			}
            return new MembershipFunctionBase(FuncOp.Union(rulesResults));
        }
    }
}
