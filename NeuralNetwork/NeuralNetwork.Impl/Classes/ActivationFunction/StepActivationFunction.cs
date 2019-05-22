using NeuralNetworks.Public.Interfaces.ActivationFunction;

namespace NeuralNetworks.Impl.Classes.ActivationFunction
{
    internal class StepActivationFunction : IActivationFunction
    {
        public double Activate(double x)
        {
            return (x > 0) ? 1.0 : 0.0;            
        }
    }
}
