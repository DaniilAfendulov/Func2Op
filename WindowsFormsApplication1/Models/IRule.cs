using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lf = System.Func<float, float>;

namespace FuncOperationsApplication.Models
{
    public interface IRule
    {
        lf GetFunc();
    }
}
