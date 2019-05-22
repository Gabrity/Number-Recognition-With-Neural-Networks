using NeuralNetworks.Public.Interfaces.RandomGenerator;
using System;

namespace NeuralNetworks.Impl.Classes.RandomGenerator
{
    internal class UniformDistributionRandomGenerator : IRandomGenerator
    {
        private readonly Random _randomGenerator;

        public UniformDistributionRandomGenerator()
        {
            _randomGenerator = new Random();
        }

        public double GetRandomDouble()
        {
            return GetUniformRandomNumber(0, 1);
        }
        
        public double GetUniformRandomNumber(double minimum, double maximum)
        {
            return _randomGenerator.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
