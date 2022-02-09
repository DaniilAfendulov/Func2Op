using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.Models
{
    public class GaussianFunction : IRule
    {
        private float c, sigma;
        public GaussianFunction(float c, float sigma)
        {
            this.c = c;
            this.sigma = sigma;
        }
        public Func<float, float> GetFunc()
        {
            return x => (float)Math.Exp(-1*(x - c)*(x - c) / (2 * sigma * sigma));
        }
    }
}
