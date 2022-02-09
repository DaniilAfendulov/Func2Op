namespace Neuron
{
    public class FullyConnectedNetwork : NeuronNetwork
    {
        private FullyConnectedNetwork(Neuron[] neurons, int[][] incomingNeuronsLinks, int[][] outgoingNeuronsLinks) 
            : base(neurons, incomingNeuronsLinks, outgoingNeuronsLinks)
        {
        }

        public FullyConnectedNetwork Create(Neuron[] neurons)
        {
            int[][] neuronsLinks = new int[Neurons.Length][];
            for (int i = 0; i < Neurons.Length; i++)
            {
                neuronsLinks[i] = new int[Neurons.Length];
                for (int j = 0; j < Neurons.Length; j++)
                {
                    neuronsLinks[i][j] = j;
                }
            }
            return new FullyConnectedNetwork(neurons, neuronsLinks, neuronsLinks);
        }

    }
}
