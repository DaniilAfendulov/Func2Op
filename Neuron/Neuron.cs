using System;
using System.Linq;

namespace Neuron
{
    public class Neuron
    {
        private readonly IActivationFunction _activationFunction;
        private double[] _omegas;
        private double _offset;

        public Neuron(IActivationFunction activationFunction, double[] omegas, double offset)
        {
            _activationFunction = activationFunction ?? throw new ArgumentNullException(nameof(activationFunction));
            _omegas = omegas ?? throw new ArgumentNullException(nameof(omegas));
            _offset = offset;
        }

        public double Calc(double[] inputs)
        {
            if (inputs.Length != _omegas.Length) 
                throw new ArgumentOutOfRangeException("неверное количество входных сигналов");

            double[] changedInputs = new double[_omegas.Length];
            for (int i = 0; i < changedInputs.Length; i++)
            {
                changedInputs[i] = _omegas[i] * inputs[i];
            }

            double sum = changedInputs.Sum() + _offset;

            return _activationFunction.Calc(sum);
        }
    }
}
