using FuncOperationsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncOperationsApplication.Analys;
using System.Drawing;

namespace FuncOperationsApplication.SeasonAnalitics.Models
{
    public class SeasonMembershipFunction : MembershipFunctionBase<Season>
    {
        public SeasonMembershipFunction(ParamData<Season>[] paramsData, float step) : base(paramsData)
        {
            var strategies = new Func<float, ParamData<Season>, MembershipResult<Season>>[paramsData.Length];
            //for (int i = 0; i < paramsData.Length; i++)
            //{
            //    strategies[i] = GetSeasonAccuracyMethod(paramsData[i].AssociatedAnswer, step);
            //}
            //var strategies = new Func<float, float[], MembershipResult<Season>>[4]
            //{
            //    GetSeasonAccuracyMethod(Season.Winter, step),
            //    GetSeasonAccuracyMethod(Season.Spring, step),
            //    GetSeasonAccuracyMethod(Season.Summer, step),
            //    GetSeasonAccuracyMethod(Season.Autumn, step)
            //};
            InitStrategies(strategies);
        }
        private float GetCommonSeasonAccuracy(float temp, float center, float step)
        {
            if (temp <= center - step || temp >= center + step)
            {
                return 0;
            }
            return SymmetricTriangleFunction.FactoryMethod(center, step, 1, 0).GetFunc()(temp);
            
        }

        private MembershipResult<Season> GetSeasonAccuracy(float x, ParamData<Season> paramData, float step)
        {
            float average = paramData.Data.Average();
            return new MembershipResult<Season>(paramData.AssociatedAnswer, GetCommonSeasonAccuracy(x, average, step));
        }

        //private Func<float, ParamData<Season>, MembershipResult<Season>> GetSeasonAccuracyMethod(Season season, float step)
        //{
        //    MembershipResult<Season> getSeasonAccuracyMethod(float x, ParamData<Season> data)
        //    {
        //        return GetSeasonAccuracy(x, data, step);
        //    }
        //    return GetSeasonAccuracyMethod;
        //}

    }

}
