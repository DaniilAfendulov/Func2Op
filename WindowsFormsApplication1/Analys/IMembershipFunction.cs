using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncOperationsApplication.SeasonAnalitics.Models;
using FuncOperationsApplication.Analys;
namespace FuncOperationsApplication
{
    public interface IMembershipFunction<T>
    {
        MembershipResult<T>[] GetAccuracy(float x);
    }
}
