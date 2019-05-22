using NeuralNetworks.Public.Interfaces.ActivationFunction;
using System;

namespace NeuralNetworks.Impl.Classes.ActivationFunction
{
    internal class SigmoidActivationFunction : IActivationFunction
    {
        public double Activate(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
}
