using NeuralNetworks.Impl.Classes.ActivationFunction;
using NeuralNetworks.Impl.Classes.RandomGenerator;
using NeuralNetworks.Public.Interfaces.ActivationFunction;
using NeuralNetworks.Public.Interfaces.RandomGenerator;
using System;

namespace NeuralNetworks.Impl.Factories
{
    // The standard factory uses sigmoid activation function, uniform normal distribution for the random numbers

    public class StandardNeuralNetworkFactory : INeuralNetworkFactory
    {
        private Random _random;
        private IRandomGenerator _randomGenerator;
        
        public StandardNeuralNetworkFactory()
        {
            _randomGenerator = null;
        }

        public IRandomGenerator GetRandomGenerator()
        {
            if (_randomGenerator == null)
            {
                _randomGenerator = new NormalDistributionRandomGenerator(_random);                
            }

            return _randomGenerator;
        }

        public IActivationFunction GetNewActivationFunction()
        {
            return new SigmoidActivationFunction();
        }
    }
}
