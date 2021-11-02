using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuncOperationsApplication.Analys
{
    public class MembershipFunctionBase<T> : IMembershipFunction<T>
    {
        private ParamData<T>[] _paramsData;
        private Func<float, ParamData<T>, MembershipResult<T>>[] _strategies;
        public MembershipFunctionBase(ParamData<T>[] paramsData)
        {
            InitParamsData(paramsData);
        }
        public MembershipFunctionBase(ParamData<T>[] paramsData, Func<float, ParamData<T>, MembershipResult<T>>[] strategies)
            : this(paramsData)
        {
            InitStrategies(strategies);
        }
        protected void InitStrategies(Func<float, ParamData<T>, MembershipResult<T>>[] strategies)
        {
            _strategies = strategies;
        }
        protected void InitParamsData(ParamData<T>[] paramsData)
        {
            _paramsData = paramsData;
        }
        public MembershipResult<T>[] GetAccuracy(float x)
        {
            MembershipResult<T>[] result = new MembershipResult<T>[_paramsData.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = _strategies[i](x, _paramsData[i]);
            }
            return result;
        }
    }
}
