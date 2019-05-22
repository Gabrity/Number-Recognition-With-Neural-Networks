using NeuralNetwork.Public.Interfaces.NeuralNetwork;

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

            foreach (var layerSize in layerSizes)
            {
                if (layerSize < 1)
                {
                    // throw new exception
                }


            }
        }
    }
}
