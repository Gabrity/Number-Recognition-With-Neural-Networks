using NeuralNetworks.Public.Interfaces.ActivationFunction;

namespace NeuralNetworks.Impl.Classes.ActivationFunction
{
    public interface INeuralNetworkFactory
    {    
        IActivationFunction GetNewActivationFunction();
    }
}