using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.Analys
{
    public struct MembershipResult<T>
    {
        private T _answer;
        private float _accuracy;
        public MembershipResult(T answer, float accuracy)
        {
            _answer = answer;
            _accuracy = accuracy;
        }
        public T Answer { get { return _answer; } }
        public float Accuracy { get { return _accuracy; } }
    }
}
