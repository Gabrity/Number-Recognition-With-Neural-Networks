using NeuralNetworks.Impl.Classes.ActivationFunction;
using NeuralNetworks.Public.Interfaces.ActivationFunction;

namespace NeuralNetworks.Impl.Factories
{
    public class StandardNeuralNetworkFactory : INeuralNetworkFactory
    {
        public StandardNeuralNetworkFactory()
        {
        }

        public IActivationFunction GetNewActivationFunction()
        {
            return new SigmoidActivationFunction();
        }
    }
}
