using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public interface IRule<T>
    {
        IMembershipFunction<T> Compose(IMembershipFunction<T>[] functions);
    }
}
