using System;

namespace Neuron.ActivationFunctions
{
    public class Sigmoid : IActivationFunction
    {
        public double Calc(double input)
        {
            return 1.0 / (1 + Math.Exp(-input));
        }
    }
}
