
using ArtificialNeuralNetwork;
using GeneticData;
using MathNet.Numerics.LinearAlgebra;
using System;

namespace GeneticNeuralNetwork
{
    public class GenNeuralNet : NeuralNetwork, IComparable
    {
        public float Fitness { get; set; }

        Chromosome cWeights;
        Chromosome cBias;

        public ChromossomeConfig Config { get; }

        public GenNeuralNet(GenNeuralNet geneticNeuralNetwork) : base(geneticNeuralNetwork)
        {
            Config = geneticNeuralNetwork.Config;
            cWeights = new Chromosome(TotalWeigths, Config);
            cBias = new Chromosome(TotalBias, Config);
        }

        public GenNeuralNet(int inputs, int outputs, ChromossomeConfig config = ChromossomeConfig.WithDominance) : base(inputs, outputs)
        {
            Config = config;
            cWeights = new Chromosome(TotalWeigths, Config);
            cBias = new Chromosome(TotalBias, Config);
        }

        public GenNeuralNet(int inputs, int hiddenLayers, int hiddenLayerNeurons, int outputs, ChromossomeConfig config = ChromossomeConfig.WithDominance) : base(inputs, hiddenLayers, hiddenLayerNeurons, outputs)
        {
            Config = config;
            cWeights = new Chromosome(TotalWeigths, Config);
            cBias = new Chromosome(TotalBias, Config);
        }

        public GenNeuralNet(GenNeuralNet geneticNeuralNetwork1, GenNeuralNet geneticNeuralNetwork2)
        {
            if (geneticNeuralNetwork1.Config != geneticNeuralNetwork2.Config)
                throw new Exception("The GeneticNeuralNetworks must have the same config");

            if (geneticNeuralNetwork1.TotalLayers != geneticNeuralNetwork2.TotalLayers)
                throw new Exception("The GeneticNeuralNetworks must have the same number of layers");

            Config = geneticNeuralNetwork1.Config;

            weights = new Matrix<float>[geneticNeuralNetwork1.TotalLayers];
            bias = new Matrix<float>[geneticNeuralNetwork1.TotalLayers];

            for (int l = 0; l < geneticNeuralNetwork1.TotalLayers; l++)
            {
                weights[l] = Matrix<float>.Build.DenseOfMatrix(geneticNeuralNetwork1.Weights[l]);
                bias[l] = Matrix<float>.Build.DenseOfMatrix(geneticNeuralNetwork1.Bias[l]);
            }

            Weights = weights;
            Bias = bias;

            cWeights = new Chromosome(geneticNeuralNetwork1.cWeights, geneticNeuralNetwork2.cWeights);
            cBias = new Chromosome(geneticNeuralNetwork1.cBias, geneticNeuralNetwork2.cBias);

      
            int biasCount = 0;
            int weightsCount = 0;

            for (int l = 0; l < Weights.Length; l++)
                for (int j = 0; j < Bias[l].ColumnCount; j++)
                {
                    Bias[l][0, j] = cBias[biasCount].Value;
                    biasCount++;

                    for (int i = 0; i < Weights[l].RowCount; i++)
                    {
                        Weights[l][i, j] = cWeights[weightsCount].Value;
                        weightsCount++;
                    }
                }
        }

        new public void Randomize()
        {
            int biasCount = 0;
            int weightsCount = 0;

            cWeights.Randomize(RandomizationType.Pattern);
            cBias.Randomize(RandomizationType.Pattern);

            for (int l = 0; l < Weights.Length; l++)
                for (int j = 0; j < Bias[l].ColumnCount; j++)
                {
                    Bias[l][0, j] = cBias[biasCount].Value;
                    biasCount++;

                    for (int i = 0; i < Weights[l].RowCount; i++)
                    {
                        Weights[l][i, j] = cWeights[weightsCount].Value;
                        weightsCount++;
                    }
                }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is GenNeuralNet otherNeuralNet)
                return Fitness.CompareTo(otherNeuralNet.Fitness);
            else
                throw new ArgumentException("Object is not a GenNeuralNet");
        }
    }
}
