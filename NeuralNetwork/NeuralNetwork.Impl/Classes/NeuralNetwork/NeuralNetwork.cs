using NeuralNetwork.Public.Interfaces.NeuralNetwork;
using System.Collections.Generic;

namespace NeuralNetwork.Impl.Classes.NeuralNetwork
{
    class NeuralNetwork : INeuralNetwork
    {
        private IList<INeuron>[] _neurons;
    }
}
