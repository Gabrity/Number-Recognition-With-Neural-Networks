using NeuralNetworks.Public.Interfaces.ActivationFunction;
using NeuralNetworks.Public.Interfaces.RandomGenerator;

namespace NeuralNetworks.Impl.Classes.ActivationFunction
{
    public interface INeuralNetworkFactory
    {    
        IActivationFunction GetNewActivationFunction();

        IRandomGenerator GetRandomGenerator();
    }    
}