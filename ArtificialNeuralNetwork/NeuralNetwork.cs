using System;
using System.Drawing;
//using System.Drawing.Drawing2D;
using System.Text;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace ArtificialNeuralNetwork
{
    public class NeuralNetwork
    {
        public static FunctionType FunctionType { get; set; } = FunctionType.Leaky_ReLu;

        /// <summary>
        /// Number of inputs
        /// </summary>
        public int Inputs => Weights[0].RowCount;

        /// <summary>
        /// Number of hiddenLayers
        /// </summary>
        public int HiddenLayers => Weights.Length - 1;

        /// <summary>
        /// Retuns the total layers of neurons (HiddenLayers + OutputLayer)
        /// </summary>
        public int TotalLayers => Weights.Length;

        /// <summary>
        /// Number of outputs
        /// </summary>
        public int Outputs => Weights[Weights.Length - 1].ColumnCount;

        protected Matrix<float>[] weights;

        public Matrix<float>[] Weights
        {
            get => weights;

            set
            {
                weights = value;

                TotalWeigths = 0;

                for (int l = 0; l < weights.Length; l++)
                    TotalWeigths += weights[l].RowCount * weights[l].ColumnCount;
            }
        }

        /// <summary>
        /// The total number of weights
        /// </summary>
        public int TotalWeigths { get; private set; }

        protected Matrix<float>[] bias;

        public Matrix<float>[] Bias
        {
            get => bias;

            set
            {
                bias = value;

                TotalBias = 0;

                for (int l = 0; l < bias.Length; l++)
                    TotalBias += bias[l].ColumnCount;
            }
        }

        /// <summary>
        /// The total number of bias
        /// </summary>
        public int TotalBias { get; private set; }

        /// <summary>
        /// Creates an empty neural network
        /// </summary>
        /// <param name="inputs">Number of inputs</param>
        /// <param name="hiddenLayers">Number of hiddenLayers (each one with the same number of neurons)</param>
        /// <param name="hiddenLayerNeurons">Number of neurons in each hidden layer</param>
        /// <param name="outputs">Number of outputs</param>
        public NeuralNetwork(int inputs, int hiddenLayers, int hiddenLayerNeurons, int outputs)
        {
            if (inputs <= 0)
                throw new Exception("inputs must be greater than 0");

            if (outputs <= 0)
                throw new Exception("outputs must be greater than 0");

            if (hiddenLayerNeurons != 0 || hiddenLayers != 0)
            {
                if (hiddenLayers <= 0)
                    throw new Exception("hiddenLayers must be greater than 0");

                if (hiddenLayerNeurons <= 0)
                    throw new Exception("hiddenLayerNeurons must be greater than 0");
            }

            //Add the output layer weigths and bias
            weights = new Matrix<float>[hiddenLayers + 1];
            bias = new Matrix<float>[hiddenLayers + 1];

            if (hiddenLayerNeurons > 0)
            {
                weights[0] = Matrix<float>.Build.Dense(inputs, hiddenLayerNeurons); //Input layer
                bias[0] = Matrix<float>.Build.Dense(1, hiddenLayerNeurons);

                weights[hiddenLayers] = Matrix<float>.Build.Dense(hiddenLayerNeurons, outputs); //Output layer
            }
            else
            {
                weights[0] = Matrix<float>.Build.Dense(inputs, outputs); //Input layer
                bias[0] = Matrix<float>.Build.Dense(1, outputs);

                weights[hiddenLayers] = Matrix<float>.Build.Dense(inputs, outputs);  //Output layer

            }

            bias[hiddenLayers] = Matrix<float>.Build.Dense(1, outputs); //Output layer


            //Hidden layers
            for (int l = 1; l < hiddenLayers; l++)
            {
                weights[l] = Matrix<float>.Build.Dense(hiddenLayerNeurons, hiddenLayerNeurons);
                bias[l] = Matrix<float>.Build.Dense(1, hiddenLayerNeurons);
            }

            Weights = weights;
            Bias = bias;
        }

        /// <summary>
        /// Creates an empty neural network without hidden layers
        /// </summary>
        /// <param name="inputs">Number of inputs</param>
        /// <param name="outputs">Number of outputs</param>
        public NeuralNetwork(int inputs, int outputs)
        {
            if (inputs <= 0)
                throw new Exception("inputs must be greater than 0");

            if (outputs <= 0)
                throw new Exception("outputs must be greater than 0");

            //Add the output layer weigths and bias
            Weights = new Matrix<float>[1];
            Bias = new Matrix<float>[1];

            Weights[0] = Matrix<float>.Build.Dense(Inputs, Outputs); //Input layer
            Bias[0] = Matrix<float>.Build.Dense(1, Outputs);
        }

        public NeuralNetwork(Matrix<float>[] weights, Matrix<float>[] bias)
        {
            this.weights = new Matrix<float>[weights.Length];
            this.bias = new Matrix<float>[bias.Length];

            for(int i = 0; i < weights.Length; i++)
            {
                this.weights[i] = Matrix<float>.Build.DenseOfMatrix(weights[i]);
                this.bias[i] = Matrix<float>.Build.DenseOfMatrix(bias[i]);
            }

            Weights = weights;
            Bias = bias;
        }

        public NeuralNetwork(NeuralNetwork neuralNetwork)
        {
            weights = new Matrix<float>[neuralNetwork.Weights.Length];
            bias = new Matrix<float>[neuralNetwork.Bias.Length];

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = Matrix<float>.Build.DenseOfMatrix(neuralNetwork.Weights[i]);
                bias[i] = Matrix<float>.Build.DenseOfMatrix(neuralNetwork.Bias[i]);
            }

            Weights = weights;
            Bias = bias;
        }

        protected NeuralNetwork() { }

        public Matrix<float> Compute(Matrix<float> inputs)
        {
            if (inputs.RowCount != 1)
                throw new Exception();

            if (inputs.ColumnCount != Inputs)
                throw new Exception();

            Matrix<float> lastLayerResult = Matrix<float>.Build.DenseOfMatrix(inputs);
            for (int l = 0; l < Weights.Length; l++)
            {

                lastLayerResult *= Weights[l];
                lastLayerResult += Bias[l];

                if (l < Weights.Length - 1)
                    for (int j = 0; j < lastLayerResult.ColumnCount; j++)
                    {
                        lastLayerResult[0, j] = ActivationFunction(lastLayerResult[0, j]);
                    }
                else
                {
                    SoftMax(lastLayerResult);
                    return lastLayerResult;
                }
            }

            return lastLayerResult;
        }
        
        private float ActivationFunction(float x)
        {
            switch (FunctionType)
            {
                case FunctionType.Sigmoid:
                    return (float)(1 / (1 + Math.Pow(Math.E, -x)));

                case FunctionType.Hyperbolic_Tangent:
                    float exp = (float)Math.Exp(-2 * x);
                    return (1 - exp) / (1 + exp);

                case FunctionType.ReLu:
                    if (x < 0)
                        return 0;
                    else
                        return x;

                case FunctionType.Leaky_ReLu:
                    if (x < 0)
                        return x * 0.01f;
                    else
                        return x;

                case FunctionType.Swish:
                    return (float)(x /( 1 + Math.Exp(-x)));

                case FunctionType.Gaussian:
                    return (float)Math.Exp(-(x * x));

                default:
                    return float.NaN;
            }

        }

        private void SoftMax(Matrix<float> matrix)
        {       
            

            double sum = 0;
            for (int j = 0; j < matrix.ColumnCount; j++)
            {
                matrix[0, j] = (float)SpecialFunctions.Logistic(matrix[0, j]);
                sum += Math.Exp(matrix[0, j]);
            }
            /*
            for (int j = 0; j < matrix.RowCount; j++)
            {
                if (matrix[0, j] > sum)
                    Console.WriteLine("");

                matrix[0, j] = (float)(Math.Exp(matrix[0, j]) / sum);
            }*/
        }

        /// <summary>
        /// Randomize all values of the neural network
        /// </summary>
        public void Randomize()
        {
            for (int l = 0; l < Weights.Length; l++)
                for (int j = 0; j < Bias[l].ColumnCount; j++)
                {
                    Bias[l][0, j] = ThreadSafeRandom.Next();

                    for (int i = 0; i < Weights[l].ColumnCount; i++)
                        Weights[l][i, j] = ThreadSafeRandom.Next();
                }

        }

        public string AccountsToString()
        {
            StringBuilder sb = new StringBuilder();

            Matrix<float> input = Matrix<float>.Build.Dense(1, Inputs);
            Matrix<float> output = Matrix<float>.Build.Dense(1, Outputs);

            for (int j = 0; j < Inputs; j++)
                input[0, j] = j;

            for (int j = 0; j < Outputs; j++)
                output[0, j] = j;

            for (int l = 0; l < TotalLayers; l++)
                sb.Append("Sigmoid(");

            sb.Append('\n');
            sb.AppendLine(input.ToString());
            sb.AppendLine("X");
            sb.AppendLine(Weights[0].ToString());
            sb.AppendLine("+");
            sb.AppendLine(Bias[0].ToString());
            sb.AppendLine(")");

            if (TotalLayers > 1)
            {
                for (int l = 1; l < HiddenLayers; l++)
                {
                    sb.AppendLine("X");
                    sb.AppendLine(Weights[l].ToString());
                    sb.AppendLine("+");
                    sb.AppendLine(Bias[l].ToString());
                    sb.AppendLine(")");
                }

                sb.AppendLine("X");
                sb.AppendLine(Weights[TotalLayers - 1].ToString());
                sb.AppendLine("+");
                sb.AppendLine(Bias[TotalLayers - 1].ToString());
                sb.AppendLine(")");
                sb.AppendLine("=");
                sb.AppendLine(output.ToString());
            }
            return sb.ToString();
        }

        public Bitmap Draw()
        {
            const int layerSpacing = 60;
            const int neuronRadius = 10;
            const int neuronSpacing = 25;
            const int maxStroke = 4;

            int HighNeuronNumber = 0;

            foreach (Matrix<float> matrix in bias)
                if (matrix.ColumnCount > HighNeuronNumber)
                    HighNeuronNumber = matrix.ColumnCount;

            if (HighNeuronNumber < Inputs)
                HighNeuronNumber = Inputs;

            if (HighNeuronNumber < Outputs)
                HighNeuronNumber = Outputs;

            int width = neuronRadius * 2 + TotalLayers * (neuronRadius * 2 + layerSpacing) + 1;
            int height = HighNeuronNumber * (neuronSpacing + 2 * neuronRadius);

            Bitmap bitmap = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush;
            Pen pen;

            //Draw weights
            for (int l = 0; l < weights.Length; l++)
                for (int n = 0; n < weights[l].ColumnCount; n++)
                    for (int w = 0; w < weights[l].RowCount; w++)
                    {
                        float size = Math.Abs(weights[l][w, n]/5) / (Math.Abs(weights[l][w, n] / 5) + 1);
                        size *= maxStroke;

                        pen = new Pen(weights[l][w, n] > 0 ? Color.Green : Color.Red, size);

                        int x0 = 2 * neuronRadius + l * (neuronRadius * 2 + layerSpacing);
                        int y0 = neuronRadius + w * (neuronRadius * 2 + neuronSpacing);

                        int x1 = x0 + layerSpacing;
                        int y1 = neuronRadius + n * (neuronRadius * 2 + neuronSpacing);

                        graphics.DrawLine(pen, x0, y0, x1, y1);
                    }

            for (int l = 0; l <= weights.Length; l++)
            {
                if (l < weights.Length)
                    for (int n = 0; n < weights[l].ColumnCount; n++)
                        for (int w = 0; w < weights[l].RowCount; w++)
                        {
                            int x = l * (neuronRadius * 2 + layerSpacing);
                            int y = w * (neuronRadius * 2 + neuronSpacing);

                            brush = new SolidBrush(Color.Black);
                            graphics.FillEllipse(brush, x, y, neuronRadius * 2, neuronRadius * 2);
                        }
                else
                    for (int w = 0; w < weights[l - 1].ColumnCount; w++)
                    {
                        int x = l * (neuronRadius * 2 + layerSpacing);
                        int y = w * (neuronRadius * 2 + neuronSpacing);

                        brush = new SolidBrush(Color.Black);
                        graphics.FillEllipse(brush, x, y, neuronRadius * 2, neuronRadius * 2);
                    }

            }
            graphics.Dispose();

            return bitmap;
        }

    }

    public enum FunctionType
    {
        ReLu,
        Leaky_ReLu,
        Swish,
        Gaussian,
        Sigmoid,
        Hyperbolic_Tangent
    }
}
