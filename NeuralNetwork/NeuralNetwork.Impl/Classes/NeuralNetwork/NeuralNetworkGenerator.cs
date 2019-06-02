using NeuralNetwork.Public.Interfaces.NeuralNetwork;
using System.Collections.Generic;

namespace NeuralNetwork.Impl.Classes.NeuralNetwork
{
    public class NeuralNetworkGenerator : INeuralNetworkGenerator
    {
        public NeuralNetworkGenerator()
        {

        }

        public INeuralNetwork GenerateNeuralNetwork(int[] layerSizes)
        {
            if (layerSizes.Length < 2)
            {
                // throw new exception
            }

            var neurons = GenerateNeurons(layerSizes);            
        }

        private IList<INeuron>[] GenerateNeurons(int[] layerSizes)
        {
            var neurons = new List<INeuron>[layerSizes.Length];
            for (int i = 0; i < layerSizes.Length; i++)
            {
                var size = layerSizes[i];
                if (size < 1)
                {
                    // throw new exception
                }

                var layer = GenerateLayer(layerSizes[i]);
                neurons[size] = layer;
            }

            return neurons;
        }

        private List<INeuron> GenerateLayer(int layerSize)
        {
            var layer = new List<INeuron>();
            for (int i = 0; i < layerSize; i++)
            {
                var neuron = new Neuron();
                layer.Add(neuron);
            }

            return layer;
        }
    }
}
