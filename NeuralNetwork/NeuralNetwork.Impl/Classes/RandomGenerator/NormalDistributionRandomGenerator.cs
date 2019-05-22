using MathNet.Numerics.Distributions;
using NeuralNetworks.Public.Interfaces.RandomGenerator;
using System;

namespace NeuralNetworks.Impl.Classes.RandomGenerator
{
    internal class NormalDistributionRandomGenerator : IRandomGenerator
    {
        private readonly Normal _normalRandomGenerator;

        public NormalDistributionRandomGenerator(Random random)
        {
            _normalRandomGenerator = new Normal(0.0, 1.0, random);
        }

        public double GetRandomDouble()
        {            
            return _normalRandomGenerator.Sample();
        }
    }
}
