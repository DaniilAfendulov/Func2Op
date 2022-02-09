using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron.ActivationFunctions
{
    public class LinearFunction : IActivationFunction
    {
        public double Calc(double input)
        {
            return input;
        }
    }
}
