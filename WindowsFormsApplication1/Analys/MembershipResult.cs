using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.Analys
{
    public struct MembershipResult<T>
    {
        public MembershipResult(T answer, float accuracy)
        {
            Answer = answer;
            Accuracy = accuracy;
        }
        public T Answer { get; }
        public float Accuracy { get; }
    }
}
